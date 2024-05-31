using PPAIDSI.Dominio;

namespace PPAIDSI.Datos.DAO
{
    public interface IDAOVino
    {
        List<Vino> GetVinoByFilter(string nombre);

        List<Reseña> GetResenasByIdVino(int id);
    }
}