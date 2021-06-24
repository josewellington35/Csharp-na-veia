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
    public partial class fromOrcamento : Form
    {
        NovoProduto ObjCliente = new NovoProduto();
        Produto1 objMecanica = new Produto1();
        public fromOrcamento()
        {
            InitializeComponent();
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            DGV.RowHeadersVisible = false;
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
        public void CarregarDataGrid()
        {
            DGV.DataSource = objMecanica.LocalizarPorNome(txtDescricao.Text);
            DGV.Columns[0].HeaderText = ("CÓDIGO");
            DGV.AutoResizeColumns();


            if (DGV.RowCount == 0)
            {

                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV.DataSource = null;
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }
            else
            {

                btnConsultar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void itensVendaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoProduto objp = new NovoProduto();
            objp.ShowDialog();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(DGV.Rows[e.RowIndex].Cells[0].Value + "");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           NovoProduto ObjCliente = new NovoProduto();
            ObjCliente.Text = ">>>CONSULTAR<<<";
            ObjCliente.btnGravar.Visible = false;
           ObjCliente.cboFornecedor.Enabled = false;
         //   ObjCliente.txtFornecedor.Text = Convert.ToString(DGV.CurrentRow.Cells[4].Value);
            ObjCliente.txtProduto.Enabled = false;
            ObjCliente.cboModelo.Enabled = false;
            ObjCliente.cboMarca.Enabled = false;
           ObjCliente.txtvalor.Enabled = false;
           ObjCliente.txtAno.Enabled = false;






            ObjCliente.txtCOD_Produto.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);

            ObjCliente.ShowDialog();
            CarregarDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {


            NovoProduto ObjClientt = new NovoProduto();
            ObjClientt.Text = ">>>ALTERAR<<<";
            ObjClientt.txtCOD_Produto.Enabled = false;
            ObjClientt.btnGravar.Text = "&Alterar";
            ObjClientt.txtCOD_Produto.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
           // ObjCliente.txtFornecedor.Text = Convert.ToString(DGV.CurrentRow.Cells[4].Value);
           ObjClientt.cboFornecedor.Focus();
           
            ObjClientt.txtProduto.Focus();
            ObjClientt.cboMarca.Focus();
            ObjClientt.cboModelo.Focus();
            ObjClientt.txtvalor.Focus();
            ObjClientt.txtAno.Focus();

            ObjClientt.ShowDialog();
            CarregarDataGrid();
           
        }



    

        private void Pesquisa_de_Clientes_Load(object sender, EventArgs e)
        {
           
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            DGV.RowHeadersVisible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
                    "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == resultado)
                {
                    objMecanica.COD_Produto1 = DGV.CurrentRow.Cells[0].Value.ToString();
                    objMecanica.ExcluirLogicamente();
                    MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CarregarDataGrid();
            }
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void lbldescricao_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

