namespace TCP_client
{
    partial class ServerForm
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
            btnStarta = new Button();
            tbxInkorg = new TextBox();
            inkorg = new Label();
            SuspendLayout();
            // 
            // btnStarta
            // 
            btnStarta.Font = new Font("Segoe UI", 10F);
            btnStarta.Location = new Point(215, 12);
            btnStarta.Name = "btnStarta";
            btnStarta.Size = new Size(101, 38);
            btnStarta.TabIndex = 0;
            btnStarta.Text = "Starta server";
            btnStarta.UseVisualStyleBackColor = true;
            btnStarta.Click += btnStarta_Click;
            // 
            // tbxInkorg
            // 
            tbxInkorg.Location = new Point(12, 68);
            tbxInkorg.Multiline = true;
            tbxInkorg.Name = "tbxInkorg";
            tbxInkorg.Size = new Size(304, 103);
            tbxInkorg.TabIndex = 1;
            // 
            // inkorg
            // 
            inkorg.AutoSize = true;
            inkorg.Font = new Font("Segoe UI", 10F);
            inkorg.Location = new Point(12, 45);
            inkorg.Name = "inkorg";
            inkorg.Size = new Size(49, 19);
            inkorg.TabIndex = 2;
            inkorg.Text = "Inkorg";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 181);
            Controls.Add(inkorg);
            Controls.Add(tbxInkorg);
            Controls.Add(btnStarta);
            Name = "ServerForm";
            Text = "ServerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStarta;
        private TextBox tbxInkorg;
        private Label inkorg;
    }
}
