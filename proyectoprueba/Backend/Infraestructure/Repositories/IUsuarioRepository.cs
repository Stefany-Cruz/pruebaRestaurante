using ProyectoIndustria.Domain.Entities;

namespace ProyectoIndustria.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Usuario>> ObtenerTodosAsync();
        Task AgregarAsync(Usuario usuario);
        Task ActualizarAsync(Usuario usuario);
        Task EliminarAsync(int id);
    }
}
