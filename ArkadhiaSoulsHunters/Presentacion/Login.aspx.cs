using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArkadhiaSoulsHunters.Modelo;
using ArkadhiaSoulsHunters.ControladorPrincipal;

namespace ArkadhiaSoulsHunters.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        Controlador controlador;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario();
            controlador = Controlador.GetUnicaInstancia();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //nick.Text = "He pulsado el botón";
            nick.Text = controlador.Login(nick.Text, clave.Text).ToString();
        }
    }
}