using _3A_AlanSzargan_HR.Forms;
using _3A_AlanSzargan_HR.Skrypty;

namespace _3A_AlanSzargan_HR
{
    public partial class FormZarzadzanieUrlopami : Form
    {
        public FormZarzadzanieUrlopami()
        {
            InitializeComponent();

            UrlopService.WczytajUrlopy();

            OdswierzWnioskiOUrlop();
            OdswierzZatwierdzone();
        }
        private void OdswierzWnioskiOUrlop()
        {
            livFormZarzadzanieUrlopamiWnioskiOUrlop.Items.Clear();

            foreach (var u in UrlopService.listaUrlopow.Where(x => x.Status == Urlop.StatusUrlopu.Oczekuje))
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

                livFormZarzadzanieUrlopamiWnioskiOUrlop.Items.Add(item);
            }
        }
        private void OdswierzZatwierdzone()
        {
            livZarzadzanieUrlopamiZatwierdzone.Items.Clear();

            foreach (var u in UrlopService.listaUrlopow.Where(x => x.Status == Urlop.StatusUrlopu.Zatwierdzony))
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

                livZarzadzanieUrlopamiZatwierdzone.Items.Add(item);
            }
        }

        private void btnZarzadzanieUrlopamiZatwierdzUrlop_Click(object sender, EventArgs e)
        {
            if (livFormZarzadzanieUrlopamiWnioskiOUrlop.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz wniosek o urlop do zatwierdzenia.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = livFormZarzadzanieUrlopamiWnioskiOUrlop.SelectedItems[0];
            var urlop = item.Tag as Urlop;

            if (urlop == null)
            {
                MessageBox.Show("Nie udało się pobrać danych wniosku", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            urlop.Status = Urlop.StatusUrlopu.Zatwierdzony;

            UrlopService.ZapiszUrlopy();

            OdswierzWnioskiOUrlop();
            OdswierzZatwierdzone();
        }

        private void btnZarzadzanieUrlopamiOdrzuc_Click(object sender, EventArgs e)
        {
            if (livFormZarzadzanieUrlopamiWnioskiOUrlop.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz wniosek o urlop do zatwierdzenia.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = livFormZarzadzanieUrlopamiWnioskiOUrlop.SelectedItems[0];
            var urlop = item.Tag as Urlop;

            if (urlop == null)
            {
                MessageBox.Show("Nie udało się pobrać danych wniosku", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            urlop.Status = Urlop.StatusUrlopu.Odrzucony;

            UrlopService.ZapiszUrlopy();

            OdswierzWnioskiOUrlop();
            OdswierzZatwierdzone();
        }

        private void btnZarzadzanieUrlopamiAnulujUrlop_Click(object sender, EventArgs e)
        {
            if (livZarzadzanieUrlopamiZatwierdzone.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz wniosek o urlop do zatwierdzenia.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var item = livZarzadzanieUrlopamiZatwierdzone.SelectedItems[0];
            var urlop = item.Tag as Urlop;

            if (urlop == null)
            {
                MessageBox.Show("Nie udało się pobrać danych wniosku", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UrlopService.listaUrlopow.Remove(urlop);

            UrlopService.ZapiszUrlopy();

            OdswierzWnioskiOUrlop();
            OdswierzZatwierdzone();
        }

        private void btnZarzadzanieUrlopamiHistoria_Click(object sender, EventArgs e)
        {
            FormHistoriaUrlopow historiaUrlopow = new FormHistoriaUrlopow();
            historiaUrlopow.Show();
            this.Close();
        }

        private void FormZarzadzanieUrlopamiReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain(FormMain.Aktualnaosoba);
            formMain.Show();
        }
    }
}
