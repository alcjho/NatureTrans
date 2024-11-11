using NatureTrans.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Data
{
    internal class RecipeIngredient: BaseEntity
    {
        public override string ToString()
        {
            var properties = this.GetType().GetProperties();
            var propertyValues = properties.Select(p =>
                p.GetValue(this)?.ToString() ?? "null"
            ).ToList();

            return string.Join(", ", propertyValues);
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int productId { get; set; }
        public int recipeId { get; set; }
        public Unit ingredient_unit {  get; set; }
        public double ingredient_qty { get; set; }
        public string? note { get; set; }

        public Recipe Recipe { get; set; }
    }
}
