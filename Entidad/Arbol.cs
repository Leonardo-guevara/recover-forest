using System.ComponentModel.DataAnnotations;
using System.Drawing;
using NetTopologySuite.Geometries;
using Microsoft.EntityFrameworkCore;
using Point = NetTopologySuite.Geometries.Point;
using Entidades;

namespace recover_forest.Entidad
{
    public class Arbol
    {
        public int Id { get; set; }
        public string pocicion { get; set; }
        [StringLength(150), Required]
        public int  treeid { get; set; }
        public ICollection<Tree> Tree { get; } = new List<Tree>(); 
        public Point ubicacion { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
    }
}
