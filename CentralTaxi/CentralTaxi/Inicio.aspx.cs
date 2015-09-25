using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTaxi;

namespace CentralTaxi
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Taxi taxi = (Taxi)Session["centralTaxi"];
            if (taxi == null)
            {
                taxi = new Taxi();
                Session["centralTaxi"] = taxi;
            }
        }

        public List<Viaje> obtenerListaViaje()
        {
            Taxi taxi = (Taxi)Session["centralTaxi"];
            return taxi.ListViaje;
        }
    }
}