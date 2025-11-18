using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace _3A_AlanSzargan_HR.LogowanieOsoby
{
    public class Osoba
    {
        public Guid Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Boolean IsActive { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role.Rola RolaOsoby { get; set; }

        public Osoba(string imie, string nazwisko, string haslo, DateTime dataUrodzenia, string email, string telefon, Boolean isActive, Role.Rola rolaOsoby)
        {
            Id = Guid.NewGuid();
            Imie = imie;
            Nazwisko = nazwisko;
            Login = imie + nazwisko;
            Haslo = haslo;
            DataUrodzenia = dataUrodzenia;
            Email = email;
            Telefon = telefon;
            IsActive = isActive;
            RolaOsoby = rolaOsoby;
        }
        
    }
}
