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
    internal class PurchaseOrder: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("userId")]
        public int userId {  get; set; }
        [ForeignKey("providerId")]
        public int providerId { get; set; }
        [ForeignKey("productId")]
        public int productId { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string comment { get; set; }
        public bool received { get; set; } = false;
        public User User { get; set; }
        public Provider Provider { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            return
                $"id: {id}, " +
                $"userId: {userId} " +
                $"productId: {productId}, " +
                $"providerId: {providerId}, " +
                $"quantity: {quantity}, " +
                $"price: {price} " +
                $"comment: {comment} " +
                $"createdAt: {createdAt} " +
                $"updatedAt: {updatedAt} ";
        }
    }
}
