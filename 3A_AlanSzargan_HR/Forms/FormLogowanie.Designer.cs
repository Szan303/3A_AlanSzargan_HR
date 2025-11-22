namespace _3A_AlanSzargan_HR
{
    partial class FormLogowanie
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
            lblLogowanieLogin = new Label();
            txbLogowanieLogin = new TextBox();
            lblLogowanieHaslo = new Label();
            txbLogowanieHaslo = new TextBox();
            btnLogowanieZaloguj = new Button();
            SuspendLayout();
            // 
            // lblLogowanieLogin
            // 
            lblLogowanieLogin.AutoSize = true;
            lblLogowanieLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLogowanieLogin.ForeColor = Color.White;
            lblLogowanieLogin.Location = new Point(12, 9);
            lblLogowanieLogin.Name = "lblLogowanieLogin";
            lblLogowanieLogin.Size = new Size(104, 45);
            lblLogowanieLogin.TabIndex = 0;
            lblLogowanieLogin.Text = "Login";
            // 
            // txbLogowanieLogin
            // 
            txbLogowanieLogin.BackColor = SystemColors.InfoText;
            txbLogowanieLogin.BorderStyle = BorderStyle.FixedSingle;
            txbLogowanieLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txbLogowanieLogin.ForeColor = Color.White;
            txbLogowanieLogin.Location = new Point(12, 57);
            txbLogowanieLogin.Name = "txbLogowanieLogin";
            txbLogowanieLogin.Size = new Size(275, 34);
            txbLogowanieLogin.TabIndex = 1;
            // 
            // lblLogowanieHaslo
            // 
            lblLogowanieHaslo.AutoSize = true;
            lblLogowanieHaslo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLogowanieHaslo.ForeColor = Color.White;
            lblLogowanieHaslo.Location = new Point(12, 94);
            lblLogowanieHaslo.Name = "lblLogowanieHaslo";
            lblLogowanieHaslo.Size = new Size(106, 45);
            lblLogowanieHaslo.TabIndex = 2;
            lblLogowanieHaslo.Text = "Hasło";
            // 
            // txbLogowanieHaslo
            // 
            txbLogowanieHaslo.BackColor = SystemColors.InfoText;
            txbLogowanieHaslo.BorderStyle = BorderStyle.FixedSingle;
            txbLogowanieHaslo.ForeColor = Color.White;
            txbLogowanieHaslo.Location = new Point(12, 142);
            txbLogowanieHaslo.Name = "txbLogowanieHaslo";
            txbLogowanieHaslo.PasswordChar = '*';
            txbLogowanieHaslo.Size = new Size(275, 31);
            txbLogowanieHaslo.TabIndex = 3;
            // 
            // btnLogowanieZaloguj
            // 
            btnLogowanieZaloguj.BackColor = SystemColors.InfoText;
            btnLogowanieZaloguj.Cursor = Cursors.Hand;
            btnLogowanieZaloguj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogowanieZaloguj.ForeColor = Color.White;
            btnLogowanieZaloguj.Location = new Point(12, 245);
            btnLogowanieZaloguj.Name = "btnLogowanieZaloguj";
            btnLogowanieZaloguj.Size = new Size(162, 49);
            btnLogowanieZaloguj.TabIndex = 4;
            btnLogowanieZaloguj.Text = "Zaloguj";
            btnLogowanieZaloguj.UseVisualStyleBackColor = false;
            btnLogowanieZaloguj.Click += btnLogowanieZaloguj_Click;
            // 
            // FormLogowanie
            // 
            AcceptButton = btnLogowanieZaloguj;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(428, 380);
            Controls.Add(btnLogowanieZaloguj);
            Controls.Add(txbLogowanieHaslo);
            Controls.Add(lblLogowanieHaslo);
            Controls.Add(txbLogowanieLogin);
            Controls.Add(lblLogowanieLogin);
            Name = "FormLogowanie";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogowanieLogin;
        private TextBox txbLogowanieLogin;
        private Label lblLogowanieHaslo;
        private TextBox txbLogowanieHaslo;
        private Button btnLogowanieZaloguj;
    }
}
