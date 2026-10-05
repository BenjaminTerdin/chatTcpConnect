namespace TCP_client
{
    partial class ClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            sendMsg = new TextBox();
            inkorg = new Label();
            label1 = new Label();
            sendIp = new TextBox();
            connStart = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 10F);
            btnSend.Location = new Point(215, 215);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(101, 38);
            btnSend.TabIndex = 0;
            btnSend.Text = "Skicka";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // sendMsg
            // 
            sendMsg.Location = new Point(12, 106);
            sendMsg.Multiline = true;
            sendMsg.Name = "sendMsg";
            sendMsg.Size = new Size(304, 103);
            sendMsg.TabIndex = 1;
            // 
            // inkorg
            // 
            inkorg.AutoSize = true;
            inkorg.Font = new Font("Segoe UI", 10F);
            inkorg.Location = new Point(12, 84);
            inkorg.Name = "inkorg";
            inkorg.Size = new Size(85, 19);
            inkorg.TabIndex = 2;
            inkorg.Text = "Meddelande";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 4;
            label1.Text = "IP-Adress";
            // 
            // sendIp
            // 
            sendIp.Location = new Point(12, 34);
            sendIp.Multiline = true;
            sendIp.Name = "sendIp";
            sendIp.Size = new Size(304, 36);
            sendIp.TabIndex = 3;
            sendIp.Text = "127.0.0.1";
            // 
            // connStart
            // 
            connStart.Font = new Font("Segoe UI", 10F);
            connStart.Location = new Point(12, 215);
            connStart.Name = "connStart";
            connStart.Size = new Size(101, 38);
            connStart.TabIndex = 5;
            connStart.Text = "Anslut";
            connStart.UseVisualStyleBackColor = true;
            connStart.Click += connStart_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 271);
            Controls.Add(connStart);
            Controls.Add(label1);
            Controls.Add(sendIp);
            Controls.Add(inkorg);
            Controls.Add(sendMsg);
            Controls.Add(btnSend);
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox sendMsg;
        private Label inkorg;
        private Label label1;
        private TextBox sendIp;
        private Button connStart;
    }
}
