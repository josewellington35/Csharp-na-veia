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
    public partial class Servico : Form
    {
        clnMaoObra objMecanica = new clnMaoObra();
        Cadastro_Servico_ ObjClientt = new Cadastro_Servico_();
        public Servico()
        {
            InitializeComponent();
        }

        private void Servico_Load(object sender, EventArgs e)
        {
          
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            DGV_1.RowHeadersVisible = false;
        }
        public void CarregarDataGrid()
        {
            DGV_1.DataSource = objMecanica.LocalizarPorNome(txtDescricao1.Text);
            DGV_1.Columns[0].HeaderText = ("CÓDIGO");
            DGV_1.AutoResizeColumns();


            if (DGV_1.RowCount == 0)
            {
             
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao1.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_1.DataSource = null;
                txtDescricao1.Text = "";
                txtDescricao1.Focus();
            }
            else
            {
              
                btnConsultar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cadastro_Servico_ ser = new Cadastro_Servico_();
            ser.ShowDialog();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
         

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cadastro_Servico_ ObjCliente = new Cadastro_Servico_();
            ObjCliente.Text = ">>> CONSULTAR<<<";
            ObjCliente.btnGravar.Visible = false;
          
            ObjCliente.txtNome.Enabled = false;
            ObjCliente.txtValor.Enabled = false;
 
           
            ObjCliente.txtCod.Enabled = false;


            ObjCliente.txtCod.Text = Convert.ToString(DGV_1.CurrentRow.Cells[0].Value);

            ObjCliente.ShowDialog();
            CarregarDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV_1.CurrentRow.Cells[0].Value + "?"),
                  "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_MaoObra1 = DGV_1.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cadastro_Servico_ objI = new Cadastro_Servico_();
            objI.Text = ">>> ALTERAR <<<";
            objI.txtCod.Enabled = false;
            objI.btnGravar.Text = "&Alterar";
            objI.txtCod.Text = Convert.ToString(DGV_1.CurrentRow.Cells[0].Value);
            objI.txtNome.Text = Convert.ToString(DGV_1.CurrentRow.Cells[1].Value);
            objI.txtValor.Text = Convert.ToString(DGV_1.CurrentRow.Cells[2].Value);
            objI.txtNome.Focus();
            objI.txtValor.Focus();

            objI.ShowDialog();
            CarregarDataGrid();


        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            Cadastro_Servico_ ObjCliente = new Cadastro_Servico_();
            ObjCliente.Text = ">>> CONSULTAR<<<";
            ObjCliente.btnGravar.Visible = false;

            ObjCliente.txtNome.Enabled = false;
            ObjCliente.txtValor.Enabled = false;


            ObjCliente.txtCod.Enabled = false;


            ObjCliente.txtCod.Text = Convert.ToString(DGV_1.CurrentRow.Cells[0].Value);
            ObjCliente.txtNome.Text = Convert.ToString(DGV_1.CurrentRow.Cells[1].Value);
            ObjCliente.txtValor.Text = Convert.ToString(DGV_1.CurrentRow.Cells[2].Value);
            ObjCliente.ShowDialog();
            CarregarDataGrid();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV_1.CurrentRow.Cells[0].Value + "?"),
                  "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_MaoObra1 = DGV_1.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            Cadastro_Servico_ ser = new Cadastro_Servico_();
            ser.ShowDialog();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
