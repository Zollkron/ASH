using ArkadhiaSoulsHunters.Modelo;
using System.Collections.Generic;

public interface IDaoUsuario
{
    //Métodos CRUD (Create, Read, Update y Delete). El Read lo vamos a cambiar por otros métodos Find más adelante.
    bool Create(Usuario usuario);
    bool Update(Usuario usuario);
    bool Delete(Usuario usuario);

    //Métodos Find que sustituyen al Read
    Usuario FindById(int id);
    Usuario FindByNick(string nick);
    Usuario FindByEmail(string email);
    List<Usuario> FindAll();

    //Métodos con funcionalidad
    bool CheckLogin(string nick, string clave);
}
