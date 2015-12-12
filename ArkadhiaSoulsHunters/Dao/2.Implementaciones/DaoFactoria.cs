public class DaoFactoria : IDaoFactoria
{
    private static DaoFactoria unicaInstancia;

    private DaoFactoria() { }

    //public DaoUsuario getDaoUsuario()
    //{
    //    return new DaoUsuario();
    //}

    public DaoFactoria getUnicaInstancia()
    {
        if (unicaInstancia == null) unicaInstancia = new DaoFactoria();
        return unicaInstancia;
    }

}
