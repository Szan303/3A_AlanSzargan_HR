using _3A_AlanSzargan_HR.LogowanieOsoby;
using System.Security.Cryptography.X509Certificates;

namespace _3A_AlanSzargan_HR
{
    public partial class FormUsuwanieOsob : Form
    {
        public FormUsuwanieOsob()
        {
            InitializeComponent();
        }

        private void btnUsuwanieOsobUsun_Click(object sender, EventArgs e)
        {
            Osoba x = LoginService.listaOsob.Find(o => o.Login == txbUsuwanieOsobLogin.Text);
            if (x == null)
            {
                MessageBox.Show("Nie znaleziono użytkownika o podanym loginie.");
                return;
            }
            if (String.IsNullOrWhiteSpace(txbUsuwanieOsobLogin.Text))
            {
                MessageBox.Show("Pole login nie może być puste.");
                return;
            }
            LoginService.listaOsob.Remove(x);
            LoginService.ZapiszDoPliku();
            MessageBox.Show("Usunięto użytkownika.");
            this.Close();
        }
    }
}
