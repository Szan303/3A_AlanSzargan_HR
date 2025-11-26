namespace _3A_AlanSzargan_HR
{
    partial class FormZarzadzanieUrlopami
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
            components = new System.ComponentModel.Container();
            btnZarzadzanieUrlopamiZatwierdzUrlop = new Button();
            btnZarzadzanieUrlopamiOdrzuc = new Button();
            label1 = new Label();
            label2 = new Label();
            urlopServiceBindingSource = new BindingSource(components);
            livFormZarzadzanieUrlopamiWnioskiOUrlop = new ListView();
            Id = new ColumnHeader();
            Login = new ColumnHeader();
            Poczatek = new ColumnHeader();
            Koniec = new ColumnHeader();
            Powod = new ColumnHeader();
            Status = new ColumnHeader();
            livZarzadzanieUrlopamiZatwierdzone = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnZarzadzanieUrlopamiHistoria = new Button();
            btnZarzadzanieUrlopamiAnulujUrlop = new Button();
            FormZarzadzanieUrlopamiReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)urlopServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnZarzadzanieUrlopamiZatwierdzUrlop
            // 
            btnZarzadzanieUrlopamiZatwierdzUrlop.BackColor = Color.FromArgb(40, 40, 43);
            btnZarzadzanieUrlopamiZatwierdzUrlop.Location = new Point(25, 786);
            btnZarzadzanieUrlopamiZatwierdzUrlop.Name = "btnZarzadzanieUrlopamiZatwierdzUrlop";
            btnZarzadzanieUrlopamiZatwierdzUrlop.Size = new Size(208, 34);
            btnZarzadzanieUrlopamiZatwierdzUrlop.TabIndex = 1;
            btnZarzadzanieUrlopamiZatwierdzUrlop.Text = "Zatwierdź Urlop";
            btnZarzadzanieUrlopamiZatwierdzUrlop.UseVisualStyleBackColor = false;
            btnZarzadzanieUrlopamiZatwierdzUrlop.Click += btnZarzadzanieUrlopamiZatwierdzUrlop_Click;
            // 
            // btnZarzadzanieUrlopamiOdrzuc
            // 
            btnZarzadzanieUrlopamiOdrzuc.BackColor = Color.FromArgb(40, 40, 43);
            btnZarzadzanieUrlopamiOdrzuc.ForeColor = Color.White;
            btnZarzadzanieUrlopamiOdrzuc.Location = new Point(239, 786);
            btnZarzadzanieUrlopamiOdrzuc.Name = "btnZarzadzanieUrlopamiOdrzuc";
            btnZarzadzanieUrlopamiOdrzuc.Size = new Size(208, 34);
            btnZarzadzanieUrlopamiOdrzuc.TabIndex = 3;
            btnZarzadzanieUrlopamiOdrzuc.Text = "Odrzuć Urlop";
            btnZarzadzanieUrlopamiOdrzuc.UseVisualStyleBackColor = false;
            btnZarzadzanieUrlopamiOdrzuc.Click += btnZarzadzanieUrlopamiOdrzuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 4;
            label1.Text = "Wnioski o urlop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(925, 44);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 5;
            label2.Text = "Zatwierdzone urlopy";
            // 
            // urlopServiceBindingSource
            // 
            urlopServiceBindingSource.DataSource = typeof(Skrypty.UrlopService);
            // 
            // livFormZarzadzanieUrlopamiWnioskiOUrlop
            // 
            livFormZarzadzanieUrlopamiWnioskiOUrlop.BackColor = Color.FromArgb(40, 40, 43);
            livFormZarzadzanieUrlopamiWnioskiOUrlop.Columns.AddRange(new ColumnHeader[] { Id, Login, Poczatek, Koniec, Powod, Status });
            livFormZarzadzanieUrlopamiWnioskiOUrlop.ForeColor = Color.White;
            livFormZarzadzanieUrlopamiWnioskiOUrlop.FullRowSelect = true;
            livFormZarzadzanieUrlopamiWnioskiOUrlop.Location = new Point(12, 90);
            livFormZarzadzanieUrlopamiWnioskiOUrlop.Name = "livFormZarzadzanieUrlopamiWnioskiOUrlop";
            livFormZarzadzanieUrlopamiWnioskiOUrlop.Size = new Size(794, 671);
            livFormZarzadzanieUrlopamiWnioskiOUrlop.TabIndex = 6;
            livFormZarzadzanieUrlopamiWnioskiOUrlop.UseCompatibleStateImageBehavior = false;
            livFormZarzadzanieUrlopamiWnioskiOUrlop.View = View.Details;
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
            // livZarzadzanieUrlopamiZatwierdzone
            // 
            livZarzadzanieUrlopamiZatwierdzone.BackColor = Color.FromArgb(40, 40, 43);
            livZarzadzanieUrlopamiZatwierdzone.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            livZarzadzanieUrlopamiZatwierdzone.ForeColor = Color.White;
            livZarzadzanieUrlopamiZatwierdzone.FullRowSelect = true;
            livZarzadzanieUrlopamiZatwierdzone.Location = new Point(925, 90);
            livZarzadzanieUrlopamiZatwierdzone.Name = "livZarzadzanieUrlopamiZatwierdzone";
            livZarzadzanieUrlopamiZatwierdzone.Size = new Size(794, 671);
            livZarzadzanieUrlopamiZatwierdzone.TabIndex = 7;
            livZarzadzanieUrlopamiZatwierdzone.UseCompatibleStateImageBehavior = false;
            livZarzadzanieUrlopamiZatwierdzone.View = View.Details;
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
            // btnZarzadzanieUrlopamiHistoria
            // 
            btnZarzadzanieUrlopamiHistoria.BackColor = Color.FromArgb(40, 40, 43);
            btnZarzadzanieUrlopamiHistoria.Location = new Point(1579, 784);
            btnZarzadzanieUrlopamiHistoria.Name = "btnZarzadzanieUrlopamiHistoria";
            btnZarzadzanieUrlopamiHistoria.Size = new Size(140, 36);
            btnZarzadzanieUrlopamiHistoria.TabIndex = 8;
            btnZarzadzanieUrlopamiHistoria.Text = "Historia";
            btnZarzadzanieUrlopamiHistoria.UseVisualStyleBackColor = false;
            btnZarzadzanieUrlopamiHistoria.Click += btnZarzadzanieUrlopamiHistoria_Click;
            // 
            // btnZarzadzanieUrlopamiAnulujUrlop
            // 
            btnZarzadzanieUrlopamiAnulujUrlop.BackColor = Color.FromArgb(40, 40, 43);
            btnZarzadzanieUrlopamiAnulujUrlop.Location = new Point(925, 784);
            btnZarzadzanieUrlopamiAnulujUrlop.Name = "btnZarzadzanieUrlopamiAnulujUrlop";
            btnZarzadzanieUrlopamiAnulujUrlop.Size = new Size(174, 34);
            btnZarzadzanieUrlopamiAnulujUrlop.TabIndex = 9;
            btnZarzadzanieUrlopamiAnulujUrlop.Text = "Anuluj Urlop";
            btnZarzadzanieUrlopamiAnulujUrlop.UseVisualStyleBackColor = false;
            btnZarzadzanieUrlopamiAnulujUrlop.Click += btnZarzadzanieUrlopamiAnulujUrlop_Click;
            // 
            // FormZarzadzanieUrlopamiReturn
            // 
            FormZarzadzanieUrlopamiReturn.BackColor = Color.FromArgb(40, 40, 43);
            FormZarzadzanieUrlopamiReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FormZarzadzanieUrlopamiReturn.Location = new Point(12, -3);
            FormZarzadzanieUrlopamiReturn.Name = "FormZarzadzanieUrlopamiReturn";
            FormZarzadzanieUrlopamiReturn.Size = new Size(42, 44);
            FormZarzadzanieUrlopamiReturn.TabIndex = 10;
            FormZarzadzanieUrlopamiReturn.Text = "<";
            FormZarzadzanieUrlopamiReturn.UseVisualStyleBackColor = false;
            FormZarzadzanieUrlopamiReturn.Click += FormZarzadzanieUrlopamiReturn_Click;
            // 
            // FormZarzadzanieUrlopami
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1753, 835);
            Controls.Add(FormZarzadzanieUrlopamiReturn);
            Controls.Add(btnZarzadzanieUrlopamiAnulujUrlop);
            Controls.Add(btnZarzadzanieUrlopamiHistoria);
            Controls.Add(livZarzadzanieUrlopamiZatwierdzone);
            Controls.Add(livFormZarzadzanieUrlopamiWnioskiOUrlop);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnZarzadzanieUrlopamiOdrzuc);
            Controls.Add(btnZarzadzanieUrlopamiZatwierdzUrlop);
            ForeColor = Color.White;
            Name = "FormZarzadzanieUrlopami";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormZarzadzanieUrlopami";
            ((System.ComponentModel.ISupportInitialize)urlopServiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnZarzadzanieUrlopamiZatwierdzUrlop;
        private Button btnZarzadzanieUrlopamiOdrzuc;
        private Label label1;
        private Label label2;
        private BindingSource urlopServiceBindingSource;
        private ListView livFormZarzadzanieUrlopamiWnioskiOUrlop;
        private ColumnHeader Id;
        private ColumnHeader Login;
        private ColumnHeader Poczatek;
        private ColumnHeader Koniec;
        private ColumnHeader Powod;
        private ColumnHeader Status;
        private ListView livZarzadzanieUrlopamiZatwierdzone;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnZarzadzanieUrlopamiHistoria;
        private Button btnZarzadzanieUrlopamiAnulujUrlop;
        private Button FormZarzadzanieUrlopamiReturn;
    }
}