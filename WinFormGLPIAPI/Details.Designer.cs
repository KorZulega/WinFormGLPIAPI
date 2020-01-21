namespace WinFormGLPIAPI
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_title = new System.Windows.Forms.Label();
            this.TB_content = new System.Windows.Forms.TextBox();
            this.BTN_close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.L_priority = new System.Windows.Forms.Label();
            this.L_priorityNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.L_title, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_content, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_close, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_title
            // 
            this.L_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_title.AutoSize = true;
            this.L_title.Location = new System.Drawing.Point(23, 20);
            this.L_title.Name = "L_title";
            this.L_title.Size = new System.Drawing.Size(821, 20);
            this.L_title.TabIndex = 0;
            this.L_title.Text = "label1";
            this.L_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_content
            // 
            this.TB_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_content.Location = new System.Drawing.Point(23, 43);
            this.TB_content.Multiline = true;
            this.TB_content.Name = "TB_content";
            this.TB_content.Size = new System.Drawing.Size(821, 179);
            this.TB_content.TabIndex = 1;
            // 
            // BTN_close
            // 
            this.BTN_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_close.Location = new System.Drawing.Point(769, 413);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(75, 23);
            this.BTN_close.TabIndex = 2;
            this.BTN_close.Text = "Fermer";
            this.BTN_close.UseVisualStyleBackColor = true;
            this.BTN_close.Click += new System.EventHandler(this.BTN_close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.L_priority);
            this.flowLayoutPanel1.Controls.Add(this.L_priorityNumber);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 228);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 179);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // L_priority
            // 
            this.L_priority.AutoSize = true;
            this.L_priority.Location = new System.Drawing.Point(3, 0);
            this.L_priority.Name = "L_priority";
            this.L_priority.Size = new System.Drawing.Size(61, 17);
            this.L_priority.TabIndex = 0;
            this.L_priority.Text = "Priorité :";
            // 
            // L_priorityNumber
            // 
            this.L_priorityNumber.AutoSize = true;
            this.L_priorityNumber.Location = new System.Drawing.Point(70, 0);
            this.L_priorityNumber.Name = "L_priorityNumber";
            this.L_priorityNumber.Size = new System.Drawing.Size(16, 17);
            this.L_priorityNumber.TabIndex = 1;
            this.L_priorityNumber.Text = "0";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_title;
        private System.Windows.Forms.TextBox TB_content;
        private System.Windows.Forms.Button BTN_close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label L_priority;
        private System.Windows.Forms.Label L_priorityNumber;
    }
}