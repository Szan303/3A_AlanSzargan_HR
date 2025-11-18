using _3A_AlanSzargan_HR.LogowanieOsoby;

namespace _3A_AlanSzargan_HR
{
    public partial class FormMain : Form
    {
        public FormMain(Osoba osoba)
        {
            InitializeComponent();
            btnMainDodajOsobe.Visible = false; 
            btnMainUsunOsobe.Visible = false;

            if (osoba.RolaOsoby == Role.Rola.AdministratorHR)
            {
                btnMainDodajOsobe.Visible = true; 
                btnMainUsunOsobe.Visible = true;
            }

            lblMainPrzywitanie.Text = $"Witaj, {osoba.Imie} {osoba.Nazwisko}!";
            
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
    }
}
