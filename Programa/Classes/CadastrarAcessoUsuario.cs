using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Formularios;

namespace Programa.Classes
{
    internal class CadastrarAcessoUsuario
    {
        public formCadastrarNovoAcessoUsuario CAD;
        public CadastrarAcessoUsuario(formCadastrarNovoAcessoUsuario cAD)
        {
            CAD = cAD;
        }

        public void CadastroUsuario()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conectarbanco.Cn))
                {
                    cn.Open();

                    var sql = @"insert into ACESSOS (USUARIO,SENHA)
                                             VALUES (@USER,@SENHA)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@USER", CAD.txtNomeUser.Text);
                        cmd.Parameters.AddWithValue("@SENHA", CAD.txtSenhaUser.Text);

                        cmd.ExecuteNonQuery();

                        cn.Close();

                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco" + ex.Message);
            }
        }
    }

}












