namespace _3A_AlanSzargan_HR.Forms
{
    partial class FormDialogEdycjaOsob
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
            txbDialogEdycjaOsobLogin = new TextBox();
            label1 = new Label();
            btnDialogEdycjaOsobOK = new Button();
            SuspendLayout();
            // 
            // txbDialogEdycjaOsobLogin
            // 
            txbDialogEdycjaOsobLogin.BackColor = Color.FromArgb(40, 40, 43);
            txbDialogEdycjaOsobLogin.ForeColor = Color.White;
            txbDialogEdycjaOsobLogin.Location = new Point(12, 63);
            txbDialogEdycjaOsobLogin.Name = "txbDialogEdycjaOsobLogin";
            txbDialogEdycjaOsobLogin.Size = new Size(172, 31);
            txbDialogEdycjaOsobLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(332, 32);
            label1.TabIndex = 1;
            label1.Text = "Podaj login wybranej osoby";
            // 
            // btnDialogEdycjaOsobOK
            // 
            btnDialogEdycjaOsobOK.BackColor = Color.FromArgb(40, 40, 43);
            btnDialogEdycjaOsobOK.ForeColor = Color.White;
            btnDialogEdycjaOsobOK.Location = new Point(12, 100);
            btnDialogEdycjaOsobOK.Name = "btnDialogEdycjaOsobOK";
            btnDialogEdycjaOsobOK.Size = new Size(112, 34);
            btnDialogEdycjaOsobOK.TabIndex = 2;
            btnDialogEdycjaOsobOK.Text = "OK";
            btnDialogEdycjaOsobOK.UseVisualStyleBackColor = false;
            btnDialogEdycjaOsobOK.Click += btnDialogEdycjaOsobOK_Click;
            // 
            // FormDialogEdycjaOsob
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(344, 140);
            Controls.Add(btnDialogEdycjaOsobOK);
            Controls.Add(label1);
            Controls.Add(txbDialogEdycjaOsobLogin);
            ForeColor = Color.White;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogEdycjaOsob";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDialogEdycjaOsob";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDialogEdycjaOsobLogin;
        private Label label1;
        private Button btnDialogEdycjaOsobOK;
    }
}