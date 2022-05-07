using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GrupoUsuario
    {
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private List<Usuario> usuarios;

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }
        private List<Permissao> permissoes;

        public  List<Permissao> Permissoes
        {
            get { return permissoes; }
            set { permissoes = value; }
        }

    }
}
