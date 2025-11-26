using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A_AlanSzargan_HR.Forms
{
    public partial class FormDialogEdycjaOsob : Form
    {
        public static string wybranylogin;
        public FormDialogEdycjaOsob()
        {
            InitializeComponent();
        }

        private void btnDialogEdycjaOsobOK_Click(object sender, EventArgs e)
        {
            wybranylogin = txbDialogEdycjaOsobLogin.Text;
            if (string.IsNullOrWhiteSpace(wybranylogin))
            {
                MessageBox.Show("Proszę wpisać poprawny login.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None; // Zapobiega zamknięciu okna dialogowego
            }
            if (wybranylogin.Contains(" "))
            {
                MessageBox.Show("Login nie może zawierać spacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None; // Zapobiega zamknięciu okna dialogowego
            }
            this.Close();
        }
    }
}
