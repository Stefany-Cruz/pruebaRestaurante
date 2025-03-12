using ProyectoIndustria.Domain.Entities;

namespace ProyectoIndustria.Domain.Repositories
{
    public interface IPagoRepository
    {
        Task<Pago> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Pago>> ObtenerTodosAsync();
        Task AgregarAsync(Pago pago);
        Task ActualizarAsync(Pago pago);
        Task EliminarAsync(int id);
    }
}
