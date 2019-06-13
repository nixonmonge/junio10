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

        //public  string Lugar { set; get; }
        public Pais Pais { set; get; } = new Pais();
        public Estado Estado { set; get; } = new Estado();

        //Quick Action = crear un constructor vacio
        public Weather()
        {
            Pais = new Pais();
        }
    }
}