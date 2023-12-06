using Microsoft.Extensions.Options;

namespace recover_forest.Entidad
{
    public class VentaTamanho
    {
        public int id {  get; set; }
        public TipoTamanho Tamanho { get; set; }
        public decimal precio {  get; set; }
        public int ventaid { get; set; }
        public Venta venta { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
    }
}
