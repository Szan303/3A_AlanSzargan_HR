using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace _3A_AlanSzargan_HR.Skrypty
{
    public class WiadomoscService
    {
        private static string plikCzat = "wiadomosci.txt";
        public static List<Wiadomosc> listaWiadomosci { get; set; } = new List<Wiadomosc>();

        public static void WczytajCzat()
        {
            if (File.Exists(plikCzat)) 
            {
                string json = File.ReadAllText(plikCzat);
                listaWiadomosci = JsonSerializer.Deserialize<List<Wiadomosc>>(json) ?? new List<Wiadomosc>();
            }
        }

        public static void ZapiszCzat()
        {
            string json = JsonSerializer.Serialize(listaWiadomosci, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(plikCzat, json);
        }

        // Dokończyć implementację metod do obsługi wiadomości!
    }
}
