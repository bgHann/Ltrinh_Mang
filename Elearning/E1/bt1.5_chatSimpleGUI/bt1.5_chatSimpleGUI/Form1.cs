using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace bt1._5_chatSimpleGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
		

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (txtMessage.Text.Trim() == "")
				return;

			rtbLog.AppendText("Me: " + txtMessage.Text + "\n");
			txtMessage.Clear();
		}

        private void btnLoad_Click(object sender, EventArgs e)
        {
			if (File.Exists("log.txt"))
				rtbLog.Text = File.ReadAllText("log.txt");
			else
				MessageBox.Show("Không tìm thấy file log.txt");
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			File.WriteAllText("log.txt", rtbLog.Text);
			MessageBox.Show("Đã lưu log.txt");
		}

        private void btnClear_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Xóa toàn bộ log?",
			   "Xác nhận",
			   MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				rtbLog.Clear();
			}
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Thoát chương trình?",
			   "Xác nhận",
			   MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

        private void btnStart_Click(object sender, EventArgs e)
        {
			rtbLog.AppendText("Server started..." + Environment.NewLine);
		}

        private void btnStop_Click(object sender, EventArgs e)
        {
			rtbLog.AppendText("Server stopped..." + Environment.NewLine);
		}

        private void btnConnect_Click(object sender, EventArgs e)
        {
			rtbLog.AppendText("Client connected..." + Environment.NewLine);
		}

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
			rtbLog.AppendText("Client disconnected..." + Environment.NewLine);
		}
    }
}
