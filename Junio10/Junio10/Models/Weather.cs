using Junio10.Models;
using Junio10.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio10.Models
{
    public class Weather
    {
        public int WeatherId { set; get; }
        public  string Fecha { set; get; }
        public  string Estado { set; get; }
        public  string Lugar { set; get; }

        public Weather()
        {
        }

        public Weather(int weatherId, string fecha, string estado, string lugar)
        {
            WeatherId = weatherId;
            Fecha = fecha;
            Estado = estado;
            Lugar = lugar;
        }
    }
}