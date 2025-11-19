namespace _3A_AlanSzargan_HR
{
    partial class FormUsuwanieOsob
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
            lblUsuwanieOsobLogin = new Label();
            txbUsuwanieOsobLogin = new TextBox();
            btnUsuwanieOsobUsun = new Button();
            SuspendLayout();
            // 
            // lblUsuwanieOsobLogin
            // 
            lblUsuwanieOsobLogin.AutoSize = true;
            lblUsuwanieOsobLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUsuwanieOsobLogin.Location = new Point(12, 9);
            lblUsuwanieOsobLogin.Name = "lblUsuwanieOsobLogin";
            lblUsuwanieOsobLogin.Size = new Size(504, 45);
            lblUsuwanieOsobLogin.TabIndex = 0;
            lblUsuwanieOsobLogin.Text = "Podaj Login osoby do usunięcia!";
            // 
            // txbUsuwanieOsobLogin
            // 
            txbUsuwanieOsobLogin.BackColor = Color.FromArgb(40, 40, 43);
            txbUsuwanieOsobLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txbUsuwanieOsobLogin.ForeColor = Color.White;
            txbUsuwanieOsobLogin.Location = new Point(12, 57);
            txbUsuwanieOsobLogin.Name = "txbUsuwanieOsobLogin";
            txbUsuwanieOsobLogin.Size = new Size(325, 39);
            txbUsuwanieOsobLogin.TabIndex = 1;
            // 
            // btnUsuwanieOsobUsun
            // 
            btnUsuwanieOsobUsun.BackColor = Color.FromArgb(40, 40, 43);
            btnUsuwanieOsobUsun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUsuwanieOsobUsun.ForeColor = Color.White;
            btnUsuwanieOsobUsun.Location = new Point(12, 112);
            btnUsuwanieOsobUsun.Name = "btnUsuwanieOsobUsun";
            btnUsuwanieOsobUsun.Size = new Size(128, 57);
            btnUsuwanieOsobUsun.TabIndex = 2;
            btnUsuwanieOsobUsun.Text = "Usuń";
            btnUsuwanieOsobUsun.UseVisualStyleBackColor = false;
            btnUsuwanieOsobUsun.Click += btnUsuwanieOsobUsun_Click;
            // 
            // FormUsuwanieOsob
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(528, 202);
            Controls.Add(btnUsuwanieOsobUsun);
            Controls.Add(txbUsuwanieOsobLogin);
            Controls.Add(lblUsuwanieOsobLogin);
            ForeColor = Color.White;
            Name = "FormUsuwanieOsob";
            Text = "FormUsuwanieOsob";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuwanieOsobLogin;
        private TextBox txbUsuwanieOsobLogin;
        private Button btnUsuwanieOsobUsun;
    }
}