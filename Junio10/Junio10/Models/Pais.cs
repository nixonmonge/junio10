using Junio10.Models;
using Junio10.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio10.Models
{
    public class Pais
    {
        public int PaisId { set; get; }
        public string PaisNombre { set; get; }

        public Pais()
        {
        }

        public Pais(int paisId, string nombre)
        {
            PaisId = paisId;
            PaisNombre = nombre;
        }
    }
}