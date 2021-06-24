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
    public partial class Pesquisar_Veícula : Form
    {
        ClnVeiculo objMecanica = new ClnVeiculo();
        public Pesquisar_Veícula()
        {
            InitializeComponent();
        }
      
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Veículo objPesquisar_VI = new Veículo();
            objPesquisar_VI.Text = ">>> NOVO CADASTRO <<<";
            objPesquisar_VI.txtCodVEICULO.Enabled = false;
            objPesquisar_VI.ShowDialog();
            CarregarDataGrid();
            //objPesquisar_VI.txtCod_Cliente.Text = cvc;


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

        private void Pesquisar_Veícula_Load(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Veículo objPesquisar_VI = new Veículo();
            objPesquisar_VI.Text = ">>> CONSULTAR<<<";
            objPesquisar_VI.btnGravar.Visible = false;
            objPesquisar_VI.txtCor.Enabled = false;
            objPesquisar_VI.cboModelo.Enabled = false;
         
            objPesquisar_VI.cboMarca.Enabled = false;
            objPesquisar_VI.txtPlaca.Enabled = false;
           

           

            objPesquisar_VI.txtCodVEICULO.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);

            objPesquisar_VI.ShowDialog();
            CarregarDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Veículo objPesquisar_VI = new Veículo();
            objPesquisar_VI.Text = ">>> ALTERAR <<<";
            objPesquisar_VI.txtCodVEICULO.Enabled = false;
            objPesquisar_VI.btnGravar.Text = "&Alterar";
            objPesquisar_VI.txtCodVEICULO.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            objPesquisar_VI.txtPlaca.Focus();
            objPesquisar_VI.ShowDialog();
            CarregarDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
            "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_VEICULO1 = DGV.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

    

