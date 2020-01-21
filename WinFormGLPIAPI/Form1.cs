using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGLPIAPI
{
    public partial class Form1 : Form
    {
        SessionToken myToken = new SessionToken();
        
        List<Ticket> tickets = new List<Ticket>();
        List<int> selectedTickets = new List<int>();
        public Form1()
        {
            InitializeComponent();
            myToken.session_token = "";
            CB_status.Items.Add("Non défini");
            CB_status.Items.Add("Nouveau");
            CB_status.Items.Add("En cours (Attribué)");
            CB_status.Items.Add("En cours (Planifié)");
            CB_status.Items.Add("En attente");
            CB_status.Items.Add("Résolu");
            CB_status.Items.Add("Clos");
            CB_status.SelectedIndex = 0;

            if (File.Exists(".\\config.txt"))
            {
                try
                {
                    foreach (var line in File.ReadAllLines(".\\config.txt"))
                    {
                        if (line.Contains("IP= "))
                        {
                            TB_ipAddress.Text = line.Substring(4, line.Length - 4);
                        }

                        if (line.Contains("AT= "))
                        {
                            TB_appToken.Text = line.Substring(4, line.Length - 4);
                        }
                        if (line.Contains("UT= "))
                        {
                            TB_userToken.Text = line.Substring(4, line.Length - 4);
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Impossible de récupérer la configuration précédente", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }


        }

        private void BTN_getTickets_Click(object sender, EventArgs e)
        {
            try
            {

                var client = new RestClient("http://" + TB_ipAddress.Text + "/glpi/apirest.php/");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("Ticket", Method.GET);
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "user_token " + TB_userToken.Text);
                request.AddHeader("App-Token", TB_appToken.Text);
                request.AddHeader("Session-Token", myToken.session_token);

                // execute the request
                IRestResponse response = client.Execute(request);
                string content = response.Content; // raw content as string
                int statusCode = Convert.ToInt32(response.StatusCode);
                string headerContent = response.StatusCode.ToString();



                tickets = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<List<Ticket>>(content);

                LB_tickets.Items.Clear();
                foreach (Ticket item in tickets)

                {


                    if ((DateTime.Compare(Convert.ToDateTime(item.date_creation), Convert.ToDateTime(DTP_startDate.Value))) >= 0 && (DateTime.Compare(Convert.ToDateTime(item.date_creation), Convert.ToDateTime(DTP_endDate.Value))) <= 0)
                    {
                        if (CB_status.SelectedIndex.Equals(0))
                        {
                            LB_tickets.Items.Add("N° " + item.id + " " + item.name + " " + item.date_creation.ToString());
                        }
                        else
                        {
                            if (item.status.Equals(CB_status.SelectedIndex))
                            {
                                LB_tickets.Items.Add("N° " + item.id + " " + item.name + " " + item.date_creation.ToString());
                            }
                        }

                    }


                }


            }
            catch
            {
                MessageBox.Show("Aucune session n'a été démarrée, veuillez à en démarrer une", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_initSession_Click(object sender, EventArgs e)
        {
            try
            {
                //List<SessionTokenAPI> items = new List<SessionTokenAPI>();

                var client = new RestClient("http://" + TB_ipAddress.Text + "/glpi/apirest.php/");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("initSession", Method.GET);
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "user_token " + TB_userToken.Text);
                request.AddHeader("App-Token", TB_appToken.Text);

                // execute the request
                IRestResponse response = client.Execute(request);
                string content = response.Content; // raw content as string
                int statusCode = Convert.ToInt32(response.StatusCode);
                string headerContent = response.StatusCode.ToString();

                if (statusCode.Equals(200))
                {
                    MessageBox.Show("La session est bien initialisée !", "Avertissement", MessageBoxButtons.OK);
                    myToken = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<SessionToken>(content);
                    L_sessionStatus.Text = "Session démarrée : " + myToken.session_token;
                    L_sessionStatus.ForeColor = Color.Green;
                    L_killSession.Enabled = true;
                    BTN_initSession.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite !", "Avertissement", MessageBoxButtons.OK);
                }
            }

            catch
            {
                MessageBox.Show("une erreur s'est produite, vérifiez vos informations de connexion", "Avertissement", MessageBoxButtons.OK);
            }
        }

        private void L_killSession_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://" + TB_ipAddress.Text + "/glpi/apirest.php/");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);

                var request = new RestRequest("killSession", Method.GET);
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "user_token " + TB_userToken.Text);
                request.AddHeader("App-Token", TB_appToken.Text);
                request.AddHeader("Session-Token", myToken.session_token);

                // execute the request
                IRestResponse response = client.Execute(request);
                string content = response.Content; // raw content as string
                int statusCode = Convert.ToInt32(response.StatusCode);
                string headerContent = response.StatusCode.ToString();

                if (statusCode.Equals(200))
                {
                    MessageBox.Show("La session est bien détruite !", "Avertissement", MessageBoxButtons.OK);
                    L_sessionStatus.Text = "Session détruite";
                    L_sessionStatus.ForeColor = Color.Red;
                    L_killSession.Enabled = false;
                    BTN_initSession.Enabled = true;
                    myToken.session_token = "";
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite !", "Avertissement", MessageBoxButtons.OK);
                }
            }

            catch
            {
                MessageBox.Show("Une erreur s'est produite !", "Avertissement", MessageBoxButtons.OK);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter txt = new StreamWriter(".\\config.txt");
            txt.Write("IP= " + TB_ipAddress.Text + "\n");
            txt.Write("AT= " + TB_appToken.Text + "\n");
            txt.Write("UT= " + TB_userToken.Text + "\n");
            txt.Close();
            if (!myToken.session_token.Equals(""))
            {
                try
                {
                    var client = new RestClient("http://" + TB_ipAddress.Text + "/glpi/apirest.php/");
                    // client.Authenticator = new HttpBasicAuthenticator(username, password);

                    var request = new RestRequest("killSession", Method.GET);
                    //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                    //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Authorization", "user_token " + TB_userToken.Text);
                    request.AddHeader("App-Token", TB_appToken.Text);
                    request.AddHeader("Session-Token", myToken.session_token);

                    // execute the request
                    IRestResponse response = client.Execute(request);
                    string content = response.Content; // raw content as string
                    int statusCode = Convert.ToInt32(response.StatusCode);
                    string headerContent = response.StatusCode.ToString();

                    if (statusCode.Equals(200))
                    {
                        MessageBox.Show("La session est bien détruite !", "Avertissement", MessageBoxButtons.OK);
                        L_sessionStatus.Text = "Session détruite";
                        L_sessionStatus.ForeColor = Color.Red;
                        L_killSession.Enabled = false;
                        BTN_initSession.Enabled = true;
                        myToken.session_token ="";
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite !", "Avertissement", MessageBoxButtons.OK);
                    }
                }

                catch
                {
                    MessageBox.Show("Une erreur s'est produite !", "Avertissement", MessageBoxButtons.OK);
                }
            }

        }

        private void BTN_moreInfo_Click(object sender, EventArgs e)
        {
            foreach (Ticket item in tickets)
            {
                if (LB_tickets.SelectedIndex.Equals(tickets.IndexOf(item)))
                {
                    Details newForm = new Details(item.name, item.content, item.priority);
                    newForm.Show();
                }

            }
        }

        private void LB_tickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
