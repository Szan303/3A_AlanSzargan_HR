namespace _3A_AlanSzargan_HR.Forms
{
    partial class FormWiadomoscDoHR
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
            rtbWiadomoscDoHRTresc = new RichTextBox();
            txbWiadomoscDoHRTytul = new TextBox();
            btnWiadomoscDoHRWyslij = new Button();
            SuspendLayout();
            // 
            // rtbWiadomoscDoHRTresc
            // 
            rtbWiadomoscDoHRTresc.BackColor = Color.FromArgb(40, 40, 40);
            rtbWiadomoscDoHRTresc.ForeColor = Color.White;
            rtbWiadomoscDoHRTresc.Location = new Point(29, 128);
            rtbWiadomoscDoHRTresc.Name = "rtbWiadomoscDoHRTresc";
            rtbWiadomoscDoHRTresc.Size = new Size(1408, 621);
            rtbWiadomoscDoHRTresc.TabIndex = 0;
            rtbWiadomoscDoHRTresc.Text = "";
            // 
            // txbWiadomoscDoHRTytul
            // 
            txbWiadomoscDoHRTytul.BackColor = Color.FromArgb(40, 40, 43);
            txbWiadomoscDoHRTytul.ForeColor = Color.White;
            txbWiadomoscDoHRTytul.Location = new Point(29, 82);
            txbWiadomoscDoHRTytul.Name = "txbWiadomoscDoHRTytul";
            txbWiadomoscDoHRTytul.Size = new Size(1408, 31);
            txbWiadomoscDoHRTytul.TabIndex = 1;
            // 
            // btnWiadomoscDoHRWyslij
            // 
            btnWiadomoscDoHRWyslij.BackColor = Color.FromArgb(40, 40, 43);
            btnWiadomoscDoHRWyslij.Location = new Point(1131, 28);
            btnWiadomoscDoHRWyslij.Name = "btnWiadomoscDoHRWyslij";
            btnWiadomoscDoHRWyslij.Size = new Size(306, 34);
            btnWiadomoscDoHRWyslij.TabIndex = 2;
            btnWiadomoscDoHRWyslij.Text = "Wyślij wiadomość";
            btnWiadomoscDoHRWyslij.UseVisualStyleBackColor = false;
            btnWiadomoscDoHRWyslij.Click += btnWiadomoscDoHRWyslij_Click;
            // 
            // FormWiadomoscDoHR
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1469, 761);
            Controls.Add(btnWiadomoscDoHRWyslij);
            Controls.Add(txbWiadomoscDoHRTytul);
            Controls.Add(rtbWiadomoscDoHRTresc);
            ForeColor = Color.White;
            Name = "FormWiadomoscDoHR";
            Text = "FormWiadomoscDoHR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbWiadomoscDoHRTresc;
        private TextBox txbWiadomoscDoHRTytul;
        private Button btnWiadomoscDoHRWyslij;
    }
}