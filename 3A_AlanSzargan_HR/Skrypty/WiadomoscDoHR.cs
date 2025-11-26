using System;
using System.Collections.Generic;
using System.Text;

namespace _3A_AlanSzargan_HR.Skrypty
{
    public class WiadomoscDoHR
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid NadawcaId { get; set; }
        public string Temat { get; set; }
        public string Tresc { get; set; }
        public DateTime DataWyslania { get; set; }
        //public WiadomoscDoHR(Guid nadawcaId, string temat, string tresc, DateTime dataWyslania)
        //{
        //    NadawcaId = nadawcaId;
        //    Temat = temat;
        //    Tresc = tresc;
        //    DataWyslania = dataWyslania;
        //}
        public WiadomoscDoHR() { }
    }
}
