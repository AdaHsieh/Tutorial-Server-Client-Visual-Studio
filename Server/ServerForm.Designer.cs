namespace Server
{
	partial class ServerForm
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
			this.btnStartServer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnServerSend = new System.Windows.Forms.Button();
			this.tbServerSend = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSerIP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSerPort = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.tbServerMsg = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox6.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStartServer
			// 
			this.btnStartServer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnStartServer.Location = new System.Drawing.Point(55, 218);
			this.btnStartServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnStartServer.Name = "btnStartServer";
			this.btnStartServer.Size = new System.Drawing.Size(94, 23);
			this.btnStartServer.TabIndex = 8;
			this.btnStartServer.Text = "Start Server";
			this.btnStartServer.UseVisualStyleBackColor = true;
			this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(210, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Message to send to Client";
			// 
			// btnServerSend
			// 
			this.btnServerSend.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnServerSend.Location = new System.Drawing.Point(465, 151);
			this.btnServerSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnServerSend.Name = "btnServerSend";
			this.btnServerSend.Size = new System.Drawing.Size(87, 25);
			this.btnServerSend.TabIndex = 12;
			this.btnServerSend.Text = "Send";
			this.btnServerSend.UseVisualStyleBackColor = true;
			this.btnServerSend.Click += new System.EventHandler(this.btnServerSend_Click);
			// 
			// tbServerSend
			// 
			this.tbServerSend.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbServerSend.Location = new System.Drawing.Point(213, 40);
			this.tbServerSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbServerSend.Multiline = true;
			this.tbServerSend.Name = "tbServerSend";
			this.tbServerSend.Size = new System.Drawing.Size(344, 103);
			this.tbServerSend.TabIndex = 14;
			this.tbServerSend.Text = "This message will be send to the Client side socket.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "狀態";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "伺服器名稱";
			// 
			// txtSerName
			// 
			this.txtSerName.Location = new System.Drawing.Point(9, 88);
			this.txtSerName.Name = "txtSerName";
			this.txtSerName.Size = new System.Drawing.Size(140, 23);
			this.txtSerName.TabIndex = 3;
			this.txtSerName.Text = "ServerPC";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "伺服器IP";
			// 
			// txtSerIP
			// 
			this.txtSerIP.Location = new System.Drawing.Point(9, 139);
			this.txtSerIP.Name = "txtSerIP";
			this.txtSerIP.Size = new System.Drawing.Size(140, 23);
			this.txtSerIP.TabIndex = 5;
			this.txtSerIP.Text = "127.0.0.1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "port";
			// 
			// txtSerPort
			// 
			this.txtSerPort.Location = new System.Drawing.Point(9, 188);
			this.txtSerPort.Name = "txtSerPort";
			this.txtSerPort.Size = new System.Drawing.Size(140, 23);
			this.txtSerPort.TabIndex = 7;
			this.txtSerPort.Text = "5555";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtLog);
			this.groupBox6.Controls.Add(this.txtSerPort);
			this.groupBox6.Controls.Add(this.label4);
			this.groupBox6.Controls.Add(this.txtSerIP);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.txtSerName);
			this.groupBox6.Controls.Add(this.label5);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Controls.Add(this.btnStartServer);
			this.groupBox6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.groupBox6.Location = new System.Drawing.Point(24, 20);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(166, 271);
			this.groupBox6.TabIndex = 17;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "伺服器訊息";
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.Color.White;
			this.txtLog.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtLog.Location = new System.Drawing.Point(9, 40);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(140, 25);
			this.txtLog.TabIndex = 0;
			// 
			// tbServerMsg
			// 
			this.tbServerMsg.Location = new System.Drawing.Point(6, 16);
			this.tbServerMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbServerMsg.Multiline = true;
			this.tbServerMsg.Name = "tbServerMsg";
			this.tbServerMsg.Size = new System.Drawing.Size(336, 212);
			this.tbServerMsg.TabIndex = 19;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbServerMsg);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(213, 183);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 235);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "訊息";
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 438);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.tbServerSend);
			this.Controls.Add(this.btnServerSend);
			this.Controls.Add(this.label1);
			this.Name = "ServerForm";
			this.Text = "ServerForm";
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStartServer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnServerSend;
		private System.Windows.Forms.TextBox tbServerSend;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSerName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSerIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSerPort;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.TextBox tbServerMsg;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

