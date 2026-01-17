namespace SimpleChat
{
    partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabServer = new System.Windows.Forms.TabPage();
			this.button5abtnClearServer = new System.Windows.Forms.Button();
			this.btnExitServer = new System.Windows.Forms.Button();
			this.btnSaveServer = new System.Windows.Forms.Button();
			this.btnLoadServer = new System.Windows.Forms.Button();
			this.txtServerSend = new System.Windows.Forms.TextBox();
			this.rtbServer = new System.Windows.Forms.RichTextBox();
			this.btnServerSend = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.numServerPort = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numClientPort = new System.Windows.Forms.NumericUpDown();
			this.rtbClient = new System.Windows.Forms.RichTextBox();
			this.btnClientSend = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtClientSend = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnLoadClient = new System.Windows.Forms.Button();
			this.btnSaveClient = new System.Windows.Forms.Button();
			this.btnClearClient = new System.Windows.Forms.Button();
			this.btnExitClient = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabServer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numClientPort)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabServer);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(47, 117);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(951, 616);
			this.tabControl1.TabIndex = 0;
			// 
			// tabServer
			// 
			this.tabServer.Controls.Add(this.button5abtnClearServer);
			this.tabServer.Controls.Add(this.btnExitServer);
			this.tabServer.Controls.Add(this.btnSaveServer);
			this.tabServer.Controls.Add(this.btnLoadServer);
			this.tabServer.Controls.Add(this.txtServerSend);
			this.tabServer.Controls.Add(this.rtbServer);
			this.tabServer.Controls.Add(this.btnServerSend);
			this.tabServer.Controls.Add(this.btnStop);
			this.tabServer.Controls.Add(this.btnStart);
			this.tabServer.Controls.Add(this.numServerPort);
			this.tabServer.Controls.Add(this.label1);
			this.tabServer.Location = new System.Drawing.Point(8, 39);
			this.tabServer.Name = "tabServer";
			this.tabServer.Padding = new System.Windows.Forms.Padding(3);
			this.tabServer.Size = new System.Drawing.Size(935, 569);
			this.tabServer.TabIndex = 0;
			this.tabServer.Text = "Server Mode";
			this.tabServer.UseVisualStyleBackColor = true;
			// 
			// button5abtnClearServer
			// 
			this.button5abtnClearServer.Location = new System.Drawing.Point(707, 275);
			this.button5abtnClearServer.Name = "button5abtnClearServer";
			this.button5abtnClearServer.Size = new System.Drawing.Size(198, 50);
			this.button5abtnClearServer.TabIndex = 11;
			this.button5abtnClearServer.Text = "Clear";
			this.button5abtnClearServer.UseVisualStyleBackColor = true;
			this.button5abtnClearServer.Click += new System.EventHandler(this.button5abtnClearServer_Click);
			// 
			// btnExitServer
			// 
			this.btnExitServer.Location = new System.Drawing.Point(707, 344);
			this.btnExitServer.Name = "btnExitServer";
			this.btnExitServer.Size = new System.Drawing.Size(199, 47);
			this.btnExitServer.TabIndex = 10;
			this.btnExitServer.Text = "Exit";
			this.btnExitServer.UseVisualStyleBackColor = true;
			this.btnExitServer.Click += new System.EventHandler(this.btnExitServer_Click);
			// 
			// btnSaveServer
			// 
			this.btnSaveServer.Location = new System.Drawing.Point(707, 199);
			this.btnSaveServer.Name = "btnSaveServer";
			this.btnSaveServer.Size = new System.Drawing.Size(197, 49);
			this.btnSaveServer.TabIndex = 9;
			this.btnSaveServer.Text = "Save To File";
			this.btnSaveServer.UseVisualStyleBackColor = true;
			this.btnSaveServer.Click += new System.EventHandler(this.btnSaveServer_Click);
			// 
			// btnLoadServer
			// 
			this.btnLoadServer.Location = new System.Drawing.Point(707, 134);
			this.btnLoadServer.Name = "btnLoadServer";
			this.btnLoadServer.Size = new System.Drawing.Size(198, 59);
			this.btnLoadServer.TabIndex = 8;
			this.btnLoadServer.Text = "Load From File";
			this.btnLoadServer.UseVisualStyleBackColor = true;
			this.btnLoadServer.Click += new System.EventHandler(this.btnLoadServer_Click);
			// 
			// txtServerSend
			// 
			this.txtServerSend.Location = new System.Drawing.Point(60, 473);
			this.txtServerSend.Name = "txtServerSend";
			this.txtServerSend.Size = new System.Drawing.Size(502, 31);
			this.txtServerSend.TabIndex = 6;
			// 
			// rtbServer
			// 
			this.rtbServer.Location = new System.Drawing.Point(29, 120);
			this.rtbServer.Name = "rtbServer";
			this.rtbServer.ReadOnly = true;
			this.rtbServer.Size = new System.Drawing.Size(648, 303);
			this.rtbServer.TabIndex = 5;
			this.rtbServer.Text = "";
			// 
			// btnServerSend
			// 
			this.btnServerSend.Location = new System.Drawing.Point(674, 473);
			this.btnServerSend.Name = "btnServerSend";
			this.btnServerSend.Size = new System.Drawing.Size(151, 35);
			this.btnServerSend.TabIndex = 4;
			this.btnServerSend.Text = "Send";
			this.btnServerSend.UseVisualStyleBackColor = true;
			this.btnServerSend.Click += new System.EventHandler(this.btnServerSend_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(650, 29);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(149, 44);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "Stop Service";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(451, 27);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(159, 46);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start Service";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// numServerPort
			// 
			this.numServerPort.Location = new System.Drawing.Point(283, 36);
			this.numServerPort.Maximum = new decimal(new int[] {
            5668,
            0,
            0,
            0});
			this.numServerPort.Name = "numServerPort";
			this.numServerPort.Size = new System.Drawing.Size(120, 31);
			this.numServerPort.TabIndex = 1;
			this.numServerPort.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Listen on Port";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnExitClient);
			this.tabPage2.Controls.Add(this.btnClearClient);
			this.tabPage2.Controls.Add(this.btnSaveClient);
			this.tabPage2.Controls.Add(this.btnLoadClient);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.numClientPort);
			this.tabPage2.Controls.Add(this.rtbClient);
			this.tabPage2.Controls.Add(this.btnClientSend);
			this.tabPage2.Controls.Add(this.btnDisconnect);
			this.tabPage2.Controls.Add(this.btnConnect);
			this.tabPage2.Controls.Add(this.txtClientSend);
			this.tabPage2.Controls.Add(this.txtIP);
			this.tabPage2.Location = new System.Drawing.Point(8, 39);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(935, 569);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Client Mode";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(380, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Connect to Server";
			// 
			// numClientPort
			// 
			this.numClientPort.Location = new System.Drawing.Point(456, 57);
			this.numClientPort.Maximum = new decimal(new int[] {
            5889,
            0,
            0,
            0});
			this.numClientPort.Name = "numClientPort";
			this.numClientPort.Size = new System.Drawing.Size(120, 31);
			this.numClientPort.TabIndex = 6;
			this.numClientPort.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// rtbClient
			// 
			this.rtbClient.Location = new System.Drawing.Point(76, 168);
			this.rtbClient.Name = "rtbClient";
			this.rtbClient.Size = new System.Drawing.Size(622, 269);
			this.rtbClient.TabIndex = 5;
			this.rtbClient.Text = "";
			// 
			// btnClientSend
			// 
			this.btnClientSend.Location = new System.Drawing.Point(755, 489);
			this.btnClientSend.Name = "btnClientSend";
			this.btnClientSend.Size = new System.Drawing.Size(111, 43);
			this.btnClientSend.TabIndex = 4;
			this.btnClientSend.Text = "Send";
			this.btnClientSend.UseVisualStyleBackColor = true;
			this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(772, 45);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(130, 53);
			this.btnDisconnect.TabIndex = 3;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(614, 44);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(135, 54);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = " Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtClientSend
			// 
			this.txtClientSend.Location = new System.Drawing.Point(88, 495);
			this.txtClientSend.Name = "txtClientSend";
			this.txtClientSend.Size = new System.Drawing.Size(622, 31);
			this.txtClientSend.TabIndex = 1;
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(245, 57);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(100, 31);
			this.txtIP.TabIndex = 0;
			this.txtIP.Text = "127.0.0.1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label4.Location = new System.Drawing.Point(326, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(406, 43);
			this.label4.TabIndex = 1;
			this.label4.Text = "Simple Chat Application";
			// 
			// btnLoadClient
			// 
			this.btnLoadClient.Location = new System.Drawing.Point(726, 168);
			this.btnLoadClient.Name = "btnLoadClient";
			this.btnLoadClient.Size = new System.Drawing.Size(192, 57);
			this.btnLoadClient.TabIndex = 9;
			this.btnLoadClient.Text = "Load From File";
			this.btnLoadClient.UseVisualStyleBackColor = true;
			this.btnLoadClient.Click += new System.EventHandler(this.btnLoadClient_Click);
			// 
			// btnSaveClient
			// 
			this.btnSaveClient.Location = new System.Drawing.Point(726, 245);
			this.btnSaveClient.Name = "btnSaveClient";
			this.btnSaveClient.Size = new System.Drawing.Size(192, 51);
			this.btnSaveClient.TabIndex = 10;
			this.btnSaveClient.Text = "Save To File";
			this.btnSaveClient.UseVisualStyleBackColor = true;
			this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
			// 
			// btnClearClient
			// 
			this.btnClearClient.Location = new System.Drawing.Point(726, 302);
			this.btnClearClient.Name = "btnClearClient";
			this.btnClearClient.Size = new System.Drawing.Size(192, 54);
			this.btnClearClient.TabIndex = 11;
			this.btnClearClient.Text = "Clear";
			this.btnClearClient.UseVisualStyleBackColor = true;
			this.btnClearClient.Click += new System.EventHandler(this.btnClearClient_Click);
			// 
			// btnExitClient
			// 
			this.btnExitClient.Location = new System.Drawing.Point(726, 371);
			this.btnExitClient.Name = "btnExitClient";
			this.btnExitClient.Size = new System.Drawing.Size(192, 57);
			this.btnExitClient.TabIndex = 12;
			this.btnExitClient.Text = "Exit";
			this.btnExitClient.UseVisualStyleBackColor = true;
			this.btnExitClient.Click += new System.EventHandler(this.btnExitClient_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1110, 773);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "SimpleChat_BuiGiaHan";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabServer.ResumeLayout(false);
			this.tabServer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numClientPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TextBox txtServerSend;
        private System.Windows.Forms.RichTextBox rtbServer;
        private System.Windows.Forms.Button btnServerSend;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numClientPort;
        private System.Windows.Forms.Button btnClientSend;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtClientSend;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.RichTextBox rtbClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5abtnClearServer;
        private System.Windows.Forms.Button btnExitServer;
        private System.Windows.Forms.Button btnSaveServer;
        private System.Windows.Forms.Button btnLoadServer;
        private System.Windows.Forms.Button btnExitClient;
        private System.Windows.Forms.Button btnClearClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnLoadClient;
    }
}

