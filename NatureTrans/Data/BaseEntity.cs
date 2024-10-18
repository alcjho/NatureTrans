using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Data
{
    public abstract class BaseEntity
    {
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        protected BaseEntity()
        {
            createdAt = DateTime.Now;
            updatedAt = DateTime.Now;
        }
    }
}
