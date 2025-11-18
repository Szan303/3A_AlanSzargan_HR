using _3A_AlanSzargan_HR.LogowanieOsoby;

namespace _3A_AlanSzargan_HR
{
    public partial class FormLogowanie : Form
    {
        public FormLogowanie()
        {
            InitializeComponent();
            LoginService.WczytajZPliku();
        }
        private void btnLogowanieZaloguj_Click(object sender, EventArgs e)
        {
            string inputlogin = txbLogowanieLogin.Text;
            string inputhaslo = txbLogowanieHaslo.Text;
            
            if (string.IsNullOrWhiteSpace(inputlogin) || string.IsNullOrWhiteSpace(inputhaslo))
            {
                MessageBox.Show("Proszê wprowadziæ zarówno login, jak i has³o.");
                return;
            }
            if (inputlogin.Length > 30)
            {
                MessageBox.Show("Login nie mo¿e przekraczaæ 30 znaków.");
            }

            LoginService loginService = new LoginService();

            Osoba osoba = loginService.LogowanieOsoby(inputlogin, inputhaslo);
            if (osoba != null)
            {
                MessageBox.Show($"Logowanie powiod³o siê. Witaj, {osoba.Imie} {osoba.Nazwisko} !");
                this.Hide();
                FormMain mainForm = new FormMain(osoba);
                mainForm.Show();
            } else
            {
                MessageBox.Show("Nieprawid³owy login lub has³o. Spróbuj ponownie.");
            }
        }
    }
}
