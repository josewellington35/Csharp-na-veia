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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TIPOS_CADASTRO newtipos = new TIPOS_CADASTRO();
            newtipos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ordem_de_Serviço neworde = new Ordem_de_Serviço();
            neworde.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda objG = new Agenda();
            objG.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fromOrcamento objO = new fromOrcamento();
            objO.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Pesquisa_de_Clientes NewPcliente = new Pesquisa_de_Clientes();
            NewPcliente.ShowDialog();
        }

        private void clienteJuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_Fornecedor newPesquisar_fornecedor = new Pesquisar_Fornecedor();
            newPesquisar_fornecedor.ShowDialog();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_Veícula New_chmarVeiculo = new Pesquisar_Veícula();
            New_chmarVeiculo.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_funcionario_ f = new Pesquisar_funcionario_();
            f.ShowDialog();
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ordem_de_Serviço neworde = new Ordem_de_Serviço();
            neworde.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda objG = new Agenda();
            objG.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromOrcamento objO = new fromOrcamento();
            objO.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            s.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void oSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pesquisar_OS o = new Pesquisar_OS();
            o.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Pesquisar_OS o = new Pesquisar_OS();
            o.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Agenda objG = new Agenda();
            objG.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fromOrcamento objO = new fromOrcamento();
            objO.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            s.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Pesquisa_de_Clientes NewPcliente = new Pesquisa_de_Clientes();
            NewPcliente.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pesquisar_funcionario_ f = new Pesquisar_funcionario_();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pesquisar_Fornecedor newPesquisar_fornecedor = new Pesquisar_Fornecedor();
            newPesquisar_fornecedor.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Ordem_de_Serviço neworde = new Ordem_de_Serviço();
            neworde.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
