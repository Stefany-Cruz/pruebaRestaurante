using ProyectoIndustria.Domain.Common;

namespace ProyectoIndustria.Domain.Entities
{
	public class Pago : BaseEntity
	{
		public int IdUsuario { get; set; }
		public int MetodoPago { get; set; }
		public decimal Monto { get; set; }
		public string Estado { get; set; }
		public DateTime FechaPago { get; set; } = DateTime.Now;
		public Usuario Usuario { get; set; }
		public MetodoPago MetodoPagoObj { get; set; }
	}
}
