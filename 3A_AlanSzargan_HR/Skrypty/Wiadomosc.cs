using System;
using System.Collections.Generic;
using System.Text;

namespace _3A_AlanSzargan_HR.Skrypty
{
    public class Wiadomosc
    {
        public Guid Id { get; set; }
        public Guid NadawcaId { get; set; }
        public string Tekst {  get; set; }
        public DateTime DataWyslania { get; set; }
    }
}
