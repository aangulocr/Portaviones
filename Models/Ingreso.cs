using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portaviones.Models
{
    public class Ingreso
    {

        public int Serie { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NombreFantasia { get; set; }

        public float DimensionAla { get; set; }

        public float Alto { get; set; }

        public float Largo { get; set; }

        public float DistanciaVuelo { get; set; }

        public DateTime Fecha { get; set; }

        public string Tecnico { get; set; }

        public bool Activo { get; set; }
    }
}