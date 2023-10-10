namespace Client
{
    partial class Client
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
            this.list_chat = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCONNECT = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIpServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_chat
            // 
            this.list_chat.BackColor = System.Drawing.SystemColors.Window;
            this.list_chat.FormattingEnabled = true;
            this.list_chat.Location = new System.Drawing.Point(39, 173);
            this.list_chat.Name = "list_chat";
            this.list_chat.Size = new System.Drawing.Size(501, 238);
            this.list_chat.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(49, 426);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(424, 49);
            this.textBox7.TabIndex = 18;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Blue;
            this.btnSend.Location = new System.Drawing.Point(479, 426);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 49);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnCONNECT
            // 
            this.btnCONNECT.Location = new System.Drawing.Point(465, 127);
            this.btnCONNECT.Name = "btnCONNECT";
            this.btnCONNECT.Size = new System.Drawing.Size(75, 23);
            this.btnCONNECT.TabIndex = 16;
            this.btnCONNECT.Text = "CONNECT";
            this.btnCONNECT.UseVisualStyleBackColor = true;
            this.btnCONNECT.Click += new System.EventHandler(this.btnCONNECT_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(465, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(322, 129);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(100, 20);
            this.txtPortServer.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "PORT";
            // 
            // txtIpServer
            // 
            this.txtIpServer.Location = new System.Drawing.Point(88, 126);
            this.txtIpServer.Name = "txtIpServer";
            this.txtIpServer.Size = new System.Drawing.Size(100, 20);
            this.txtIpServer.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 514);
            this.Controls.Add(this.list_chat);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCONNECT);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPortServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIpServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_chat;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCONNECT;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIpServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}