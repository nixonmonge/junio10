using Junio10.Models;
using Junio10.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace Junio10.Servicio
{
    public class WeatherServicio
    {
        public static void Insertar(Weather clima, HttpSessionState sesion) //se remplazo el insertar por la sesion
        {
            List<Weather> climas = ListarTodo(sesion); //leemos
            climas.Add(clima);// agregamos
            sesion["listado"] = climas; // guardamos la sesion
        }
        public static Weather Factory(
            TextBox WeatherId, 
            TextBox Fecha,
            DropDownList Estado, 
            DropDownList ComoUbicacion)
        {
            Weather nuevoClima = new Weather();
            nuevoClima.Pais = new Models.Pais();
            nuevoClima.WeatherId = Convert.ToInt32(WeatherId.Text);
            nuevoClima.Fecha = Fecha.Text;
            nuevoClima.Estado.EstadoId = Convert.ToInt32(Estado.SelectedItem.Value);
            nuevoClima.Estado.Nombre= Estado.SelectedItem.Text;
            nuevoClima.Pais.PaisId =Convert.ToInt32(ComoUbicacion.SelectedItem.Value);
            nuevoClima.Pais.PaisNombre = ComoUbicacion.SelectedItem.Text;

            return nuevoClima;
        }

        public static List<Weather> ListarTodo(HttpSessionState sesion)
        {
            if (sesion["listado"] != null)
            {
                return (List<Weather>)sesion["listado"];
            }
            else
            {
                return new List<Weather>();
            }
            
        }
    }
}