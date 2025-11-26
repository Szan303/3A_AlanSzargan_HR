using _3A_AlanSzargan_HR.Skrypty;

namespace _3A_AlanSzargan_HR.Forms
{
    public partial class FormUrlopy : Form
    {
        private Osoba Aktualnaosoba;
        public FormUrlopy(Osoba aktualnaosoba)
        {
            InitializeComponent();
            Aktualnaosoba = aktualnaosoba;
            OdswierzListeUrlopow();

        }
        private void OdswierzListeUrlopow()
        {
            foreach (var u in UrlopService.listaUrlopow.Where(x => x.OsobaId == Aktualnaosoba.Id))
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

                livUrlopyLista.Items.Add(item);
            }
        }
    }
}
