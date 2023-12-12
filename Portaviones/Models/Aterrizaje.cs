using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portaviones.Models
{
    public class Aterrizaje
    {
        public int ID { get; set; }

        public string Mision { get; set; }

        public string Despegue { get; set; }

        public DateTime FechaDespegue { get; set; }

        public TimeSpan HoraDespegue { get; set; }

        public string Serie { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }  

        public DateTime FechaAterrizaje { get; set; }       

        public bool PerdidaNave { get; set; }

        public string PerdidaHumana { get; set; }

        public bool Rescate { get; set; }
    }
}