using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string nomeUsuario;
        private int senha;
        private bool ativo;

        
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public int Senha
        {
            get { return senha; }
            set { Senha = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { Ativo = value; }
        }

    }
}
