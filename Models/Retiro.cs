using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portaviones.Models
{
    public class Retiro
    {
        public int Id { get; set; }

        public string Serie { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NombreFantasia { get; set; }

        public string Detalle { get; set; }

        public string Tecnico  { get; set; }
    }
}