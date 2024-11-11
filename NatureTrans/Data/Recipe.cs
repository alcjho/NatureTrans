using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NatureTrans.Data.Product;

namespace NatureTrans.Data
{
    internal class Recipe: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public ICollection<Production> Productions { get; set; }

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