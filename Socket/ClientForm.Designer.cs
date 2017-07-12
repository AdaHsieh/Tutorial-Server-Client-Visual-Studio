namespace Client
{
	partial class ClientForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConnect = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtClientport = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtClientIP = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.tbxClientSend = new System.Windows.Forms.TextBox();
			this.btnClientSend = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxClientMsg = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox6.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(74, 222);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(86, 24);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtLog);
			this.groupBox6.Controls.Add(this.txtClientport);
			this.groupBox6.Controls.Add(this.label5);
			this.groupBox6.Controls.Add(this.txtClientIP);
			this.groupBox6.Controls.Add(this.label7);
			this.groupBox6.Controls.Add(this.txbUserName);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Controls.Add(this.label9);
			this.groupBox6.Controls.Add(this.btnConnect);
			this.groupBox6.Location = new System.Drawing.Point(21, 22);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(166, 261);
			this.groupBox6.TabIndex = 18;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "用戶端資訊";
			// 
			// txtClientport
			// 
			this.txtClientport.Location = new System.Drawing.Point(9, 188);
			this.txtClientport.Name = "txtClientport";
			this.txtClientport.Size = new System.Drawing.Size(140, 23);
			this.txtClientport.TabIndex = 7;
			this.txtClientport.Text = "5555";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "port";
			// 
			// txtClientIP
			// 
			this.txtClientIP.Location = new System.Drawing.Point(9, 139);
			this.txtClientIP.Name = "txtClientIP";
			this.txtClientIP.Size = new System.Drawing.Size(140, 23);
			this.txtClientIP.TabIndex = 5;
			this.txtClientIP.Text = "127.0.0.1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 4;
			this.label7.Text = "伺服器IP";
			// 
			// txbUserName
			// 
			this.txbUserName.Location = new System.Drawing.Point(9, 88);
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(140, 23);
			this.txbUserName.TabIndex = 3;
			this.txbUserName.Text = "ClientPC";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "伺服器名稱";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "狀態";
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.Color.White;
			this.txtLog.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtLog.Location = new System.Drawing.Point(6, 40);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(143, 24);
			this.txtLog.TabIndex = 0;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			// 
			// tbxClientSend
			// 
			this.tbxClientSend.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbxClientSend.Location = new System.Drawing.Point(205, 40);
			this.tbxClientSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbxClientSend.Multiline = true;
			this.tbxClientSend.Name = "tbxClientSend";
			this.tbxClientSend.Size = new System.Drawing.Size(344, 103);
			this.tbxClientSend.TabIndex = 23;
			this.tbxClientSend.Text = "This message will be send to the Server side socket.";
			// 
			// btnClientSend
			// 
			this.btnClientSend.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnClientSend.Location = new System.Drawing.Point(457, 151);
			this.btnClientSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClientSend.Name = "btnClientSend";
			this.btnClientSend.Size = new System.Drawing.Size(87, 25);
			this.btnClientSend.TabIndex = 22;
			this.btnClientSend.Text = "Send";
			this.btnClientSend.UseVisualStyleBackColor = true;
			this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(202, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "Message to send to Client";
			// 
			// tbxClientMsg
			// 
			this.tbxClientMsg.Location = new System.Drawing.Point(6, 16);
			this.tbxClientMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbxClientMsg.Multiline = true;
			this.tbxClientMsg.Name = "tbxClientMsg";
			this.tbxClientMsg.Size = new System.Drawing.Size(336, 212);
			this.tbxClientMsg.TabIndex = 19;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbxClientMsg);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(205, 183);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 235);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "訊息";
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 434);
			this.Controls.Add(this.tbxClientSend);
			this.Controls.Add(this.btnClientSend);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox6);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ClientForm";
			this.Text = "ClientForm";
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtClientport;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtClientIP;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtLog;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.TextBox tbxClientSend;
		private System.Windows.Forms.Button btnClientSend;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxClientMsg;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

