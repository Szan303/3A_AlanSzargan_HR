using _3A_AlanSzargan_HR.Skrypty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A_AlanSzargan_HR.Forms
{
    public partial class FormWiadomoscDoHR : Form
    {
        public Osoba Aktualnaosoba;
        public FormWiadomoscDoHR(Osoba aktualnaosoba)
        {
            InitializeComponent();
            Aktualnaosoba = aktualnaosoba;
        }

        private void btnWiadomoscDoHRWyslij_Click(object sender, EventArgs e)
        {
            string tytul = txbWiadomoscDoHRTytul.Text;
            string tresc = rtbWiadomoscDoHRTresc.Text;

            if (string.IsNullOrWhiteSpace(tytul) ||
                string.IsNullOrWhiteSpace(tresc))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WiadomoscDoHRService.WyslijWiadomosc(Aktualnaosoba, tytul, tresc);
            MessageBox.Show("Wiadomość została wysłana do działu HR.", "Sukces",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
