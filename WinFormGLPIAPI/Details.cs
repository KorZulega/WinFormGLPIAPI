using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGLPIAPI
{
    public partial class Details : Form
    {
        public Details( string title, string content, int priority)
        {
            InitializeComponent();
            L_title.Text = title;
            TB_content.Text = title;
            L_priorityNumber.Text = priority.ToString();
                 
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
