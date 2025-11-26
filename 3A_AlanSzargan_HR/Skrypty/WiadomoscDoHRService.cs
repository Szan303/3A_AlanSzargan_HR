using System.Text.Json;

namespace _3A_AlanSzargan_HR.Skrypty
{
    public class WiadomoscDoHRService
    {
        private static string plikWiadomosciDoHR = "wiadomosci_do_hr.mes";
        public static List<WiadomoscDoHR> listaWiadomosciDoHR { get; set; } = new List<WiadomoscDoHR>();


        public static void WyslijWiadomosc(Osoba nadawca, string tytul, string tresc)
        {
            if (nadawca == null) return;

            var msg = new WiadomoscDoHR
            {
                NadawcaId = nadawca.Id,
                Temat = tytul,
                Tresc = tresc,
                DataWyslania = DateTime.Now
            };
            listaWiadomosciDoHR.Add(msg);
            ZapiszWiadomosciDoHR();
        }
        public static void WczytajWiadomosciDoHR()
        {
            if (File.Exists(plikWiadomosciDoHR))
            {
                string json = File.ReadAllText(plikWiadomosciDoHR);
                listaWiadomosciDoHR = JsonSerializer.Deserialize<List<WiadomoscDoHR>>(json) ?? new List<WiadomoscDoHR>();
            }
        }

        public static void ZapiszWiadomosciDoHR()
        {
            string json = JsonSerializer.Serialize(listaWiadomosciDoHR, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(plikWiadomosciDoHR, json);
        }
    }
}
