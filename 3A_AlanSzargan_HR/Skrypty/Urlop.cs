namespace _3A_AlanSzargan_HR.Skrypty
{
    public class Urlop
    {
        public Guid Id { get; set; }
        public Guid OsobaId { get; set; }
        public DateTime Poczatek { get; set; }
        public DateTime Koniec { get; set; }
        public string Powod { get; set; }
        public StatusUrlopu Status { get; set; }
        public enum StatusUrlopu
        {
            Oczekuje,
            Zatwierdzony,
            Odrzucony,
            Zakonczony
        }
        //public Urlop() { }
        //public Urlop(Guid osobaId, DateTime poczatek, DateTime koniec, string powod)
        //{
        //    Id = Guid.NewGuid();
        //    OsobaId = osobaId;
        //    Poczatek = poczatek;
        //    Koniec = koniec;
        //    Powod = powod;
        //    Status = StatusUrlopu.Oczekuje;
        //}
    }
}
