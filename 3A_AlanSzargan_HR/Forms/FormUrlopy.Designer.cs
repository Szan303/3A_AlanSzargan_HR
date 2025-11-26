namespace _3A_AlanSzargan_HR.Forms
{
    partial class FormUrlopy
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
            livUrlopyLista = new ListView();
            Id = new ColumnHeader();
            Login = new ColumnHeader();
            Poczatek = new ColumnHeader();
            Koniec = new ColumnHeader();
            Powod = new ColumnHeader();
            Status = new ColumnHeader();
            SuspendLayout();
            // 
            // livUrlopyLista
            // 
            livUrlopyLista.BackColor = Color.FromArgb(40, 40, 43);
            livUrlopyLista.Columns.AddRange(new ColumnHeader[] { Id, Login, Poczatek, Koniec, Powod, Status });
            livUrlopyLista.ForeColor = Color.White;
            livUrlopyLista.FullRowSelect = true;
            livUrlopyLista.Location = new Point(12, 56);
            livUrlopyLista.Name = "livUrlopyLista";
            livUrlopyLista.Size = new Size(796, 574);
            livUrlopyLista.TabIndex = 16;
            livUrlopyLista.UseCompatibleStateImageBehavior = false;
            livUrlopyLista.View = View.Details;
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
            // FormUrlopy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 43);
            ClientSize = new Size(1160, 642);
            Controls.Add(livUrlopyLista);
            ForeColor = Color.White;
            Name = "FormUrlopy";
            Text = "FormUrlopy";
            ResumeLayout(false);
        }

        #endregion

        private ListView livUrlopyLista;
        private ColumnHeader Id;
        private ColumnHeader Login;
        private ColumnHeader Poczatek;
        private ColumnHeader Koniec;
        private ColumnHeader Powod;
        private ColumnHeader Status;
    }
}