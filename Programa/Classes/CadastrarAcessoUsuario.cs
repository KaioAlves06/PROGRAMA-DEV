using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Formularios;

namespace Programa.Classes
{
    internal class CadastrarAcessoUsuario
    {
        public formCadastrarNovoAcessoUsuario cad;
        public CadastrarAcessoUsuario(formCadastrarNovoAcessoUsuario cad)
        {
            cad = cad;
        }

        public void CadastroUsuario()
        {
        try
            {
                using (SqlConnection cn = SqlConnection(Conectarbanco.Cn))


            }

}

}
}
