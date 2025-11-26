using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _3A_AlanSzargan_HR.Skrypty;

namespace _3A_AlanSzargan_HR.Forms
{
    public partial class FormSkrzynkaHR : Form
    {
        public FormSkrzynkaHR()
        {
            InitializeComponent();
            OdswierzSkrzynkeHR();
        }
        private void OdswierzSkrzynkeHR()
        {
            btnSkrzynkaHRReturn.Visible = false;
            txbSkrzynkaHRTytul.Visible = false;
            rtbSkrzynkaHRTresc.Visible = false;
            libSkrzynkaHRWiadomosci.Items.Clear();
            libSkrzynkaHRWiadomosci.Visible = true;


            foreach (var msg in WiadomoscDoHRService.listaWiadomosciDoHR)
            {
                var nadawca = LoginService.listaOsob.FirstOrDefault(o => o.Id == msg.NadawcaId);
                string nazwa = nadawca != null ? $"{nadawca.Imie} {nadawca.Nazwisko}" : "Nieznany";

                libSkrzynkaHRWiadomosci.Items
                    .Add($"{msg.Temat} - {nazwa} - {msg.DataWyslania:dd:MM:yyy HH:mm}");
            }
        }

        private void libSkrzynkaHRWiadomosci_DoubleClick(object sender, EventArgs e)
        {
            if (libSkrzynkaHRWiadomosci.SelectedIndex == -1) return;
            var msg = WiadomoscDoHRService.listaWiadomosciDoHR[libSkrzynkaHRWiadomosci.SelectedIndex];

            txbSkrzynkaHRTytul.Text = msg.Temat;
            rtbSkrzynkaHRTresc.Text = msg.Tresc;

            libSkrzynkaHRWiadomosci.Visible = false;

            btnSkrzynkaHRReturn.Visible = true;
            txbSkrzynkaHRTytul.Visible = true;
            rtbSkrzynkaHRTresc.Visible = true;
        }

        private void btnSkrzynkaReturn_Click(object sender, EventArgs e)
        {
            OdswierzSkrzynkeHR();
        }

        private void btnSkrzynkaHRUsun_Click(object sender, EventArgs e)
        {
            if (libSkrzynkaHRWiadomosci.SelectedIndex == -1) return;

            var msg = WiadomoscDoHRService.listaWiadomosciDoHR[libSkrzynkaHRWiadomosci.SelectedIndex];
            WiadomoscDoHRService.listaWiadomosciDoHR.Remove(msg);
            WiadomoscDoHRService.ZapiszWiadomosciDoHR();

            OdswierzSkrzynkeHR();
        }
    }
}
