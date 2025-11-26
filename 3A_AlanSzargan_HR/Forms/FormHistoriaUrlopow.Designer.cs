namespace _3A_AlanSzargan_HR.Forms
{
    partial class FormHistoriaUrlopow
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
            FormHistoriaUrlopowReturn = new Button();
            livFormHistoriaUrlopowZakonczone = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            livFormHistoriaUrlopowOdrzucone = new ListView();
            Id = new ColumnHeader();
            Login = new ColumnHeader();
            Poczatek = new ColumnHeader();
            Koniec = new ColumnHeader();
            Powod = new ColumnHeader();
            Status = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // FormHistoriaUrlopowReturn
            // 
            FormHistoriaUrlopowReturn.BackColor = Color.FromArgb(40, 40, 43);
            FormHistoriaUrlopowReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FormHistoriaUrlopowReturn.Location = new Point(23, 6);
            FormHistoriaUrlopowReturn.Name = "FormHistoriaUrlopowReturn";
            FormHistoriaUrlopowReturn.Size = new Size(42, 44);
            FormHistoriaUrlopowReturn.TabIndex = 19;
            FormHistoriaUrlopowReturn.Text = "<";
            FormHistoriaUrlopowReturn.UseVisualStyleBackColor = false;
            FormHistoriaUrlopowReturn.Click += FormHistoriaUrlopowReturn_Click;
            // 
            // livFormHistoriaUrlopowZakonczone
            // 
            livFormHistoriaUrlopowZakonczone.BackColor = Color.FromArgb(40, 40, 43);
            livFormHistoriaUrlopowZakonczone.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            livFormHistoriaUrlopowZakonczone.ForeColor = Color.White;
            livFormHistoriaUrlopowZakonczone.FullRowSelect = true;
            livFormHistoriaUrlopowZakonczone.Location = new Point(936, 99);
            livFormHistoriaUrlopowZakonczone.Name = "livFormHistoriaUrlopowZakonczone";
            livFormHistoriaUrlopowZakonczone.Size = new Size(794, 671);
            livFormHistoriaUrlopowZakonczone.TabIndex = 16;
            livFormHistoriaUrlopowZakonczone.UseCompatibleStateImageBehavior = false;
            livFormHistoriaUrlopowZakonczone.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PracownikId";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Poczatek";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Koniec";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Powod";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 90;
            // 
            // livFormHistoriaUrlopowOdrzucone
            // 
            livFormHistoriaUrlopowOdrzucone.BackColor = Color.FromArgb(40, 40, 43);
            livFormHistoriaUrlopowOdrzucone.Columns.AddRange(new ColumnHeader[] { Id, Login, Poczatek, Koniec, Powod, Status });
            livFormHistoriaUrlopowOdrzucone.ForeColor = Color.White;
            livFormHistoriaUrlopowOdrzucone.FullRowSelect = true;
            livFormHistoriaUrlopowOdrzucone.Location = new Point(23, 99);
            livFormHistoriaUrlopowOdrzucone.Name = "livFormHistoriaUrlopowOdrzucone";
            livFormHistoriaUrlopowOdrzucone.Size = new Size(794, 671);
            livFormHistoriaUrlopowOdrzucone.TabIndex = 15;
            livFormHistoriaUrlopowOdrzucone.UseCompatibleStateImageBehavior = false;
            livFormHistoriaUrlopowOdrzucone.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 150;
            // 
            // Login
            // 
            Login.Text = "Login";
            Login.Width = 150;
            // 
            // Poczatek
            // 
            Poczatek.Text = "Poczatek";
            Poczatek.Width = 100;
            // 
            // Koniec
            // 
            Koniec.Text = "Koniec";
            Koniec.Width = 100;
            // 
            // Powod
            // 
            Powod.Text = "Powod";
            Powod.Width = 200;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(936, 53);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 14;
            label2.Text = "Zakończone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 53);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 13;
            label1.Text = "Odrzucone";
            // 
            // FormHistoriaUrlopow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1753, 835);
            Controls.Add(FormHistoriaUrlopowReturn);
            Controls.Add(livFormHistoriaUrlopowZakonczone);
            Controls.Add(livFormHistoriaUrlopowOdrzucone);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "FormHistoriaUrlopow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHistoriaUrlopow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FormHistoriaUrlopowReturn;
        private ListView livFormHistoriaUrlopowZakonczone;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView livFormHistoriaUrlopowOdrzucone;
        private ColumnHeader Id;
        private ColumnHeader Login;
        private ColumnHeader Poczatek;
        private ColumnHeader Koniec;
        private ColumnHeader Powod;
        private ColumnHeader Status;
        private Label label2;
        private Label label1;
    }
}