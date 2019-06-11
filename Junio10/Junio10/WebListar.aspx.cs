using Junio10.Models;
using Junio10.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio10
{
    public partial class WebListar : System.Web.UI.Page
    {
         //List<Weather> climas;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Weather> climas = WeatherServicio.ListarTodo(Session); //simplificando el codigo

            // existe un listado?
            /*if (Session["listado"] != null) //Sesion es un "diccionario"
            {   // si : leemos el listado
                climas = (List<Weather>)Session["listado"]; //se agrega (List<Weather>) para definir cast ya que esto es un objeto
            }
            else //no : creamos el listado
            {
                climas = new List<Weather>();
                Session["listado"] = climas; // 
            }*/

            GridView1.DataSource = climas;
            GridView1.DataBind();
            
            

            // SESIONES
            //Cómo funcina ?
            // a ) yo me conecto a una pag web. si no tengo un token (identificado)
            //el sistema me crea uno, y me lo devuelve.
            //b) la proxima vez que me conecto a la pagina, envio el token automaticamente (llamado cookie)

        }
    }
}