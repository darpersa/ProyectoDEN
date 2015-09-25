using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTaxi;

namespace CentralTaxi
{
    public partial class ModificarViaje : System.Web.UI.Page
    {
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Taxi taxi = (Taxi)Session["centralTaxi"];
            Viaje viaje = taxi.ListViaje.Find(c => c.Id == int.Parse(txtId.Text));
            if (viaje != null)
            {
                lblId.Text = string.Format("{0}", viaje.Id);
                txtNombre.Text = viaje.Cliente;
                txtDireccionInicio.Text = viaje.DireccionInicio;
                txtDireccionFinal.Text = viaje.DirecconFinal;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Taxi taxi = (Taxi)Session["centralTaxi"];
            Viaje viaje = taxi.ListViaje.Find(c => c.Id == int.Parse(lblId.Text));
            viaje.Cliente = txtNombre.Text;
            viaje.DireccionInicio = txtDireccionInicio.Text;
            viaje.DirecconFinal = txtDireccionFinal.Text;

            txtId.Text = "";
            lblId.Text = "";
            txtNombre.Text = "";
            txtDireccionInicio.Text = "";
            txtDireccionFinal.Text = "";
        }
    }
}