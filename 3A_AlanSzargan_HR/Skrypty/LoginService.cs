using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _3A_AlanSzargan_HR.LogowanieOsoby
{
    public class LoginService
    {
        private static string plikJson = "osoby.json";

        public static List<Osoba> listaOsob = new List<Osoba>();

        static LoginService()
        {
            WczytajZPliku();
        }
        public static void WczytajZPliku()
        {
            if (File.Exists(plikJson))
            {
                string json = File.ReadAllText(plikJson);
                listaOsob = JsonSerializer.Deserialize<List<Osoba>>(json, new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() }
                }) ?? new List<Osoba>();
            }
            else
            {
                listaOsob = new List<Osoba>();
            }
            if (listaOsob.Count == 0)
            {
                Osoba admin = new Osoba(
                    "Admin",
                    "Systemowy",
                    "admin123",
                    new DateTime(1990, 1, 1),
                    "admin@local",
                    "000000000",
                    true,
                    Role.Rola.AdministratorHR
                    );
                listaOsob.Add(admin);
                ZapiszDoPliku();
            }
        }
        public static void ZapiszDoPliku()
        {
            string json = JsonSerializer.Serialize(listaOsob, new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            });
            File.WriteAllText(plikJson, json);
        }

        public Osoba? LogowanieOsoby (string login, string haslo)
        {
            return listaOsob.Find(o => o.Login == login && o.Haslo == haslo);
        }
    }
}
