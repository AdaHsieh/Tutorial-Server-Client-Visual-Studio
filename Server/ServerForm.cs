using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Server
{
	public partial class ServerForm : Form
	{
		private TcpClient client;
		public StreamReader STR;
		public StreamWriter STW;
		public string receive;
		public String text_to_send;
		TcpListener listerner;

		public ServerForm()
		{
			InitializeComponent();
			btnServerSend.Enabled = false;

			//TextBox.CheckForIllegalCrossThreadCalls = false;

			///*Get My Own IP*/
			//IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
			//foreach (IPAddress address in localIP)
			//{
			//	if (address.AddressFamily == AddressFamily.InterNetwork)
			//	{
			//		txtSerIP.Text = address.ToString();
			//	}
			//}
		}

		private void btnStartServer_Click(object sender, EventArgs e)
		{
			txtLog.AppendText("執行中...");

			listerner = new TcpListener(IPAddress.Any,int.Parse(txtSerPort.Text));
			listerner.Start();
			
			client = listerner.AcceptTcpClient();
			STR = new StreamReader(client.GetStream());
			STW = new StreamWriter(client.GetStream());
			STW.AutoFlush = true;

			btnServerSend.Enabled = true;
			
			backgroundWorker1.RunWorkerAsync();						//start receiving Data in background
			backgroundWorker2.WorkerSupportsCancellation = true;    //Ability to cancel this thread

		}

		

		private void btnServerSend_Click(object sender, EventArgs e)
		{
			if (tbServerSend.Text.Length == 0) return;
			else
			{
				text_to_send = tbServerSend.Text;
				backgroundWorker2.RunWorkerAsync();
			}
			tbServerSend.Text = "";		
		}
		 
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //receive data
		{
			while (client.Connected)
			{
				try
				{
					receive = STR.ReadLine();
					this.tbServerMsg.Invoke(
						new MethodInvoker(delegate ()
						{
							tbServerMsg.AppendText("Client : " + receive + "\n");
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
				this.tbServerSend.Invoke(
					new MethodInvoker(delegate ()
					{					
						tbServerMsg.AppendText("Server : " + text_to_send + "\n");						
					}
					));
				text_to_send = "";
			}
			else
			{
				MessageBox.Show("Send Failed!");
			}
			backgroundWorker2.CancelAsync();
		}

		
	}
}
