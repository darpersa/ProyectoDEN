using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTaxi;

namespace CentralTaxi
{
    public partial class EliminarViaje : System.Web.UI.Page
    {

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Taxi taxi = (Taxi)Session["centralTaxi"];
            Viaje viaje = taxi.ListViaje.Find(c => c.Id == int.Parse(txtId.Text));
            if (viaje != null)
            {
                lblId.Text = string.Format("{0}", viaje.Id);
                lblNombre.Text = viaje.Cliente;
                lblDireccionInicio.Text = viaje.DireccionInicio;
                lblDireccionFinal.Text = viaje.DirecconFinal;
            }
            else
            {
                limpiar();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Taxi taxi = (Taxi)Session["centralTaxi"];
            Viaje viaje = taxi.ListViaje.Find(c => c.Id == int.Parse(txtId.Text));
            taxi.ListViaje.Remove(viaje);

            limpiar();
        }

        public void limpiar()
        {
            txtId.Text = "";
            lblId.Text = "";
            lblNombre.Text = "";
            lblDireccionInicio.Text = "";
            lblDireccionFinal.Text = "";
        }
    }
}