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
            btnMainUrlopy = new Button();
            btnMainWniosekOUrlop = new Button();
            btnMainGrafik = new Button();
            btnMainKontakt = new Button();
            pictureBox1 = new PictureBox();
            btnMainEdytujOsobe = new Button();
            label2 = new Label();
            btnMainZarzadzanieUrlopami = new Button();
            btnMainEdycjaGrafiku = new Button();
            btnMainWiadomosciDoHR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnMainDodajOsobe.Location = new Point(1259, 468);
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
            label1.Location = new Point(1103, 430);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 3;
            label1.Text = "Kontrolki HR";
            // 
            // btnMainUsunOsobe
            // 
            btnMainUsunOsobe.BackColor = Color.FromArgb(40, 40, 43);
            btnMainUsunOsobe.ForeColor = Color.White;
            btnMainUsunOsobe.Location = new Point(1259, 533);
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
            btnMainGlobalSendMessage.Click += btnMainGlobalSendMessage_Click;
            // 
            // btnMainUrlopy
            // 
            btnMainUrlopy.BackColor = Color.FromArgb(40, 40, 43);
            btnMainUrlopy.Location = new Point(12, 681);
            btnMainUrlopy.Name = "btnMainUrlopy";
            btnMainUrlopy.Size = new Size(112, 34);
            btnMainUrlopy.TabIndex = 8;
            btnMainUrlopy.Text = "Urlopy";
            btnMainUrlopy.UseVisualStyleBackColor = false;
            // 
            // btnMainWniosekOUrlop
            // 
            btnMainWniosekOUrlop.BackColor = Color.FromArgb(40, 40, 43);
            btnMainWniosekOUrlop.Location = new Point(130, 681);
            btnMainWniosekOUrlop.Name = "btnMainWniosekOUrlop";
            btnMainWniosekOUrlop.Size = new Size(207, 34);
            btnMainWniosekOUrlop.TabIndex = 9;
            btnMainWniosekOUrlop.Text = "Wniosek o urlop";
            btnMainWniosekOUrlop.UseVisualStyleBackColor = false;
            btnMainWniosekOUrlop.Click += btnMainWniosekOUrlop_Click;
            // 
            // btnMainGrafik
            // 
            btnMainGrafik.BackColor = Color.FromArgb(40, 40, 43);
            btnMainGrafik.Location = new Point(343, 681);
            btnMainGrafik.Name = "btnMainGrafik";
            btnMainGrafik.Size = new Size(112, 34);
            btnMainGrafik.TabIndex = 10;
            btnMainGrafik.Text = "Grafik";
            btnMainGrafik.UseVisualStyleBackColor = false;
            btnMainGrafik.Click += btnMainGrafik_Click;
            // 
            // btnMainKontakt
            // 
            btnMainKontakt.BackColor = Color.FromArgb(40, 40, 43);
            btnMainKontakt.Location = new Point(461, 681);
            btnMainKontakt.Name = "btnMainKontakt";
            btnMainKontakt.Size = new Size(195, 33);
            btnMainKontakt.TabIndex = 11;
            btnMainKontakt.Text = "Kontakt HR";
            btnMainKontakt.UseVisualStyleBackColor = false;
            btnMainKontakt.Click += btnMainKontakt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(774, 363);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 241);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnMainEdytujOsobe
            // 
            btnMainEdytujOsobe.BackColor = Color.FromArgb(40, 40, 43);
            btnMainEdytujOsobe.ForeColor = Color.White;
            btnMainEdytujOsobe.Location = new Point(1259, 599);
            btnMainEdytujOsobe.Name = "btnMainEdytujOsobe";
            btnMainEdytujOsobe.Size = new Size(150, 60);
            btnMainEdytujOsobe.TabIndex = 13;
            btnMainEdytujOsobe.Text = "Edytuj Osobę";
            btnMainEdytujOsobe.UseVisualStyleBackColor = false;
            btnMainEdytujOsobe.Click += btnMainEdytujOsobe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(774, 637);
            label2.Name = "label2";
            label2.Size = new Size(191, 50);
            label2.TabIndex = 14;
            label2.Text = "Dodaj Funkcjonalność \r\nnowym przyciskom\r\n";
            // 
            // btnMainZarzadzanieUrlopami
            // 
            btnMainZarzadzanieUrlopami.BackColor = Color.FromArgb(40, 40, 43);
            btnMainZarzadzanieUrlopami.ForeColor = Color.White;
            btnMainZarzadzanieUrlopami.Location = new Point(1103, 599);
            btnMainZarzadzanieUrlopami.Name = "btnMainZarzadzanieUrlopami";
            btnMainZarzadzanieUrlopami.Size = new Size(150, 60);
            btnMainZarzadzanieUrlopami.TabIndex = 16;
            btnMainZarzadzanieUrlopami.Text = "Zarz. Urlopami";
            btnMainZarzadzanieUrlopami.UseVisualStyleBackColor = false;
            btnMainZarzadzanieUrlopami.Click += btnMainZarzadzanieUrlopami_Click;
            // 
            // btnMainEdycjaGrafiku
            // 
            btnMainEdycjaGrafiku.BackColor = Color.FromArgb(40, 40, 43);
            btnMainEdycjaGrafiku.ForeColor = Color.White;
            btnMainEdycjaGrafiku.Location = new Point(1103, 533);
            btnMainEdycjaGrafiku.Name = "btnMainEdycjaGrafiku";
            btnMainEdycjaGrafiku.Size = new Size(150, 60);
            btnMainEdycjaGrafiku.TabIndex = 17;
            btnMainEdycjaGrafiku.Text = "Edycja Grafiku";
            btnMainEdycjaGrafiku.UseVisualStyleBackColor = false;
            // 
            // btnMainWiadomosciDoHR
            // 
            btnMainWiadomosciDoHR.BackColor = Color.FromArgb(40, 40, 43);
            btnMainWiadomosciDoHR.ForeColor = Color.White;
            btnMainWiadomosciDoHR.Location = new Point(1103, 467);
            btnMainWiadomosciDoHR.Name = "btnMainWiadomosciDoHR";
            btnMainWiadomosciDoHR.Size = new Size(150, 60);
            btnMainWiadomosciDoHR.TabIndex = 18;
            btnMainWiadomosciDoHR.Text = "Wiad. do HR";
            btnMainWiadomosciDoHR.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1421, 732);
            Controls.Add(btnMainWiadomosciDoHR);
            Controls.Add(btnMainEdycjaGrafiku);
            Controls.Add(btnMainZarzadzanieUrlopami);
            Controls.Add(label2);
            Controls.Add(btnMainEdytujOsobe);
            Controls.Add(pictureBox1);
            Controls.Add(btnMainKontakt);
            Controls.Add(btnMainGrafik);
            Controls.Add(btnMainWniosekOUrlop);
            Controls.Add(btnMainUrlopy);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnMainUrlopy;
        private Button btnMainWniosekOUrlop;
        private Button btnMainGrafik;
        private Button btnMainKontakt;
        private PictureBox pictureBox1;
        private Button btnMainEdytujOsobe;
        private Label label2;
        private Button btnMainZarzadzanieUrlopami;
        private Button btnMainEdycjaGrafiku;
        private Button btnMainWiadomosciDoHR;
    }
}