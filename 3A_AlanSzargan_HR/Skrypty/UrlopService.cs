using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3A_AlanSzargan_HR.Skrypty
{
    public class UrlopService
    {
        public static string plikJson = "urlopy.json";
        public static List<Urlop> listaUrlopow = new();

        public void StworzUrlop(DateTime poczatek, DateTime koniec, string powod, Guid osobaId)
        {
            var osoba = LoginService.listaOsob.FirstOrDefault(o => o.Id == osobaId);
            if (osoba == null)
            {
                throw new Exception("Osoba nie istnieje");
            }
            Urlop urlop = new Urlop
            {
                Id = Guid.NewGuid(),
                OsobaId = osobaId,
                Poczatek = poczatek,
                Koniec = koniec,
                Powod = powod,
                Status = Urlop.StatusUrlopu.Oczekuje
            };

            listaUrlopow.Add(urlop);
            ZapiszUrlopy();
        }
        public void AnulujUrlop(Guid urlopId)
        {
            listaUrlopow.RemoveAll(u => u.Id == urlopId);
            UrlopCheck();
            ZapiszUrlopy();
        }
        //public void ZatwierdzUrlop(Guid urlopId)
        //{
        //    var urlop = listaUrlopow.FirstOrDefault(u => u.Id == urlopId);
        //    if (urlop != null)
        //    {
        //        urlop.Status = Urlop.StatusUrlopu.Zatwierdzony;
        //    }
        //    UrlopCheck();
        //    ZapiszUrlopy();
        //}
        //public void OdrzucUrlop(Guid urlopId)
        //{
        //    var urlop = listaUrlopow.FirstOrDefault(u => u.Id == urlopId);
        //    if (urlop != null)
        //    {
        //        urlop.Status = Urlop.StatusUrlopu.Odrzucony;
        //    }
        //    UrlopCheck();
        //    ZapiszUrlopy();
        //}
        public void UrlopCheck()
        {
            foreach (var urlop in listaUrlopow)
            {
                if (urlop.Koniec < DateTime.Now && urlop.Status == Urlop.StatusUrlopu.Zatwierdzony)
                {
                    urlop.Status = Urlop.StatusUrlopu.Zakonczony;
                }
            }
            ZapiszUrlopy();
        }
        public static void ZapiszUrlopy()
        {
            string json = JsonSerializer.Serialize(listaUrlopow, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            File.WriteAllText(plikJson, json);
        }
        public static void WczytajUrlopy()
        {
            if (File.Exists(plikJson))
            {
                string json = File.ReadAllText(plikJson);
                listaUrlopow = JsonSerializer.Deserialize<List<Urlop>>(json) ?? new List<Urlop>();
            }
        }
        public List<Urlop> PobierzUrlopyOsoby(Guid osobaId)
        {
            List<Urlop> wynik = new List<Urlop>();
            foreach (var urlop in listaUrlopow)
            {
                if (urlop.OsobaId == osobaId)
                {
                    wynik.Add(urlop);
                }
            }
            return wynik;
        }
    }
}
