using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArkadhiaSoulsHunters.ControladorPrincipal
{
    public class Controlador
    {
        private static Controlador unicaInstancia;
        private static DaoFactoria factoria = DaoFactoria.GetUnicaInstancia();

        private Controlador() { }

        public static Controlador GetUnicaInstancia()
        {
            if (unicaInstancia == null) unicaInstancia = new Controlador();
            return unicaInstancia;
        }

        public bool Login(string nick, string clave)
        {
            DaoUsuario usuarioDao = factoria.GetDaoUsuario();
            return usuarioDao.CheckLogin(nick, clave);
        }

    }
}