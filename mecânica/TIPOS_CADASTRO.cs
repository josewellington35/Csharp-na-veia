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
    public partial class TIPOS_CADASTRO : Form
    {
        public TIPOS_CADASTRO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Pesquisa_de_Clientes NewPcliente = new Pesquisa_de_Clientes();
            NewPcliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pesquisar_Fornecedor newPesquisar_fornecedor = new Pesquisar_Fornecedor();
            newPesquisar_fornecedor.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Pesquisar_Empresas NewPesquisar_E = new Pesquisar_Empresas();
           // NewPesquisar_E.ShowDialog();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            Pesquisar_Veícula New_chmarVeiculo = new Pesquisar_Veícula();
            New_chmarVeiculo.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            objFuncionario.ShowDialog();

        }
    }
}
