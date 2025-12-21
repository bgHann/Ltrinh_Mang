namespace bt1._5_chatSimpleGUI
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rtbLog);
			this.groupBox1.Location = new System.Drawing.Point(178, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(621, 271);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ChatLog";
			// 
			// rtbLog
			// 
			this.rtbLog.BackColor = System.Drawing.Color.LightCyan;
			this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbLog.Location = new System.Drawing.Point(3, 27);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.ReadOnly = true;
			this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbLog.Size = new System.Drawing.Size(615, 241);
			this.rtbLog.TabIndex = 0;
			this.rtbLog.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
			this.groupBox2.Controls.Add(this.btnClear);
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnLoad);
			this.groupBox2.Location = new System.Drawing.Point(876, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 261);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "System";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(43, 135);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(115, 40);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(43, 89);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(115, 40);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save To File";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(43, 192);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(115, 38);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(43, 40);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(115, 43);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load From File";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.LightCyan;
			this.groupBox3.Controls.Add(this.btnSend);
			this.groupBox3.Controls.Add(this.txtMessage);
			this.groupBox3.Location = new System.Drawing.Point(181, 497);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(895, 100);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Message";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(630, 31);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(90, 46);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(125, 39);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(450, 31);
			this.txtMessage.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.LightCyan;
			this.groupBox4.Controls.Add(this.btnDisconnect);
			this.groupBox4.Controls.Add(this.btnConnect);
			this.groupBox4.Controls.Add(this.btnStop);
			this.groupBox4.Controls.Add(this.btnStart);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.txtPort);
			this.groupBox4.Controls.Add(this.txtIP);
			this.groupBox4.Location = new System.Drawing.Point(67, 36);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1088, 120);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "|Connection    ";
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(914, 42);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(132, 44);
			this.btnDisconnect.TabIndex = 7;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(777, 42);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(127, 44);
			this.btnConnect.TabIndex = 6;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(615, 42);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(156, 44);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop Service";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(465, 40);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(144, 46);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start Service";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "PORT";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "IP";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(334, 49);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(100, 31);
			this.txtPort.TabIndex = 1;
			this.txtPort.Text = "9000";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(75, 49);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(144, 31);
			this.txtIP.TabIndex = 0;
			this.txtIP.Text = "127.0.0.1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(1284, 680);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

