using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace mecânica
{
    public partial class NovoProduto : Form
    {
        clnUtil objClnUtil = new clnUtil();
        Produto1 ObjClnMecanica = new Produto1();
        public NovoProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if ((cboFornecedor.Text == "") || (cboMarca.Text == "") || (cboModelo.Text == "") || (txtProduto.Text == "") ||
               (txtAno.Text == "") || (txtvalor.Text == ""))
            {
                MessageBox.Show("Todos os campos são Obrigatorios", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ObjClnMecanica.FORNECERDOR = cboFornecedor.Text;
                ObjClnMecanica.MARCA = cboMarca.Text;
                ObjClnMecanica.MODELO = cboModelo.Text;
                ObjClnMecanica.PRODUTO = txtProduto.Text;
                ObjClnMecanica.Ano1 = txtAno.Text;
                ObjClnMecanica.VALOR = txtvalor.Text;
                
                if (txtCOD_Produto.Text == "")
                {
                    ObjClnMecanica.Gravar();
                    MessageBox.Show("Registo gravado com Sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtCOD_Produto.Text != "")
                {
                    
                    ObjClnMecanica.COD_Produto1 = txtCOD_Produto.Text;
                    ObjClnMecanica.Alterar();
                    MessageBox.Show("Registro Número " + txtCOD_Produto.Text + ", Alterado com sucesso", "alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Close();
            }
        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {
            PreencherFornecedor();
            PreencherMarca();
            txtCOD_Produto.Enabled = false;
            if (txtCOD_Produto.Text != "")
            {
                SqlDataReader ObjDrDados;
                ObjDrDados = ObjClnMecanica.LocalizarCodigo(txtCOD_Produto.Text);
                if (ObjDrDados.Read())
                {
                   cboFornecedor.Text= ObjDrDados["FORNECERDOR"].ToString();
                    txtProduto.Text = ObjDrDados["produto"].ToString();
                    cboMarca.Text = ObjDrDados["modelo"].ToString();
                    cboModelo.Text = ObjDrDados["marca"].ToString();
                    txtvalor.Text = ObjDrDados["valor"].ToString();
                    txtAno.Text = ObjDrDados["quantidade"].ToString();









                }
                txtProduto.Focus();

            }
        }

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }
        public void PreencherFornecedor()
        {
            cboFornecedor.DataSource = objClnUtil.PreencherFornecedor();
            cboFornecedor.ValueMember = "nome"; //Valor que pode ou não ser guardado
            cboFornecedor.DisplayMember = "nome"; //Valor apresentado
            cboFornecedor.SelectedIndex = -1;  //Deixar sem valor a combo use -1 ou o 23 é SP
        }
        public void PreencherMarca()
        {
            cboMarca.DataSource = objClnUtil.PreencherMarca();
            cboMarca.ValueMember = "MARCA"; //Valor que pode ou não ser guardado
            cboMarca.DisplayMember = "MARCA"; //Valor apresentado
            cboMarca.SelectedIndex = -1;  //Deixar sem valor a combo use -1 ou o 23 é SP
        }
        public void PreencherModelo()
        {
            cboModelo.DataSource = objClnUtil.PreencherModelo(cboMarca.Text);
            cboModelo.ValueMember = "MODELO"; //Valor que pode ou não ser guardado
            cboModelo.DisplayMember = "MODELO"; //Valor apresentado
            cboModelo.SelectedIndex = -1;  //Deixar sem valor a combo use -1 ou o 23 é SP
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           // PreencherFornecedor();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherModelo();
        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            txtAno.MaxLength = 14;
        }
    }
}
    

