using System;
using System.Collections.Generic;
using ArkadhiaSoulsHunters.Modelo;
using System.Linq;

public class DaoUsuario : IDaoUsuario
{
    //Métodos CRUD
    public bool Create(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public bool Update(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    //Métodos Find
    public Usuario FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Usuario FindByNick(string nick)
    {
        using (var context = new arkadhiashdbEntities())
        {
            IQueryable<Usuario> usuariosQuery = from usuario in context.Usuario
                                                where usuario.nick == nick
                                                select usuario;
            return usuariosQuery.FirstOrDefault<Usuario>();
        }
    }

    public Usuario FindByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public List<Usuario> FindAll()
    {
        throw new NotImplementedException();
    }    

    public bool CheckLogin(string nick, string clave)
    {
        Usuario usuario = FindByNick(nick);
        if (usuario == null) return false;
        return (usuario.nick == nick && usuario.clave == clave);
    }

}
