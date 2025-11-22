using _3A_AlanSzargan_HR.Skrypty;

namespace _3A_AlanSzargan_HR
{
    public partial class FormWniosekOUrlop : Form
    {
        private Osoba Aktualnaosoba;
        public FormWniosekOUrlop(Osoba aktualnaosoba)
        {
            InitializeComponent();
            Aktualnaosoba = aktualnaosoba;
        }

        private void btnWniosekOUrlopZatwierdz_Click(object sender, EventArgs e)
        {
            DateTime poczatek = dtpWniosekOUrlopPoczatek.Value.Date;
            DateTime koniec = dtpWniosekOUrlopKoniec.Value.Date;
            string powod = txbWniosekOUrlopPowod.Text.Trim();
            if (koniec < poczatek)
            {
                MessageBox.Show("Data zakończenia nie może być wcześniejsza niż data rozpoczęcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((koniec - poczatek).TotalDays < 1)
            {
                MessageBox.Show("Urlop musi trwać co najmniej jeden dzień.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (poczatek < DateTime.Now.Date)
            {
                MessageBox.Show("Data rozpoczęcia nie może być w przeszłości.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (koniec < DateTime.Now.Date)
            {
                MessageBox.Show("Data zakończenia nie może być w przeszłości.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(powod))
            {
                MessageBox.Show("Proszę podać powód urlopu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UrlopService urlopService = new UrlopService();
            urlopService.StworzUrlop(poczatek, koniec, powod, Aktualnaosoba.Id);
            MessageBox.Show("Wniosek o urlop został pomyślnie złożony.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
