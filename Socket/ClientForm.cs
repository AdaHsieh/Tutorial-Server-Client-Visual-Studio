using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;




namespace Client
{
	public partial class ClientForm : Form
	{
		public TcpClient client;
		public StreamReader STR;
		public StreamWriter STW;
		public String text_to_send;
		public string receive;

		public ClientForm()
		{
			InitializeComponent();
			btnClientSend.Enabled = false;
			//TextBox.CheckForIllegalCrossThreadCalls = false;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			if (txbUserName.Text == "")
			{
				MessageBox.Show("需要輸入暱稱才能連線");
			}
			else
			{
				client = new TcpClient();
				IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(txtClientIP.Text), int.Parse(txtClientport.Text));

				try
				{
					client.Connect(IP_End);
					if (client.Connected)
					{
						txtLog.AppendText("連線成功");
						STR = new StreamReader(client.GetStream());
						STW = new StreamWriter(client.GetStream());
						STW.AutoFlush = true;

						btnClientSend.Enabled = true;

						backgroundWorker1.RunWorkerAsync();                     //start receiving Data in background
						backgroundWorker2.WorkerSupportsCancellation = true;    //Ability to cancel this thread

					}
				}
				catch (Exception x)
				{
					MessageBox.Show(x.Message.ToString());
					txtLog.AppendText("連線失敗");
				}
			}
		}
	
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //receive data
		{
			while (client.Connected)
			{
				try
				{
					receive = STR.ReadLine();
					this.tbxClientMsg.Invoke(
						new MethodInvoker(delegate ()
						{
							tbxClientMsg.AppendText("Server : " + receive + "\n");
						}
					));
					receive = "";
				}
				catch (Exception x)
				{
					MessageBox.Show(x.Message.ToString());
				}
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) //send data
		{
			if (client.Connected)
			{
				STW.WriteLine(text_to_send);
				this.tbxClientSend.Invoke(
					new MethodInvoker(delegate ()
					{
						tbxClientMsg.AppendText("Client : " + text_to_send + "\n");
					}
					));
				//text_to_send = "";
			}
			else
			{
				MessageBox.Show("Send Failed!");
			}
			backgroundWorker2.CancelAsync();
		}

		private void btnClientSend_Click(object sender, EventArgs e)
		{
			if (tbxClientSend.Text.Length == 0) return;
			else
			{
				text_to_send = tbxClientSend.Text;
				backgroundWorker2.RunWorkerAsync();
			}
			tbxClientSend.Text = "";
		}

		

	}
}
