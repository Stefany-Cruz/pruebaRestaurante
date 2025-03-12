using ProyectoIndustria.Domain.Entities;

namespace ProyectoIndustria.Domain.Repositories
{
    public interface IArchivoRepository
    {
        Task<Archivo> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Archivo>> ObtenerTodosAsync();
        Task AgregarAsync(Archivo archivo);
        Task ActualizarAsync(Archivo archivo);
        Task EliminarAsync(int id);
    }
}
