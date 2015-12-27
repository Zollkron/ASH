using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using ArkadhiaSoulsHunters.ControladorPrincipal;

namespace ArkadhiaSoulsHunters
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Controlador controlador = Controlador.GetUnicaInstancia();
                if(Session["Usuario"] == null) Response.Redirect("~/Presentacion/Login.aspx");
            }
        }
    }
}