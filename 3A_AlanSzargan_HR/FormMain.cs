using _3A_AlanSzargan_HR.LogowanieOsoby;
using FormsTimer = System.Windows.Forms.Timer;
namespace _3A_AlanSzargan_HR
{
    public partial class FormMain : Form
    {
        private FormsTimer timerAktywnosc;
        private Osoba Aktualnaosoba;
        public FormMain(Osoba osoba)
        {
            InitializeComponent();

            Aktualnaosoba = osoba;
            timerAktywnosc = new FormsTimer();
            timerAktywnosc.Interval = 1 * 60 * 1000; // minuta
            timerAktywnosc.Tick += TimerAktywnosc_Tick;
            timerAktywnosc.Start();

            OdswierzTabliceOsob();

            btnMainDodajOsobe.Visible = false;
            btnMainUsunOsobe.Visible = false;

            if (osoba.RolaOsoby == Role.Rola.AdministratorHR)
            {
                btnMainDodajOsobe.Visible = true;
                btnMainUsunOsobe.Visible = true;
            }

            lblMainPrzywitanie.Text = $"Witaj, {osoba.Imie} {osoba.Nazwisko}!";
            // Zabezpieczyć przed naciśnięciem X aby wyjść z aplikacji i zakualizować wtedy Tick
        }
        public static string PokazCzasOd(DateTime ostatniaAktywnosc)
        {
            TimeSpan roznica = DateTime.Now - ostatniaAktywnosc;

            if (roznica.TotalSeconds < 60)
                return $"{(int)roznica.TotalSeconds} sekund temu";
            else if (roznica.TotalMinutes < 60)
                return $"{(int)roznica.TotalMinutes} minut temu";
            else if (roznica.TotalHours < 24)
                return $"{(int)roznica.TotalHours} godzin temu";
            else
                return ostatniaAktywnosc.ToString("dd.MM.yyyy HH:mm"); // starsze niż 1 dzień
        }
        private void TimerAktywnosc_Tick(object? sender, EventArgs e)
        {
            DateTime aktualnyczas = DateTime.Now;
            Aktualnaosoba.OstatniaAktywnosc = aktualnyczas;
            LoginService.ZapiszDoPliku();
            OdswierzTabliceOsob();
        }
        private void btnMainDodajOsobe_Click(object sender, EventArgs e)
        {
            FormDodawanieOsob dodawanieosob = new FormDodawanieOsob();
            dodawanieosob.Show();
        }
        private void btnMainUsunOsobe_Click(object sender, EventArgs e)
        {
            FormUsuwanieOsob usuwanieosob = new FormUsuwanieOsob();
            usuwanieosob.Show();
        }
        public void OdswierzTabliceOsob()
        {
            libMainListaOsob.DataSource = null;
            foreach (var o in LoginService.listaOsob)
            {
                libMainListaOsob.Items.Add($"{o.Imie} {o.Nazwisko} - {o.RolaOsoby} Ostatnia Aktywność: {PokazCzasOd(o.OstatniaAktywnosc)}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
