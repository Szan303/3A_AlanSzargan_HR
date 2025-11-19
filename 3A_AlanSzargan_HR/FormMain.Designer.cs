namespace _3A_AlanSzargan_HR
{
    partial class FormMain
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
            lblMainPrzywitanie = new Label();
            libMainListaOsob = new ListBox();
            btnMainDodajOsobe = new Button();
            label1 = new Label();
            btnMainUsunOsobe = new Button();
            libMainGlobalChat = new ListBox();
            txbMainGlobalChatMessage = new TextBox();
            btnMainGlobalSendMessage = new Button();
            SuspendLayout();
            // 
            // lblMainPrzywitanie
            // 
            lblMainPrzywitanie.AutoSize = true;
            lblMainPrzywitanie.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMainPrzywitanie.Location = new Point(12, 9);
            lblMainPrzywitanie.Name = "lblMainPrzywitanie";
            lblMainPrzywitanie.Size = new Size(0, 38);
            lblMainPrzywitanie.TabIndex = 0;
            // 
            // libMainListaOsob
            // 
            libMainListaOsob.BackColor = Color.FromArgb(40, 40, 43);
            libMainListaOsob.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            libMainListaOsob.ForeColor = Color.White;
            libMainListaOsob.FormattingEnabled = true;
            libMainListaOsob.Location = new Point(774, 63);
            libMainListaOsob.Name = "libMainListaOsob";
            libMainListaOsob.Size = new Size(635, 279);
            libMainListaOsob.TabIndex = 1;
            // 
            // btnMainDodajOsobe
            // 
            btnMainDodajOsobe.BackColor = Color.FromArgb(40, 40, 43);
            btnMainDodajOsobe.ForeColor = SystemColors.Window;
            btnMainDodajOsobe.Location = new Point(1101, 469);
            btnMainDodajOsobe.Name = "btnMainDodajOsobe";
            btnMainDodajOsobe.Size = new Size(150, 59);
            btnMainDodajOsobe.TabIndex = 2;
            btnMainDodajOsobe.Text = "Dodaj Osobę";
            btnMainDodajOsobe.UseVisualStyleBackColor = false;
            btnMainDodajOsobe.Click += btnMainDodajOsobe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1101, 413);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 3;
            label1.Text = "Kontrolki Admina";
            // 
            // btnMainUsunOsobe
            // 
            btnMainUsunOsobe.BackColor = Color.FromArgb(40, 40, 43);
            btnMainUsunOsobe.ForeColor = Color.White;
            btnMainUsunOsobe.Location = new Point(1101, 534);
            btnMainUsunOsobe.Name = "btnMainUsunOsobe";
            btnMainUsunOsobe.Size = new Size(150, 60);
            btnMainUsunOsobe.TabIndex = 4;
            btnMainUsunOsobe.Text = "Usuń Osobę";
            btnMainUsunOsobe.UseVisualStyleBackColor = false;
            btnMainUsunOsobe.Click += btnMainUsunOsobe_Click;
            // 
            // libMainGlobalChat
            // 
            libMainGlobalChat.BackColor = Color.FromArgb(40, 40, 43);
            libMainGlobalChat.ForeColor = Color.White;
            libMainGlobalChat.FormattingEnabled = true;
            libMainGlobalChat.Location = new Point(12, 63);
            libMainGlobalChat.Name = "libMainGlobalChat";
            libMainGlobalChat.Size = new Size(725, 504);
            libMainGlobalChat.TabIndex = 5;
            // 
            // txbMainGlobalChatMessage
            // 
            txbMainGlobalChatMessage.BackColor = Color.FromArgb(40, 40, 43);
            txbMainGlobalChatMessage.ForeColor = Color.White;
            txbMainGlobalChatMessage.Location = new Point(12, 573);
            txbMainGlobalChatMessage.Name = "txbMainGlobalChatMessage";
            txbMainGlobalChatMessage.Size = new Size(599, 31);
            txbMainGlobalChatMessage.TabIndex = 6;
            // 
            // btnMainGlobalSendMessage
            // 
            btnMainGlobalSendMessage.BackColor = Color.FromArgb(40, 40, 43);
            btnMainGlobalSendMessage.Location = new Point(625, 570);
            btnMainGlobalSendMessage.Name = "btnMainGlobalSendMessage";
            btnMainGlobalSendMessage.Size = new Size(112, 34);
            btnMainGlobalSendMessage.TabIndex = 7;
            btnMainGlobalSendMessage.Text = "Wyślij";
            btnMainGlobalSendMessage.UseVisualStyleBackColor = false;
            btnMainGlobalSendMessage.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1421, 777);
            Controls.Add(btnMainGlobalSendMessage);
            Controls.Add(txbMainGlobalChatMessage);
            Controls.Add(libMainGlobalChat);
            Controls.Add(btnMainUsunOsobe);
            Controls.Add(label1);
            Controls.Add(btnMainDodajOsobe);
            Controls.Add(libMainListaOsob);
            Controls.Add(lblMainPrzywitanie);
            ForeColor = Color.White;
            Name = "FormMain";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainPrzywitanie;
        private ListBox libMainListaOsob;
        private Button btnMainDodajOsobe;
        private Label label1;
        private Button btnMainUsunOsobe;
        private ListBox libMainGlobalChat;
        private TextBox txbMainGlobalChatMessage;
        private Button btnMainGlobalSendMessage;
    }
}