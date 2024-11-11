using NatureTrans.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.DTOs
{
    internal class IngredientDTO
    {
        public int id { get; set; }
        public string Recette { get; set; }
        public string Ingredient { get; set; }
        public double Quantité { get; set; }
        public Unit Unité { get; set; }
        public string Note { get; set; }

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
