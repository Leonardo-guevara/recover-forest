using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace recover_forest.Entidad
{
    
    public class Copa
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
