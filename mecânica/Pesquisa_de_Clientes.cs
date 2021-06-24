using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace mecânica
{
    public partial class Pesquisa_de_Clientes : Form
    { ClnCLIENTE objMecanica = new ClnCLIENTE();
        Ordem_de_Serviço OBJos = new Ordem_de_Serviço();
        Cliente objCliente = new Cliente();
        public Pesquisa_de_Clientes()
        {
            InitializeComponent();
        }
        Ordem_de_Serviço ordem = new Ordem_de_Serviço();
        Pesquisar_Veícula p = new Pesquisar_Veícula();
        Veiculo_Pesquisar vp = new Veiculo_Pesquisar();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cliente OBJCLIEN = new Cliente();
            OBJCLIEN.Text = ">>> NOVO CADASTRO <<<";
            OBJCLIEN.txtCod.Enabled = false;
            OBJCLIEN.ShowDialog();
            CarregarDataGrid();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
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
            private void btnExcluir_Click(object sender, EventArgs e)
            {
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
                    "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == resultado)
                {
                    objMecanica.COD_CLIENTE1 = DGV.CurrentRow.Cells[0].Value.ToString();
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

            private void btnAlterar_Click(object sender, EventArgs e)
            {
             Cliente ObjClientt = new Cliente();
            ObjClientt.Text = ">>> ALTERAR <<<";
            ObjClientt.txtCod.Enabled = false;
            ObjClientt.btnGravar.Text = "&Alterar";
            ObjClientt.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            ObjClientt.txtNome.Focus();
            ObjClientt.txtTel.Focus();
            ObjClientt.txtEnd.Focus();
            ObjClientt.txtNr.Focus();
            ObjClientt.txtDT_NASC.Focus();
            ObjClientt.maskValor.Focus();
            ObjClientt.txtEmail.Focus();
            ObjClientt.txtBairro.Focus();
            ObjClientt.txtCidade.Focus();
            ObjClientt.txtMaskCep.Focus();
            ObjClientt.cboUF.Focus();



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
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ///////////////Codigo Prof


            ////           MessageBox.Show(dgv.Rows[e.RowIndex].Cells[0].Value +  "");
            ////Passagem p = new Passagem();
            ////p.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            CarregarDataGrid();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cliente ObjClientt = new Cliente();
            ObjClientt.Text = ">>> ALTERAR <<<";
            ObjClientt.txtCod.Enabled = false;
            ObjClientt.btnGravar.Text = "&Alterar";
            ObjClientt.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            ObjClientt.txtNome.Focus();
            ObjClientt.txtTel.Focus();
            ObjClientt.txtEnd.Focus();
            ObjClientt.txtNr.Focus();
            ObjClientt.txtDT_NASC.Focus();
            ObjClientt.maskValor.Focus();
            ObjClientt.txtEmail.Focus();
            ObjClientt.txtBairro.Focus();
            ObjClientt.txtCidade.Focus();
            ObjClientt.txtMaskCep.Focus();
            ObjClientt.cboUF.Focus();



            ObjClientt.Show();
            CarregarDataGrid();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
                    "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.COD_CLIENTE1 = DGV.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();

        }

        private void dgv_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //esse método irá carregar os textbox com os dados do datagrid

            //   btnCadastrar.Visible = false; // desabilita o botão salvar
            //   btnAlterar.Visible = true; //habilitar o botão Alterar

            DataGridViewRow row = this.DGV.Rows[e.RowIndex]; // irá percorrer a grid
                                                             //AS LINHAS ABAIXO IRÃO CARREGAR OS DADOS DOS COMPONENTES A ESQUERA DO SINAL
                                                             //DE IGUAL COM OS VALORES DAS COLUNAS DO DATAGRID. OBS: A PRIMEIRA COLUNA É A ZERO.

          //  MessageBox.Show(dgv.Rows[e.RowIndex].Cells[0].Value + "");
            // Passagem p = new Passagem();
           

            //if (MessageBox.Show(("Cadastra um novo veículo para fazer o serviço ?"),"Veículo",
            //MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    MessageBox.Show("Sim?");
            //    Pesquisar_Veícula l = new Pesquisar_Veícula();
            //    Veículo j = new Veículo();
            //    j.cvc = row.Cells[0].Value.ToString();
            //    j.ShowDialog();
            //}
            // else{
            //    MessageBox.Show("Ir para Ordem de serviço");
                
            //   vp.nome = row.Cells[1].Value.ToString();
            //    vp.telefone = row.Cells[2].Value.ToString();
            //    vp.cpf = row.Cells[3].Value.ToString();
            //   vp.codCliente = row.Cells[0].Value.ToString();

            //    vp.Show();
            //}



            
            //pessoa.cod_cadastro = Convert.ToInt32(row.Cells[0].Value.ToString());
           
            
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { CarregarDataGrid(); }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            Cliente ObjCliente = new Cliente();
            ObjCliente.Text = ">>> CONSULTAR<<<";
            ObjCliente.btnGravar.Visible = false;
            ObjCliente.txtBairro.Enabled = false;
            ObjCliente.txtCidade.Enabled = false;
            ObjCliente.maskValor.Enabled = false;
            ObjCliente.txtMaskCep.Enabled = false;
            ObjCliente.txtEmail.Enabled = false;
            ObjCliente.txtDT_NASC.Enabled = false;
            ObjCliente.txtNome.Enabled = false;
            ObjCliente.txtNr.Enabled = false;
            ObjCliente.txtTel.Enabled = false;
            ObjCliente.cboUF.Enabled = false;
            ObjCliente.rdbMasculino.Enabled = false;
            ObjCliente.rdbFeminino.Enabled = false;
            ObjCliente.txtEnd.Enabled = false;
            ObjCliente.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjCliente.txtCod.Enabled = false;


            ObjCliente.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);

            ObjCliente.ShowDialog();
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
                objMecanica.COD_CLIENTE1 = DGV.CurrentRow.Cells[0].Value.ToString();
                objMecanica.ExcluirLogicamente();
                MessageBox.Show("Registro excuido com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada ", "cancelamento E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarDataGrid();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Cliente ObjClientt = new Cliente();
            ObjClientt.Text = ">>> ALTERAR <<<";
            ObjClientt.txtCod.Enabled = false;
            ObjClientt.btnGravar.Text = "&Alterar";
            ObjClientt.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            ObjClientt.txtNome.Focus();
            ObjClientt.txtTel.Focus();
            ObjClientt.txtEnd.Focus();
            ObjClientt.txtNr.Focus();
            ObjClientt.txtDT_NASC.Focus();
            ObjClientt.maskValor.Focus();
            ObjClientt.txtEmail.Focus();
            ObjClientt.txtBairro.Focus();
            ObjClientt.txtCidade.Focus();
            ObjClientt.txtMaskCep.Focus();
            ObjClientt.cboUF.Focus();



            ObjClientt.ShowDialog();
            CarregarDataGrid();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            Cliente OBJCLIEN = new Cliente();
            OBJCLIEN.Text = ">>> NOVO CADASTRO <<<";
            OBJCLIEN.txtCod.Enabled = false;
            OBJCLIEN.ShowDialog();
            CarregarDataGrid();
        }

        private void DGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //esse método irá carregar os textbox com os dados do datagrid

            //   btnCadastrar.Visible = false; // desabilita o botão salvar
            //   btnAlterar.Visible = true; //habilitar o botão Alterar

            DataGridViewRow row = this.DGV.Rows[e.RowIndex]; // irá percorrer a grid
                                                             //AS LINHAS ABAIXO IRÃO CARREGAR OS DADOS DOS COMPONENTES A ESQUERA DO SINAL
                                                             //DE IGUAL COM OS VALORES DAS COLUNAS DO DATAGRID. OBS: A PRIMEIRA COLUNA É A ZERO.

            //  MessageBox.Show(dgv.Rows[e.RowIndex].Cells[0].Value + "");
            // Passagem p = new Passagem();


            if (MessageBox.Show(("Cadastra um novo veículo para fazer o serviço ?,"), "Veículo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sim?");
                Pesquisar_Veícula l = new Pesquisar_Veícula();
                Veículo j = new Veículo();
                j.cvc = row.Cells[0].Value.ToString();
                j.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ir para Ordem de serviço");

                vp.nome = row.Cells[1].Value.ToString();
                vp.telefone = row.Cells[2].Value.ToString();
                vp.cpf = row.Cells[3].Value.ToString();
                vp.codCliente = row.Cells[0].Value.ToString();

                vp.Show();
                if (vp is Veiculo_Pesquisar)
                {
                    vp = new Veiculo_Pesquisar();
                }
                else if (vp is Pesquisa_de_Clientes)
                {
                    vp = new Veiculo_Pesquisar();
                }

             
            }

        }

        private void DGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

