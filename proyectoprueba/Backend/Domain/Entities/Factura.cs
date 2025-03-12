using ProyectoIndustria.Domain.Common;

namespace ProyectoIndustria.Domain.Entities
{
    public class Factura : BaseEntity
    {
        public int IdPago { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public decimal TotalPagar { get; set; }
        public string EstadoFactura { get; set; }
        public Pago Pago { get; set; }
    }
}
