using System.ComponentModel.DataAnnotations;

namespace recover_forest.Entidad
{
    public class VentaOferta
    {
        [Key]
        public int id {  get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafinal {  get; set; }
        public decimal porcentajedescuento { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public int ventaid { get; set; }

    }
}
