using NatureTrans.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.DTOs
{
    internal class ProductionDTO
    {
        public int id { get; set;}  
        public string name { get; set;}
        public string recipeName { get; set; }
        public double price { get; set; }
        public double prodQuantity { get; set; }
        public Unit prodUnit { get; set; } = Unit.cup;
        public string description { get; set; }
    }
}
