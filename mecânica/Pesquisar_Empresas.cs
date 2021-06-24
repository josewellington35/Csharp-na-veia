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
    public partial class Pesquisar_Empresas : Form
    {
        ClnEmpresa objMecanica = new ClnEmpresa();
        public Pesquisar_Empresas()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Empresa objEmpresa = new Empresa();

            objEmpresa.Text = ">>> NOVO CADASTRO <<<";
            objEmpresa.txtCodEmpresa.Enabled = false;
            objEmpresa.ShowDialog();
            CarregarDataGrid();
        }
        public void CarregarDataGrid()
        {

            dgv.DataSource = objMecanica.LocalizarPorNome(txtDescricao.Text);
            dgv.Columns[0].HeaderText = ("CÓDIGO");
            dgv.AutoResizeColumns();


            if (dgv.RowCount == 0)
            {
                btnRelatorio.Enabled = false;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null;
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }
            else
            {
                btnRelatorio.Enabled = true;
                btnConsultar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            {
                Empresa objEmpresa = new Empresa();
                objEmpresa.Text = ">>> CONSULTAR<<<";
                objEmpresa.btnGravar.Visible = false;
                objEmpresa.txtBairro.Enabled = false;
                objEmpresa.txtCidade.Enabled = false;
                objEmpresa.txtCNPJ.Visible = false;
                objEmpresa.txtMaskCep.Enabled = false;
                objEmpresa.txtNome.Enabled = false;
                objEmpresa.txtNr.Enabled = false;
                objEmpresa.txtTel.Enabled = false;
                objEmpresa.cboUF.Enabled = false;

                objEmpresa.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
                objEmpresa.txtMaskCep.Enabled = false;

                objEmpresa.txtCodEmpresa.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);

                objEmpresa.ShowDialog();
                CarregarDataGrid();
            }
          

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Empresa objEmpresa = new Empresa();
            objEmpresa.Text = ">>> ALTERAR <<<";
            objEmpresa.txtCodEmpresa.Enabled = false;
            objEmpresa.btnGravar.Text = "&Alterar";
            objEmpresa.txtCodEmpresa.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            objEmpresa.txtNome.Focus();
            objEmpresa.ShowDialog();
            CarregarDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value + "?"),
               "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_Empresa1 = dgv.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void Pesquisar_Empresas_Load(object sender, EventArgs e)
        {
            btnRelatorio.Enabled = false;
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            dgv.RowHeadersVisible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
    }

