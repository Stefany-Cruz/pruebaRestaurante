using ProyectoIndustria.Domain.Entities;

namespace ProyectoIndustria.Domain.Repositories
{
    public interface IFacturaRepository
    {
        Task<Factura> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Factura>> ObtenerTodosAsync();
        Task AgregarAsync(Factura factura);
        Task ActualizarAsync(Factura factura);
        Task EliminarAsync(int id);
    }
}
