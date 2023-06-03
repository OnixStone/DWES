using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenFinalDWES.Models
{
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioFinal { get; set; }
        public DateTime FechaCompra { get; set; }

        [ForeignKey("Usuarios")]
        [Key, Column(Order = 0)]
        public int UsuarioId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Productos")]
        public int ProductoId { get; set; }
    }
    
}
