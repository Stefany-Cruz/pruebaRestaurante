using ProyectoIndustria.Domain.Common;

namespace ProyectoIndustria.Domain.Entities
{
    public class Rol : BaseEntity
    {
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }
    }
}
