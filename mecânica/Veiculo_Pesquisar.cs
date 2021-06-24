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
    public partial class Veiculo_Pesquisar : Form
    {
        public Veiculo_Pesquisar()
        {
            InitializeComponent();
        }
        //public string leva_codigo;
        public string nome,cpf,telefone,codCliente;
        


        ClnVeiculo objMecanica = new ClnVeiculo();
          Ordem_de_Serviço ordem = new Ordem_de_Serviço();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgv.Rows[e.RowIndex].Cells[0].Value + "");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           nome = "";
           telefone = "";
           cpf = "";
           codCliente = "";

            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value + "?"),
                 "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_CLIENTE1 = dgv.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv.Rows[e.RowIndex];

            ordem.Placa = row.Cells[1].Value.ToString();
            ordem.Marca = row.Cells[2].Value.ToString();
            ordem.Modelo = row.Cells[3].Value.ToString();
            ordem.Cor = row.Cells[4].Value.ToString();
            ordem.nome = nome;
            ordem.CPF = cpf;
            ordem.telefone = telefone;
            ordem.CodigoC = codCliente;

            ordem.Show();
            this.Close();
        }

        public void CarregarDataGrid()
        {

            dgv.DataSource = objMecanica.LocalizarPorNome(txtCodigo_Cliente.Text);
            dgv.Columns[0].HeaderText = ("CÓDIGO");
            dgv.AutoResizeColumns();
        }
        private void Veiculo_Pesquisar_Load(object sender, EventArgs e)
        {
            txtCodigo_Cliente.Enabled = false;
            txtCodigo_Cliente.Text = codCliente;
            CarregarDataGrid();
        }
        //private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    //MessageBox.Show(dgv.Rows[e.RowIndex].Cells[0].Value + "");
        //    //DataGridViewRow row = this.dgv.Rows[e.RowIndex];
        //    //Ordem_de_Serviço ordem = new Ordem_de_Serviço();
        //    //ordem.Placa = row.Cells[1].Value.ToString();
        //    //ordem.Marca = row.Cells[2].Value.ToString();
        //    //ordem.Modelo = row.Cells[3].Value.ToString();
        //    //ordem.Cor = row.Cells[4].Value.ToString();
        //    //ordem.ShowDialog();
        //}
        private void txtCodigo_Cliente_TextChanged(object sender, EventArgs e)
        {
           // CarregarDataGrid();

           
        }
    }
}
