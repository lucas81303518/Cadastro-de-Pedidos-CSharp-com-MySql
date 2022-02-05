﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cad_Cliente.Models
{
    public class Usuario
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
       
    }
}