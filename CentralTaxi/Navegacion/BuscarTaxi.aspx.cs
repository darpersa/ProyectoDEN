﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navegacion
{
    public partial class BuscarTaxi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (rdbConductor.Checked)
                lblTmpBusca.Text = "Conductor";
            else if (rdbPatente.Checked)
                lblTmpBusca.Text = "Patente";

        }

        
    }
}