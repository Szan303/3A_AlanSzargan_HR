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
    
    public partial class FormEdycjaOsob : Form
    {
        private Osoba wybranaosoba;
        public FormEdycjaOsob(Osoba Wybranaosoba)
        {
            wybranaosoba = Wybranaosoba;
            InitializeComponent();
            cmbEdytujOsobeRola.DataSource = Enum.GetValues(typeof(Role.Rola));

            txbEdytujOsobeImie.Text = wybranaosoba.Imie;
            txbEdytujOsobeNazwisko.Text = wybranaosoba.Nazwisko;
            txbEdytujOsobeHaslo.Text = wybranaosoba.Haslo;
            txbEdytujOsobeEmail.Text = wybranaosoba.Email;
            txbEdytujOsobeTelefon.Text = wybranaosoba.Telefon;
            cmbEdytujOsobeRola.SelectedItem = wybranaosoba.RolaOsoby;
            dtpEdytujOsobeDataUrodzenia.Value = wybranaosoba.DataUrodzenia;
        }

        private void btnEdytujOsobeEdytuj_Click(object sender, EventArgs e)
        {
            string Imie = txbEdytujOsobeImie.Text;
            string Nazwisko = txbEdytujOsobeNazwisko.Text;
            string login = Imie + Nazwisko;
            string Haslo = txbEdytujOsobeHaslo.Text;
            DateTime DataUrodzenia = dtpEdytujOsobeDataUrodzenia.Value;
            string Email = txbEdytujOsobeEmail.Text;
            string Telefon = txbEdytujOsobeTelefon.Text;
            Role.Rola RolaOsoby = (Role.Rola)cmbEdytujOsobeRola.SelectedItem;
            

            if (string.IsNullOrWhiteSpace(Imie) ||
                string.IsNullOrWhiteSpace(Nazwisko) ||
                string.IsNullOrWhiteSpace(Haslo) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Telefon))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Warunki dotyczące długości imienia i nazwiska
            if (Imie.Length > 30)
            {
                MessageBox.Show("Imię nie może przekraczać 50 znaków.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nazwisko.Length > 50)
            {
                MessageBox.Show("Nazwisko nie może przekraczać 50 znaków.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Warunki dotyczące adresu email
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                MessageBox.Show("Proszę podać poprawny adres email.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Warunki dotyczące numeru telefonu
            if (int.TryParse(Telefon, out _) == false)
            {
                MessageBox.Show("Numer telefonu musi zawierać tylko cyfry.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Telefon.Length != 9)
            {
                MessageBox.Show($"Numer telefonu musi zawierać dokładnie 9 cyfr. Podano: {Telefon.Length}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            wybranaosoba.Imie = Imie;
            wybranaosoba.Nazwisko = Nazwisko;
            wybranaosoba.Login = login;
            wybranaosoba.Haslo = Haslo;
            wybranaosoba.DataUrodzenia = DataUrodzenia;
            wybranaosoba.Email = Email;
            wybranaosoba.Telefon = Telefon;
            wybranaosoba.RolaOsoby = RolaOsoby;

            LoginService.ZapiszDoPliku();
            MessageBox.Show("Dane osoby zostały zaktualizowane.", "Sukces",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
