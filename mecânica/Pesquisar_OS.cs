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
    public partial class Pesquisar_OS : Form
    {
        Consulta_OS ObjCliente = new Consulta_OS();
        public Pesquisar_OS()
        {
            InitializeComponent();
        }
        ClnConsulta_os objMecanica = new ClnConsulta_os();
        public string  produto ,valor,hora,mao,valorMao;
        public double cont;
        private void btnConsultar_Click(object sender, EventArgs e)
        {    
     
          
            ObjCliente.Text = ">>> CONSULTAR<<<";
          
     
            ObjCliente.txtNome.Enabled = false;
           
            ObjCliente.txtTel.Enabled = false;
       
            ObjCliente.txtCod.Enabled = false;
           // ObjCliente.listBox1.Enabled = false;
            ObjCliente.maskValor.Enabled = false;

            DGV.Columns.Add("Produto/Serviço", "Produto/Serviço");

            DGV.Columns.Add("Valor", "Valor");

            //ObjCliente.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            //ObjCliente.txtNome.Text = Convert.ToString(DGV.CurrentRow.Cells[1].Value);
            //ObjCliente.txtTel.Text = Convert.ToString(DGV.CurrentRow.Cells[2].Value);
            //ObjCliente.maskValor.Text = Convert.ToString(DGV.CurrentRow.Cells[3].Value);

           
            ObjCliente.txtCod.Enabled = false;
            ObjCliente.txtNome.Enabled = false;
            ObjCliente.maskValor.Enabled = false;
            ObjCliente.txtTel.Enabled = false;
            ObjCliente.listBox1.Visible =  true;


            ObjCliente.txtCod.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);



           

           

                for ( cont = 0; cont < DGV.RowCount - 1; cont++)

                {
                while (cont != 1)
                {
                    //acessar linha por linha no DGV RowCount Rows[cont] RowCount
                    produto = produto + ";" + Convert.ToString(DGV.CurrentRow.Cells[5].Value.ToString());

                    valor = Convert.ToString(DGV.CurrentRow.Cells[4].Value.ToString());
                    cont++;
                }
                }
            
            hora  = Convert.ToString(DGV.CurrentRow.Cells[6].Value);

            mao = Convert.ToString(DGV.CurrentRow.Cells[7].Value);

            valorMao = Convert.ToString(DGV.CurrentRow.Cells[8].Value);

            //decimal a;
            //decimal.TryParse(ObjCliente.DGV.Text, out a);


            ObjCliente.produto_P = produto;
            ObjCliente.total = valor;
            ObjCliente.hora = hora;
            ObjCliente.maoOBRA = mao;
            ObjCliente.Valor_maoObra = valorMao;
          


            ObjCliente.ShowDialog();
           CarregarDataGrid();
            Close();
        }
      
        private void Pesquisar_OS_Load(object sender, EventArgs e)
        {
            btnConsultar.Enabled = false;
        
            btnExcluir.Enabled = false;
            DGV.RowHeadersVisible = false;
        }
        public void CarregarDataGrid()
        {
            DGV.DataSource = objMecanica.LocalizarPorNome(txtDescricao.Text);
            DGV.Columns[0].HeaderText = ("CÓDIGO");
            DGV.AutoResizeColumns();


            if (DGV.RowCount == 0)
            {

                btnConsultar.Enabled = false;
             
                btnExcluir.Enabled = false;

                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV.DataSource = null;
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }
            else
            {

                btnConsultar.Enabled = true;
               
                btnExcluir.Enabled = true;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro: " + Convert.ToString(DGV.CurrentRow.Cells[0].Value + "?"),
               "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == resultado)
            {
                objMecanica.Cod_os = DGV.CurrentRow.Cells[0].Value.ToString();
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
    }
}
