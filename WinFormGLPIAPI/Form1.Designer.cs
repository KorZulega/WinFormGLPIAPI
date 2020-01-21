namespace WinFormGLPIAPI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_tickets = new System.Windows.Forms.ListBox();
            this.TB_ipAddress = new System.Windows.Forms.TextBox();
            this.TB_appToken = new System.Windows.Forms.TextBox();
            this.DTP_endDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_startDate = new System.Windows.Forms.DateTimePicker();
            this.BTN_getTickets = new System.Windows.Forms.Button();
            this.TB_userToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_moreInfo = new System.Windows.Forms.Button();
            this.BTN_initSession = new System.Windows.Forms.Button();
            this.L_sessionStatus = new System.Windows.Forms.Label();
            this.L_killSession = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_tickets
            // 
            this.LB_tickets.Dock = System.Windows.Forms.DockStyle.Right;
            this.LB_tickets.FormattingEnabled = true;
            this.LB_tickets.ItemHeight = 16;
            this.LB_tickets.Location = new System.Drawing.Point(732, 0);
            this.LB_tickets.Name = "LB_tickets";
            this.LB_tickets.Size = new System.Drawing.Size(447, 493);
            this.LB_tickets.TabIndex = 0;
            this.LB_tickets.SelectedIndexChanged += new System.EventHandler(this.LB_tickets_SelectedIndexChanged);
            // 
            // TB_ipAddress
            // 
            this.TB_ipAddress.Location = new System.Drawing.Point(172, 60);
            this.TB_ipAddress.Name = "TB_ipAddress";
            this.TB_ipAddress.Size = new System.Drawing.Size(276, 22);
            this.TB_ipAddress.TabIndex = 1;
            // 
            // TB_appToken
            // 
            this.TB_appToken.Location = new System.Drawing.Point(172, 101);
            this.TB_appToken.Name = "TB_appToken";
            this.TB_appToken.Size = new System.Drawing.Size(276, 22);
            this.TB_appToken.TabIndex = 2;
            // 
            // DTP_endDate
            // 
            this.DTP_endDate.CustomFormat = "ddd dd MMM yyyy hh:mm:ss";
            this.DTP_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_endDate.Location = new System.Drawing.Point(417, 214);
            this.DTP_endDate.Name = "DTP_endDate";
            this.DTP_endDate.Size = new System.Drawing.Size(237, 22);
            this.DTP_endDate.TabIndex = 3;
            // 
            // DTP_startDate
            // 
            this.DTP_startDate.CustomFormat = "ddd dd MMM yyyy hh:mm:ss";
            this.DTP_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_startDate.Location = new System.Drawing.Point(56, 214);
            this.DTP_startDate.Name = "DTP_startDate";
            this.DTP_startDate.Size = new System.Drawing.Size(241, 22);
            this.DTP_startDate.TabIndex = 4;
            // 
            // BTN_getTickets
            // 
            this.BTN_getTickets.Location = new System.Drawing.Point(56, 360);
            this.BTN_getTickets.Name = "BTN_getTickets";
            this.BTN_getTickets.Size = new System.Drawing.Size(160, 23);
            this.BTN_getTickets.TabIndex = 5;
            this.BTN_getTickets.Text = "Obtenir les tickets";
            this.BTN_getTickets.UseVisualStyleBackColor = true;
            this.BTN_getTickets.Click += new System.EventHandler(this.BTN_getTickets_Click);
            // 
            // TB_userToken
            // 
            this.TB_userToken.Location = new System.Drawing.Point(172, 149);
            this.TB_userToken.Name = "TB_userToken";
            this.TB_userToken.Size = new System.Drawing.Size(276, 22);
            this.TB_userToken.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adresse IP de l\'API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "App Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Token";
            // 
            // BTN_moreInfo
            // 
            this.BTN_moreInfo.Location = new System.Drawing.Point(299, 360);
            this.BTN_moreInfo.Name = "BTN_moreInfo";
            this.BTN_moreInfo.Size = new System.Drawing.Size(189, 23);
            this.BTN_moreInfo.TabIndex = 10;
            this.BTN_moreInfo.Text = "Plus d\'informations";
            this.BTN_moreInfo.UseVisualStyleBackColor = true;
            this.BTN_moreInfo.Click += new System.EventHandler(this.BTN_moreInfo_Click);
            // 
            // BTN_initSession
            // 
            this.BTN_initSession.Location = new System.Drawing.Point(56, 296);
            this.BTN_initSession.Name = "BTN_initSession";
            this.BTN_initSession.Size = new System.Drawing.Size(160, 23);
            this.BTN_initSession.TabIndex = 11;
            this.BTN_initSession.Text = "Démarrer la session";
            this.BTN_initSession.UseVisualStyleBackColor = true;
            this.BTN_initSession.Click += new System.EventHandler(this.BTN_initSession_Click);
            // 
            // L_sessionStatus
            // 
            this.L_sessionStatus.AutoSize = true;
            this.L_sessionStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L_sessionStatus.Location = new System.Drawing.Point(296, 263);
            this.L_sessionStatus.Name = "L_sessionStatus";
            this.L_sessionStatus.Size = new System.Drawing.Size(146, 17);
            this.L_sessionStatus.TabIndex = 12;
            this.L_sessionStatus.Text = "Session non démarée";
            this.L_sessionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_killSession
            // 
            this.L_killSession.Enabled = false;
            this.L_killSession.Location = new System.Drawing.Point(299, 296);
            this.L_killSession.Name = "L_killSession";
            this.L_killSession.Size = new System.Drawing.Size(189, 23);
            this.L_killSession.TabIndex = 13;
            this.L_killSession.Text = "Arrêter la session";
            this.L_killSession.UseVisualStyleBackColor = true;
            this.L_killSession.Click += new System.EventHandler(this.L_killSession_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Du :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Au :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Statut :";
            // 
            // CB_status
            // 
            this.CB_status.FormattingEnabled = true;
            this.CB_status.Location = new System.Drawing.Point(75, 257);
            this.CB_status.Name = "CB_status";
            this.CB_status.Size = new System.Drawing.Size(173, 24);
            this.CB_status.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 493);
            this.Controls.Add(this.CB_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_killSession);
            this.Controls.Add(this.L_sessionStatus);
            this.Controls.Add(this.BTN_initSession);
            this.Controls.Add(this.BTN_moreInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_userToken);
            this.Controls.Add(this.BTN_getTickets);
            this.Controls.Add(this.DTP_startDate);
            this.Controls.Add(this.DTP_endDate);
            this.Controls.Add(this.TB_appToken);
            this.Controls.Add(this.TB_ipAddress);
            this.Controls.Add(this.LB_tickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketRetriever";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_tickets;
        private System.Windows.Forms.TextBox TB_ipAddress;
        private System.Windows.Forms.TextBox TB_appToken;
        private System.Windows.Forms.DateTimePicker DTP_endDate;
        private System.Windows.Forms.DateTimePicker DTP_startDate;
        private System.Windows.Forms.Button BTN_getTickets;
        private System.Windows.Forms.TextBox TB_userToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_moreInfo;
        private System.Windows.Forms.Button BTN_initSession;
        private System.Windows.Forms.Label L_sessionStatus;
        private System.Windows.Forms.Button L_killSession;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_status;
    }
}

