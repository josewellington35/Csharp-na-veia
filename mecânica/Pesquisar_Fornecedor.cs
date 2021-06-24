using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mecânica
{

    public partial class Pesquisar_Fornecedor : Form
    {
        ClnFornecedor objMecanica = new ClnFornecedor();
        public Pesquisar_Fornecedor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            Fornecedor OBJfornecedor = new Fornecedor();
            OBJfornecedor.Text = ">>> NOVO CADASTRO <<<";
            OBJfornecedor.txtCodFORNECEDOR.Enabled = false;
            OBJfornecedor.ShowDialog();
            CarregarDataGrid();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Fornecedor OBJfornecedor = new Fornecedor();
            OBJfornecedor.Text = ">>> CONSULTAR<<<";
            OBJfornecedor.btnGravar.Visible = false;
            OBJfornecedor.txtBairro.Enabled = false;
            OBJfornecedor.txtCidade.Enabled = false;
           // OBJfornecedor.maskedTextBox1.Visible = false;
            OBJfornecedor.txtMaskCep.Enabled = false;
            OBJfornecedor.txtNome.Enabled = false;
            OBJfornecedor.txtNr.Enabled = false;
            OBJfornecedor.txtTel.Enabled = false;
            OBJfornecedor.cboUF.Enabled = false;

            OBJfornecedor.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            OBJfornecedor.txtMaskCep.Enabled = false;

            OBJfornecedor.txtCodFORNECEDOR.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);

            OBJfornecedor.ShowDialog();
            CarregarDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Fornecedor OBJfornecedor = new Fornecedor();
            OBJfornecedor.Text = ">>> ALTERAR <<<";
            OBJfornecedor.txtCodFORNECEDOR.Enabled = false;
            OBJfornecedor.btnGravar.Text = "&Alterar";
            OBJfornecedor.txtCodFORNECEDOR.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            OBJfornecedor.txtNome.Focus();
            OBJfornecedor.ShowDialog();
            CarregarDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
              "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_Fornecedor1 = DGV.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void Pesquisar_Fornecedor_Load(object sender, EventArgs e)
        {
           
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            DGV.RowHeadersVisible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            Fornecedor OBJfornecedor = new Fornecedor();
            OBJfornecedor.Text = ">>> CONSULTAR<<<";
            OBJfornecedor.btnGravar.Visible = false;
            OBJfornecedor.txtBairro.Enabled = false;
            OBJfornecedor.txtCidade.Enabled = false;
           // OBJfornecedor.maskedTextBox1.Enabled = false;
            OBJfornecedor.txtMaskCep.Enabled = false;
            OBJfornecedor.txtNome.Enabled = false;
            OBJfornecedor.txtNr.Enabled = false;
            OBJfornecedor.txtTel.Enabled = false;
            OBJfornecedor.cboUF.Enabled = false;
         //   OBJfornecedor.maskedTextBox1.Enabled = false;
            OBJfornecedor.txtEmail.Enabled = false;
          //  OBJfornecedor.txtProduto.Enabled = false;
            OBJfornecedor.txtEnd.Enabled = false;
            OBJfornecedor.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            OBJfornecedor.txtMaskCep.Enabled = false;

            OBJfornecedor.txtCodFORNECEDOR.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
          //  OBJfornecedor.maskedTextBox1.Text = Convert.ToString(DGV.CurrentRow.Cells[3].Value);
            OBJfornecedor.txtEmail.Text = Convert.ToString(DGV.CurrentRow.Cells[3].Value);
          //  OBJfornecedor.txtProduto.Text = Convert.ToString(DGV.CurrentRow.Cells[5].Value);

            OBJfornecedor.ShowDialog();
            CarregarDataGrid();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Fornecedor OBJfornecedor = new Fornecedor();
            OBJfornecedor.Text = ">>> ALTERAR <<<";
            OBJfornecedor.txtCodFORNECEDOR.Enabled = false;
            OBJfornecedor.btnGravar.Text = "&Alterar";
            OBJfornecedor.txtCodFORNECEDOR.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            OBJfornecedor.txtNome.Focus();
            OBJfornecedor.txtEmail.Focus();
          //  OBJfornecedor.maskedTextBox1.Focus();
          //  OBJfornecedor.txtProduto.Focus();
           
            OBJfornecedor.txtEmail.Text = Convert.ToString(DGV.CurrentRow.Cells[3].Value);
            // OBJfornecedor.txtProduto.Text = Convert.ToString(DGV.CurrentRow.Cells[5].Value);
            OBJfornecedor.ShowDialog();
            CarregarDataGrid();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            Fornecedor OBJfornecedor = new Fornecedor();
            OBJfornecedor.Text = ">>> NOVO CADASTRO <<<";
            OBJfornecedor.txtCodFORNECEDOR.Enabled = false;
            OBJfornecedor.ShowDialog();
            CarregarDataGrid();
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
            "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_Fornecedor1 = DGV.CurrentRow.Cells[0].Value.ToString();
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
}
