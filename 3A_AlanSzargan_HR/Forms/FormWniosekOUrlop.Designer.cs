namespace _3A_AlanSzargan_HR
{
    partial class FormWniosekOUrlop
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
            label1 = new Label();
            label2 = new Label();
            dtpWniosekOUrlopPoczatek = new DateTimePicker();
            dtpWniosekOUrlopKoniec = new DateTimePicker();
            btnWniosekOUrlopZatwierdz = new Button();
            txbWniosekOUrlopPowod = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Data Rozpoczęcia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(10, 108);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 1;
            label2.Text = "Data Zakończenia";
            // 
            // dtpWniosekOUrlopPoczatek
            // 
            dtpWniosekOUrlopPoczatek.Format = DateTimePickerFormat.Short;
            dtpWniosekOUrlopPoczatek.Location = new Point(12, 60);
            dtpWniosekOUrlopPoczatek.Name = "dtpWniosekOUrlopPoczatek";
            dtpWniosekOUrlopPoczatek.Size = new Size(125, 31);
            dtpWniosekOUrlopPoczatek.TabIndex = 2;
            // 
            // dtpWniosekOUrlopKoniec
            // 
            dtpWniosekOUrlopKoniec.Format = DateTimePickerFormat.Short;
            dtpWniosekOUrlopKoniec.Location = new Point(12, 143);
            dtpWniosekOUrlopKoniec.Name = "dtpWniosekOUrlopKoniec";
            dtpWniosekOUrlopKoniec.Size = new Size(125, 31);
            dtpWniosekOUrlopKoniec.TabIndex = 3;
            // 
            // btnWniosekOUrlopZatwierdz
            // 
            btnWniosekOUrlopZatwierdz.BackColor = Color.FromArgb(40, 40, 43);
            btnWniosekOUrlopZatwierdz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnWniosekOUrlopZatwierdz.Location = new Point(21, 348);
            btnWniosekOUrlopZatwierdz.Name = "btnWniosekOUrlopZatwierdz";
            btnWniosekOUrlopZatwierdz.Size = new Size(174, 55);
            btnWniosekOUrlopZatwierdz.TabIndex = 4;
            btnWniosekOUrlopZatwierdz.Text = "Zatwierdź";
            btnWniosekOUrlopZatwierdz.UseVisualStyleBackColor = false;
            btnWniosekOUrlopZatwierdz.Click += btnWniosekOUrlopZatwierdz_Click;
            // 
            // txbWniosekOUrlopPowod
            // 
            txbWniosekOUrlopPowod.BackColor = Color.FromArgb(40, 40, 43);
            txbWniosekOUrlopPowod.ForeColor = Color.White;
            txbWniosekOUrlopPowod.Location = new Point(10, 228);
            txbWniosekOUrlopPowod.Multiline = true;
            txbWniosekOUrlopPowod.Name = "txbWniosekOUrlopPowod";
            txbWniosekOUrlopPowod.Size = new Size(339, 98);
            txbWniosekOUrlopPowod.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(10, 193);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 6;
            label3.Text = "Powód";
            // 
            // FormWniosekOUrlop
            // 
            AcceptButton = btnWniosekOUrlopZatwierdz;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(352, 412);
            Controls.Add(label3);
            Controls.Add(txbWniosekOUrlopPowod);
            Controls.Add(btnWniosekOUrlopZatwierdz);
            Controls.Add(dtpWniosekOUrlopKoniec);
            Controls.Add(dtpWniosekOUrlopPoczatek);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            Name = "FormWniosekOUrlop";
            Text = "Formularz wniosek o urlop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpWniosekOUrlopPoczatek;
        private DateTimePicker dtpWniosekOUrlopKoniec;
        private Button btnWniosekOUrlopZatwierdz;
        private TextBox txbWniosekOUrlopPowod;
        private Label label3;
    }
}