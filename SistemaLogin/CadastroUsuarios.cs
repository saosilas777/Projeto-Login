using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Name = "Silas", Senha = "1987"},
            new Usuario(){Name = "Naiade", Senha = "1993"}
        };

        private static Usuario userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return userLogado; }
            private set { userLogado = value; }
        }

        public static bool Login(string name, string senha)
        {
            foreach(Usuario x in usuarios)
            {
                if(x.Name == name && x.Senha == senha)
                {
                    UsuarioLogado = x;
                    return true;
                }
            }
            
            return false;


        }
    }
}
