using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cad_Cliente.Models
{
    public class Admin : Usuario
    {
        public Admin(string login, string senha) : base(login, senha)
        {
        }
    }
}
