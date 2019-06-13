using Junio10.Models;
using Junio10.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio10.Models
{
    public class Estado
    {
        public int EstadoId { set; get; }
        public string Nombre { set; get; }

        public Estado()
        {

        }

        public Estado(int estadoId, string nombre)
        {
            EstadoId = estadoId;
            Nombre = nombre;
        }
    }
}