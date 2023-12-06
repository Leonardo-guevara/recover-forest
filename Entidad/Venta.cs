using NetTopologySuite.Geometries;

namespace recover_forest.Entidad
{
    public class Venta
    {
        public int Id { get; set; } 
        public int Nombre { get; set; }
        public Point ubicacion { get; set; }
        public DateTime? create_at { get; set; }
        public DateTime? update_at { get; set; }
        public DateTime? delete_at { get; set; }
        public VentaOferta VentaOferta { get; set; }
        public HashSet<VentaTamanho> ventatamanhos { get; set; }
    }
}
