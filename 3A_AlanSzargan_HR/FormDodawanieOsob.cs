using _3A_AlanSzargan_HR.LogowanieOsoby;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A_AlanSzargan_HR
{
    public partial class FormDodawanieOsob : Form
    {
        public FormDodawanieOsob()
        {
            InitializeComponent();

            cmbDodajOsobeRola.DataSource = Enum.GetValues(typeof(Role.Rola));
        }

        private void btnDodajOsobeDodaj_Click(object sender, EventArgs e)
        {
            string Imie = txbDodajOsobeImie.Text;
            string Nazwisko = txbDodajOsobeNazwisko.Text;
            string Haslo = txbDodajOsobeHaslo.Text;
            DateTime DataUrodzenia = dtpDodajOsobeDataUrodzenia.Value;
            string Email = txtDodajOsobeEmail.Text;
            string Telefon = txtDodajOsobeTelefon.Text;
            Role.Rola RolaOsoby = (Role.Rola)cmbDodajOsobeRola.SelectedItem;
            // Sprawdzenie czy wszystkie pola są wypełnione
            if (string.IsNullOrWhiteSpace(Imie) ||
                string.IsNullOrWhiteSpace(Nazwisko) ||
                string.IsNullOrWhiteSpace(Haslo) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Telefon))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.");
                return;
            }

            // Warunki dotyczące długości imienia i nazwiska
            if (Imie.Length > 30)
            {
                MessageBox.Show("Imię nie może przekraczać 50 znaków.");
                return;
            }
            if (Nazwisko.Length > 50)
            {
                MessageBox.Show("Nazwisko nie może przekraczać 50 znaków.");
                return;
            }

            // Warunki dotyczące adresu email
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                MessageBox.Show("Proszę podać poprawny adres email.");
                return;
            }

            // Warunki dotyczące numeru telefonu
            if (int.TryParse(Telefon, out _) == false)
            {
                MessageBox.Show("Numer telefonu musi zawierać tylko cyfry.");
                return;
            }
            if (Telefon.Length != 9)
            {
                MessageBox.Show($"Numer telefonu musi zawierać dokładnie 9 cyfr. Podano: {Telefon.Length}");
                return;
            }


            Osoba nowaOsoba = new Osoba(Imie, Nazwisko, Haslo, DataUrodzenia, Email, Telefon, RolaOsoby);
            LoginService.listaOsob.Add(nowaOsoba);
            LoginService.ZapiszDoPliku();

            MessageBox.Show("Dodano nową osobę: " + nowaOsoba.Imie + " " + nowaOsoba.Nazwisko);
            this.Close();
        }
    }
}
