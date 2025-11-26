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
    public partial class FormHistoriaUrlopow : Form
    {
        public FormHistoriaUrlopow()
        {
            InitializeComponent();
            OdswierzListeUrlopow();
        }
        private void OdswierzListeUrlopow()
        {
            foreach (var u in UrlopService.listaUrlopow.Where(x => x.Status == Urlop.StatusUrlopu.Odrzucony))
            {
                var osoba = LoginService.listaOsob
                    .FirstOrDefault(o => o.Id == u.OsobaId);

                string login = osoba != null
                    ? $"{osoba.Imie}{osoba.Nazwisko}"
                    : "Nieznany użytkownik";

                var item = new ListViewItem(u.Id.ToString());
                item.SubItems.Add(login);
                item.SubItems.Add(u.Poczatek.ToString("dd.MM.yyyy"));
                item.SubItems.Add(u.Koniec.ToString("dd.MM.yyyy"));
                item.SubItems.Add(u.Powod);
                item.SubItems.Add(u.Status.ToString());

                item.Tag = u;

                livFormHistoriaUrlopowOdrzucone.Items.Add(item);
            }
            foreach (var u in UrlopService.listaUrlopow.Where(x => x.Status == Urlop.StatusUrlopu.Odrzucony))
            {
                var osoba = LoginService.listaOsob
                    .FirstOrDefault(o => o.Id == u.OsobaId);

                string login = osoba != null
                    ? $"{osoba.Imie}{osoba.Nazwisko}"
                    : "Nieznany użytkownik";

                var item = new ListViewItem(u.Id.ToString());
                item.SubItems.Add(login);
                item.SubItems.Add(u.Poczatek.ToString("dd.MM.yyyy"));
                item.SubItems.Add(u.Koniec.ToString("dd.MM.yyyy"));
                item.SubItems.Add(u.Powod);
                item.SubItems.Add(u.Status.ToString());

                item.Tag = u;

                livFormHistoriaUrlopowZakonczone.Items.Add(item);
            }
        }

        private void FormHistoriaUrlopowReturn_Click(object sender, EventArgs e)
        {
            FormZarzadzanieUrlopami zarzadzanieUrlopami = new FormZarzadzanieUrlopami();
            zarzadzanieUrlopami.Show();

            this.Close();
        }
    }
}
