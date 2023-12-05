
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tree
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string porte { get; set; }
        public double altura { get; set; }
        public string nombre_cientifico { get; set; }
        public int familia {  get; set; }
        public int origen { get; set;}
        public int forma_copa { get; set; }
        public decimal diametro { get; set; }
        public int  flores { get;}
        public int raiz { get; set;}


    }
}
