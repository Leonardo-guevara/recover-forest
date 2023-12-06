
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using recover_forest.Entidad;

namespace Entidades
{
    public class Tree
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string fotografia { get; set; }
        public int? porte { get; set; }
        public double? altura { get; set; }
        public string nombre_cientifico { get; set; }
        public int? familia {  get; set; }
        public int? origen { get; set;}
        public int? forma_copa { get; set; }
        public double? diametro { get; set; }
        public int?  flores { get;}
        public int? raiz { get; set;}
        public int? genero { get; set; }
        public DateTime? create_at { get; set;}
        public DateTime? update_at { get; set;}
        public DateTime? delete_at { get; set;}


    }
}
