using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portaviones.Models
{
    public class Despegue
    {
        public int ID { get; set; }

        public string str_Despegue { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public string Serie { get; set; }

        public string Marca  { get; set; }

        public string Modelo { get; set; }

        public string Tecnico { get; set; }

        public string Mision { get; set; }

    }
}