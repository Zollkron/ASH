public class DaoFactoria : IDaoFactoria
{
    private static DaoFactoria unicaInstancia;

    private DaoFactoria() { }

    public static DaoFactoria GetUnicaInstancia()
    {
        if (unicaInstancia == null) unicaInstancia = new DaoFactoria();
        return unicaInstancia;
    }

    public DaoUsuario GetDaoUsuario()
    {
        return new DaoUsuario();
    }
}
