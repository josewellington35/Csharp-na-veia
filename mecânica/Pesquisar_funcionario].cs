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
    public partial class Pesquisar_funcionario_ : Form
    {
        clnFuncionario objMecanica = new clnFuncionario();
        public Pesquisar_funcionario_()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void Pesquisar_funcionario__Load(object sender, EventArgs e)
        {

          
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            DGV.RowHeadersVisible = false;




        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.ShowDialog();
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
                objMecanica.COD_FUNCIONARIO1 = DGV.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            Funcionario ObjCliente = new Funcionario();
            ObjCliente.Text = ">>> CONSULTAR<<<";
            ObjCliente.btnGravar.Visible = false;
            ObjCliente.txtBairro.Enabled = false;
            ObjCliente.txtCidade.Enabled = false;
            ObjCliente.txtCPF.Enabled = false;
            ObjCliente.txtMaskCep.Enabled = false;
            ObjCliente.txtEmail.Enabled = false;
            ObjCliente.txtDT_NASC.Enabled = false;
            ObjCliente.txtNome.Enabled = false;
            ObjCliente.txtNr.Enabled = false;
            ObjCliente.txtTel.Enabled = false;
            ObjCliente.cboUF.Enabled = false;
            ObjCliente.button1.Enabled = false;
           
            ObjCliente.txtEnd.Enabled = false;
            ObjCliente.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjCliente.txtCod.Enabled = false;
            ObjCliente.groupBox1.Enabled = false;
            ObjCliente.cboCargo.Enabled = false;



            ObjCliente.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);

            ObjCliente.ShowDialog();
            CarregarDataGrid();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Funcionario ObjClientt = new Funcionario();
            ObjClientt.Text = ">>> ALTERAR <<<";
            ObjClientt.txtCod.Enabled = false;
            ObjClientt.btnGravar.Text = "&Alterar";
            ObjClientt.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            ObjClientt.txtNome.Focus();
            ObjClientt.txtTel.Focus();
            ObjClientt.txtEnd.Focus();
            ObjClientt.txtNr.Focus();
            ObjClientt.txtDT_NASC.Focus();
            ObjClientt.txtCPF.Focus();
            ObjClientt.txtEmail.Focus();
            ObjClientt.txtBairro.Focus();
            ObjClientt.txtCidade.Focus();
            ObjClientt.txtMaskCep.Focus();
            ObjClientt.cboUF.Focus();
            ObjClientt.cboCargo.Focus();



            ObjClientt.ShowDialog();
            CarregarDataGrid();
        }
    }
}
