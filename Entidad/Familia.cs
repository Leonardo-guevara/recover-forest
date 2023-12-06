using System.ComponentModel.DataAnnotations;

namespace recover_forest.Entidad
{
    public class Familia
    {
        [Key]
        public int id { get; set; }
        [StringLength(150), Required]
        public string name { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
    }
}
