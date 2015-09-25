using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTaxi;

namespace CentralTaxi
{
    public partial class IngresarViaje : System.Web.UI.Page
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Viaje viaje = new Viaje();
            viaje.Id = int.Parse(txtId.Text);
            viaje.Cliente = txtNombre.Text;
            viaje.DireccionInicio = txtDireccionInicio.Text;
            viaje.DirecconFinal = txtDireccionFin.Text;

            Taxi taxi = (Taxi)Session["centralTaxi"];
            taxi.ListViaje.Add(viaje);

            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccionInicio.Text = "";
            txtDireccionFin.Text = "";
        }
    }
}