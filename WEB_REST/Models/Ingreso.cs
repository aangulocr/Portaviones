using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_REST.Models
{
    public class Ingreso
    {
        public int Serie { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NombreFantasia { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public Decimal DimensionAla { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public Decimal Alto { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public Decimal Largo { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public Decimal DistanciaVuelo { get; set; }

        public DateTime Fecha { get; set; }

        public string Tecnico { get; set; }

        public bool Activo { get; set; }
    }
}