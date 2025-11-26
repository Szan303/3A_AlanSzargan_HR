using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace _3A_AlanSzargan_HR.Skrypty
{
    public class Grafik
    {
        Guid PracownikId { get; set; }
        DateTime Data { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Zmiany.Zmiana Zmiana { get; set; }
    }
}
