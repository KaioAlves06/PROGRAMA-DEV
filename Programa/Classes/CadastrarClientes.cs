using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Formularios;

namespace Programa.Classes
{
    internal class CadastrarClientes
    {
        public formCadastroClientes CAD; // Informando o formulário que está os objetos


        public CadastrarClientes(formCadastroClientes cAD) // Informando o formulário que está os objetos
        {
            CAD = cAD;
        }

        public void CadClientes()
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Conectarbanco.Cn))
                {
                    // Abrir conexão com o banco
                    cn.Open();

                    // Passando a tabela e as colunas do banco de dados -- Values coloca um nome com @
                    var sql = @"Insert into CLIENTES (TIPO,RAZAOSOCIAL,CNPJ,TELEFONE,CELULAR,
                    EMAIL,RUA,N,COMPLEMENTO,BAIRRO,CIDADE,CEP,UF,OBSERVACAO,DATACAD,ATIVO) 
                    VALUES (@TIPO,@RAZAOSOCIAL,@CNPJ,@TELEFONE,@CELULAR,
                    @EMAIL,@RUA,@N,@COMPLEMENTO,@BAIRRO,@CIDADE,@CEP,@UF,@OBSERVACAO,@DATACAD,@ATIVO)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        // Passando as tabelas e de onde ele irá substituir
                        cmd.Parameters.AddWithValue("@TIPO", CAD.cboTipo.Text);
                        cmd.Parameters.AddWithValue("@RAZAOSOCIAL", CAD.txtNome.Text);
                        cmd.Parameters.AddWithValue("@CNPJ", CAD.txtCpfeCnpj.Text);
                        cmd.Parameters.AddWithValue("@TELEFONE", CAD.mskTelefone.Text);
                        cmd.Parameters.AddWithValue("@CELULAR", CAD.mskCelular.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", CAD.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@RUA", CAD.txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@N", CAD.txtN.Text);
                        cmd.Parameters.AddWithValue("@COMPLEMENTO", CAD.txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@BAIRRO", CAD.txtBairro.Text);
                        cmd.Parameters.AddWithValue("@CIDADE", CAD.txtMunicipio.Text);
                        cmd.Parameters.AddWithValue("@CEP", CAD.mskCep.Text);
                        cmd.Parameters.AddWithValue("@UF", CAD.cboUf.Text);
                        cmd.Parameters.AddWithValue("@OBSERVACAO", CAD.txtObservacao.Text);
                        cmd.Parameters.AddWithValue("@DATACAD", DateTime.Now); // Colocar a data e hora atual
                        cmd.Parameters.AddWithValue("@ATIVO", "1");

                        cmd.ExecuteNonQuery();

                        cn.Close(); // Fechar conexão com o banco
                    }
                }
            }

            // caso tiver algum erro com a conexão do banco
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Cliente " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


    }

}
