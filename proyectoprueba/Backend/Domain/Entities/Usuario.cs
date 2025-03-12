using ProyectoIndustria.Domain.Common;

namespace ProyectoIndustria.Domain.Entities
{
    public class Usuario : BaseEntity, IAggregateRoot
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Correo { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public Rol Rol { get; set; }
    }
}
