namespace _3A_AlanSzargan_HR.Forms
{
    partial class FormSkrzynkaHR
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
            libSkrzynkaHRWiadomosci = new ListBox();
            txbSkrzynkaHRTytul = new TextBox();
            rtbSkrzynkaHRTresc = new RichTextBox();
            btnSkrzynkaHRReturn = new Button();
            btnSkrzynkaHRUsun = new Button();
            SuspendLayout();
            // 
            // libSkrzynkaHRWiadomosci
            // 
            libSkrzynkaHRWiadomosci.BackColor = Color.FromArgb(40, 40, 43);
            libSkrzynkaHRWiadomosci.ForeColor = Color.White;
            libSkrzynkaHRWiadomosci.FormattingEnabled = true;
            libSkrzynkaHRWiadomosci.Location = new Point(92, 89);
            libSkrzynkaHRWiadomosci.Name = "libSkrzynkaHRWiadomosci";
            libSkrzynkaHRWiadomosci.Size = new Size(1327, 604);
            libSkrzynkaHRWiadomosci.TabIndex = 0;
            libSkrzynkaHRWiadomosci.DoubleClick += libSkrzynkaHRWiadomosci_DoubleClick;
            // 
            // txbSkrzynkaHRTytul
            // 
            txbSkrzynkaHRTytul.BackColor = Color.FromArgb(40, 40, 43);
            txbSkrzynkaHRTytul.ForeColor = Color.White;
            txbSkrzynkaHRTytul.Location = new Point(92, 52);
            txbSkrzynkaHRTytul.Name = "txbSkrzynkaHRTytul";
            txbSkrzynkaHRTytul.ReadOnly = true;
            txbSkrzynkaHRTytul.Size = new Size(1327, 31);
            txbSkrzynkaHRTytul.TabIndex = 1;
            // 
            // rtbSkrzynkaHRTresc
            // 
            rtbSkrzynkaHRTresc.BackColor = Color.FromArgb(40, 40, 43);
            rtbSkrzynkaHRTresc.ForeColor = Color.White;
            rtbSkrzynkaHRTresc.Location = new Point(92, 89);
            rtbSkrzynkaHRTresc.Name = "rtbSkrzynkaHRTresc";
            rtbSkrzynkaHRTresc.ReadOnly = true;
            rtbSkrzynkaHRTresc.Size = new Size(1327, 604);
            rtbSkrzynkaHRTresc.TabIndex = 2;
            rtbSkrzynkaHRTresc.Text = "";
            // 
            // btnSkrzynkaHRReturn
            // 
            btnSkrzynkaHRReturn.BackColor = Color.FromArgb(40, 40, 43);
            btnSkrzynkaHRReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSkrzynkaHRReturn.Location = new Point(12, 12);
            btnSkrzynkaHRReturn.Name = "btnSkrzynkaHRReturn";
            btnSkrzynkaHRReturn.Size = new Size(44, 45);
            btnSkrzynkaHRReturn.TabIndex = 3;
            btnSkrzynkaHRReturn.Text = "<";
            btnSkrzynkaHRReturn.UseVisualStyleBackColor = false;
            btnSkrzynkaHRReturn.Click += btnSkrzynkaReturn_Click;
            // 
            // btnSkrzynkaHRUsun
            // 
            btnSkrzynkaHRUsun.BackColor = Color.FromArgb(40, 40, 43);
            btnSkrzynkaHRUsun.Location = new Point(1262, 708);
            btnSkrzynkaHRUsun.Name = "btnSkrzynkaHRUsun";
            btnSkrzynkaHRUsun.Size = new Size(157, 34);
            btnSkrzynkaHRUsun.TabIndex = 4;
            btnSkrzynkaHRUsun.Text = "Usuń";
            btnSkrzynkaHRUsun.UseVisualStyleBackColor = false;
            btnSkrzynkaHRUsun.Click += btnSkrzynkaHRUsun_Click;
            // 
            // FormSkrzynkaHR
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1478, 764);
            Controls.Add(btnSkrzynkaHRUsun);
            Controls.Add(btnSkrzynkaHRReturn);
            Controls.Add(rtbSkrzynkaHRTresc);
            Controls.Add(txbSkrzynkaHRTytul);
            Controls.Add(libSkrzynkaHRWiadomosci);
            ForeColor = Color.White;
            Name = "FormSkrzynkaHR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skrzynka HR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox libSkrzynkaHRWiadomosci;
        private TextBox txbSkrzynkaHRTytul;
        private RichTextBox rtbSkrzynkaHRTresc;
        private Button btnSkrzynkaHRReturn;
        private Button btnSkrzynkaHRUsun;
    }
}