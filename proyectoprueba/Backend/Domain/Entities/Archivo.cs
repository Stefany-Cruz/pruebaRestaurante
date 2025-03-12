using ProyectoIndustria.Domain.Common;

namespace ProyectoIndustria.Domain.Entities
{
    public class Archivo : BaseEntity
    {
        public string NombreArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public DateTime FechaSubida { get; set; } = DateTime.Now;
        public string FuenteAlmacenamiento { get; set; }
        public string Metadatos { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
