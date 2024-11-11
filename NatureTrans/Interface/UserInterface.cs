using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Interface
{
    internal interface UserInterface
    {
        string username { get; set; }
        string email { get; set; }
        string password { get; set; }
        string salt_password { get; set; }
        string hash_password { get; set; }
    }
}
