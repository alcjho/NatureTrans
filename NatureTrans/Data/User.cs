using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NatureTrans.Data
{
    internal class User: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int roleId { get; set; }
        public bool isLogged { get; set; }
        public DateTime lastLogin { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string hashAlgo { get; set; }
        public string saltPassword { get; set; }
        [ForeignKey("roleId")]
        public Role Role { get; set; }
    }
}
