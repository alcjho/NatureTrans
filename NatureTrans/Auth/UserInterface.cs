using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureTrans.Auth
{
    internal interface UserInterface
    {
        String username { get; set; }
        String email { get; set; }
        String password { get; set; }
        String salt_password { get; set; }
        String hash_password { get; set; }
    }
}
