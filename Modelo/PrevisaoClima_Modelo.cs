using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AUvo_Teste.Modelo
{
    public class PrevisaoClima_Modelo
    {
        public int ID { get; set; }
        public int CidadeID { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal  TemperaturaMaxima { get; set; }
    }
}