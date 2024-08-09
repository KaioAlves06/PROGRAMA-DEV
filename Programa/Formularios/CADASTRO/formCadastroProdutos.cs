using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Classes;

namespace Programa.Formularios.CADASTRO
{
    public partial class formCadastroProdutos : Form
    {
        public formCadastroProdutos()
        {
            InitializeComponent();
        }

        private void mskCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCodFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Informe o cod do Fornecedor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cboFornecedor.Text == "" || cboFornecedor.Text == "Selecione")
            {
                MessageBox.Show("Informe o Fornecedor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição do produto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cboCategoria.Text == "" || cboFornecedor.Text == "Selecione")
            {
                MessageBox.Show("Informe a categoria do Produto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (mskPrecoCompra.Text.Trim() == "")
            {
                MessageBox.Show("Informe o valor de Compra do Produto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // if (txtMargem.Text.Trim() == "")
            {
                MessageBox.Show("Informe a margem de Lucro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (mskPrecoVenda.Text.Trim() == "")
            {
                MessageBox.Show("Informe o valor de Venda do Produto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conectarbanco.Cn))
                {
                    cn.Open();

                    var sql = @"Insert into PRODUTOS(COD_FORNECEDOR,FORNECEDOR,DESCRICAO,CATEGORIA,
                                PRECO_COMPRA,MARGEM,PRECO_VENDA,ESTOQUE_MIN)
                                VALUES (@CODFORN,@FORNECEDOR,@DESCRICAO,@CATEGORIA,@COMPRA,
                                @VENDA,@ESTOQUEM)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@CODFORN", txtCodFornecedor.Text.Trim());
                        cmd.Parameters.AddWithValue("@FORNECEDOR", cboFornecedor.Text.Trim());
                        cmd.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text.Trim());
                        cmd.Parameters.AddWithValue("@CATEGORIA", cboCategoria.Text.Trim());
                        cmd.Parameters.AddWithValue("@COMPRA", mskPrecoCompra.Text.Trim());
                        cmd.Parameters.AddWithValue("@VENDA", mskPrecoVenda.Text.Trim());
                        cmd.Parameters.AddWithValue("@ESTOQUEM", txtEstoqueMin.Text.Trim());

                        cmd.ExecuteNonQuery();

                        cn.Close();

                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Cliente " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show("Produto cadastrado com Sucesso", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Deixando os campos em branco após o cadastro
            txtCodFornecedor.Text = "";
            cboFornecedor.Text = "Selecione";
            txtDescricao.Text = "";
            cboCategoria.Text = "Selecione";
            mskPrecoCompra.Text = "";
            mskPrecoVenda.Text = "";
            txtEstoqueMin.Text = "";



        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodFornecedor.Text = "";
            cboFornecedor.Text = "Selecione";
            cboCategoria.Text = "Selecione";
            txtDescricao.Text = "";
            mskPrecoCompra.Text = "";
            mskPrecoVenda.Text = "";
            txtEstoqueMin.Text = "";

        }
    }
}
