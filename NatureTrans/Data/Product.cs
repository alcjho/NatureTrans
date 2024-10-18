using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NatureTrans.Data
{
    internal class Product : BaseEntity
    {
        public Product()
        {
            prodState = ProdState.Good;
        }

        public override string ToString()
        {
            return $"id: {id}, categoryId: {categoryId} name: {name}, quantity: {quantity}, prodState: {prodState}, description: {description} ";
            //var properties = this.GetType().GetProperties();
            //var propertyValues = properties.Select(p => 
            //    p.Name != "Category"?$"{p.Name}: {p.GetValue(this)?.ToString() ?? "null"}":""
            //).ToList();

            //return string.Join(", ", propertyValues);
        }

        public enum ProdState
        {
            Good,
            Bad,
            Fair
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int categoryId { get; set; }
        public string? reference { get; set; } = string.Empty;
        public string name { get; set; }
        public int quantity { get; set; }
        public double? stock_value { get; set; }
        public ProdState? prodState { get; set; } 
        public string? description { get; set; }
        [ForeignKey("categoryId")]
        public Category Category { get; set; }
    }
}
