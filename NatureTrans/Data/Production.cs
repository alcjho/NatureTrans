using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NatureTrans.Data.Product;
using NatureTrans.Types;

namespace NatureTrans.Data
{
    internal class Production: BaseEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? recipeId { get; set; }
        public string name { get; set; }
        public double prod_quantity { get; set; } = 0;
        public Unit prod_unit { get; set; }
        public Phases prod_state { get; set; }
        public double price { get; set; }
        public double production_value { get; set; } = 0;
        public double stock_value { get; set; } = 0;
        public string? description { get; set; }
        [ForeignKey("receipeId")]
        public Recipe Recipe { get; set; }

        public override string ToString()
        {
            var properties = this.GetType().GetProperties();
            var propertyValues = properties.Select(p =>
                p.GetValue(this)?.ToString() ?? "null"
            ).ToList();

            return string.Join(", ", propertyValues);
        }
    }
}
