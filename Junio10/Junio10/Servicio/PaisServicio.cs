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
    public class PaisServicio
    {
        public static void Insertar(Pais pais, HttpSessionState sesion) //se remplazo el insertar por la sesion
        {
            List<Pais> climas = ListarTodo(sesion); //leemos
            climas.Add(pais);// agregamos
            sesion["llavePais"] = climas; // guardamos la sesion
        }
        public static Pais Factory(TextBox PaisId, TextBox PaisNombre)
        {
            Pais nuevoPais = new Pais();
            nuevoPais.PaisId = Convert.ToInt32(PaisId.Text);
            nuevoPais.PaisNombre = PaisNombre.Text;
            return nuevoPais;
        }

        public static List<Pais> ListarTodo(HttpSessionState sesion)
        {
            if (sesion["llavePais"] != null)
            {
                return (List<Pais>)sesion["llavePais"];
            }
            else
            {
                return new List<Pais>();
            }







        }
}