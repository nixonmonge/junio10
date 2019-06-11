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
    public partial class WebInsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1) crear un objeto clima
            Weather clima = new Weather();

            //2) leer los valores de los cuadros de texto y guardarlos en el objeto
            clima = WeatherServicio.Factory(TextWeatherId, TextFecha, TextEstado, TextLugar);
            //3) agregar el objeto a la lista // esto se fue a Weather Servicio
            /*List<Weather> climas =(List<Weather>)Session["listado"];
            climas.Add(clima);
            Session["listado"] = climas;*/
            WeatherServicio.Insertar(clima,Session);
            //4) devolvernos a la pagina lista
            Response.Redirect("WebListar.aspx");

        }
    }
}