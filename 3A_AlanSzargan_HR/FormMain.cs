using _3A_AlanSzargan_HR.LogowanieOsoby;
using _3A_AlanSzargan_HR.Skrypty;
using FormsTimer = System.Windows.Forms.Timer;
namespace _3A_AlanSzargan_HR
{
    public partial class FormMain : Form
    {
        private FormsTimer timerAktywnosc;
        private FormsTimer timerCzat;

        private Osoba Aktualnaosoba;
        public FormMain(Osoba osoba)
        {
            InitializeComponent();
            WiadomoscService.WczytajCzat();

            Aktualnaosoba = osoba;
            timerAktywnosc = new FormsTimer();
            timerAktywnosc.Interval = 1 * 60 * 1000; // minuta
            timerAktywnosc.Tick += TimerAktywnosc_Tick;
            timerAktywnosc.Start();

            timerCzat = new FormsTimer();
            timerCzat.Interval = 2000; // co 2 sekundy odświeżenie
            timerCzat.Tick += TimerCzat_Tick;
            timerCzat.Start();


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
        private void TimerCzat_Tick(object? sender, EventArgs e)
        {
            WiadomoscService.WczytajCzat();
            OdswiezCzat();
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
            libMainListaOsob.Items.Clear();
            libMainListaOsob.DataSource = null;
            foreach (var o in LoginService.listaOsob)
            {
                libMainListaOsob.Items.Add($"{o.Imie} {o.Nazwisko} - {o.RolaOsoby} Ostatnia Aktywność: {PokazCzasOd(o.OstatniaAktywnosc)}");
            }

        }

        private void btnMainGlobalSendMessage_Click(object sender, EventArgs e)
        {
            string tekst = txbMainGlobalChatMessage.Text;
            if (!string.IsNullOrWhiteSpace(tekst))
            {
                WiadomoscService.WyslijWiadomosc(Aktualnaosoba, tekst);
                OdswiezCzat();
                txbMainGlobalChatMessage.Clear();
            }
        }
        private void OdswiezCzat()
        {
            libMainGlobalChat.Items.Clear();

            foreach (var msg in WiadomoscService.listaWiadomosci)
            {
                var nadawca = LoginService.listaOsob.FirstOrDefault(o => o.Id == msg.NadawcaId);
                string nazwa = nadawca != null ? $"{nadawca.Imie} {nadawca.Nazwisko}" : "Nieznany";

                TimeSpan roznica = DateTime.Now - msg.DataWyslania;
                string czas = roznica.TotalSeconds < 60 ? $"{(int)roznica.TotalSeconds}s temu" :
                              roznica.TotalMinutes < 60 ? $"{(int)roznica.TotalMinutes}m temu" :
                              roznica.TotalHours < 24 ? $"{(int)roznica.TotalHours}h temu" :
                              msg.DataWyslania.ToString("dd.MM.yyyy HH:mm");

                libMainGlobalChat.Items.Add($"{nazwa}: {msg.Tekst} ({czas})");
            }

            // opcjonalnie przewiń na dół
            if (libMainGlobalChat.Items.Count > 0)
                libMainGlobalChat.TopIndex = libMainGlobalChat.Items.Count - 1;
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerAktywnosc.Stop();
            timerCzat.Stop();
            TimerAktywnosc_Tick(null, null);
            WiadomoscService.ZapiszCzat();
            //DateTime aktualnyczas = DateTime.Now;
            //Aktualnaosoba.OstatniaAktywnosc = aktualnyczas;
            //LoginService.ZapiszDoPliku();
        }
    }
}
