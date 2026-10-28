using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Gabriel", Senha = "abc123"},
            new Usuario(){Nome = "Lucas", Senha = "def456"},
            new Usuario(){Nome = "Maria", Senha = "ghi789"},
        };

        private static Usuario userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return userLogado; }
            private set { userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            
            return false;
        }
    }

    
}
