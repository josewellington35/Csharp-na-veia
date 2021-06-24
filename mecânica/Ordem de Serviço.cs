using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace mecânica
{
    public partial class Ordem_de_Serviço : Form
    {
        //    Pservico objSer = new Pservico();
    public   decimal m = 0;
        ClnConsulta_os ObjClnMecanica = new ClnConsulta_os();
        Produto1 objMecanica = new Produto1();
        clnMaoObra se = new clnMaoObra();
        clnUtil objClnUtil = new clnUtil();
        public Ordem_de_Serviço()
        {
            InitializeComponent();
            DGV_2.Columns.Add("Codigo", "Codigo");
            DGV_2.Columns.Add("Produto/Serviço", "Produto/Serviço");
            DGV_2.Columns.Add("Modelo", "Modelo");
            DGV_2.Columns.Add("Valor", "Valor");
        }
        public string MAOOBRA;
        public string nome;
        public string telefone;
        public string CPF;
        public string CodigoC;
        public string Placa;
        public string Marca;
        public string Modelo;
        public string Cor;
        public string ModeloC;
        public string MarcaC;
        public string ValorC;
        public string ProdutoC;
        public string QuantidadeC;
        public string marcaC;
       
        Produto1 objProduto = new Produto1();

        public string compra;

        private void Ordem_de_Serviço_Load(object sender, EventArgs e)
        {
           
            PreencherMarca();




            txtCod_OS.Enabled = false;
            txtCodigoC.Enabled = false;
            servico = m;
            btnPagar.Enabled = false;
           
            btnExcluir.Enabled = false;
            txtTotalOS.Enabled = false;
        
            txtDescontoOS.Enabled = false;
            txtPecas.Enabled = false;
            
            //if(txtTotalOS.Text!= "")
            //{
            //    btnPagar.Enabled = true; 
                    
            //}
            //if (txtNome.Text == "")
            //{
            //    txtNome.Enabled = true;
            //}
            //else { txtNome.Enabled = false; }
            //    if (txtTel.Text == "")

            //    {
            //        if (txtCPF.Text == "")
            //        {



            //            txtNome.Enabled = true;
            //            txtTel.Enabled = true;
            //            txtCPF.Enabled = true;
            //        }
            //    }
            //}



            // preencher automatico
            txtNome.Text = nome;
            txtTel.Text = telefone;
            txtCPF.Text = CPF;
            txtCodigoC.Text = CodigoC;
            txtCor.Text = Cor;
            cboMarca.Text = Marca;
            cboModelo.Text = Modelo;
            txtPlaca.Text = Placa;
            txtCodigoC.Text = CodigoC;
            Veiculo_Pesquisar leva = new Veiculo_Pesquisar();
            //Ordem_de_Serviço oredem = new Ordem_de_Serviço();

            //txtCodigoC.Text = leva.codCliente ;
            // if (txtCodigoC.Text != "")
            // {
            //     leva.ShowDialog();
            //     txtCodigoC.Enabled = false;
            // }
          

        }
        //public void Preencherservico()
        //{
        //    jk.DataSource = objSer.Preencherservico();
        //    jk.ValueMember = "Servico";
        //    jk.DisplayMember = "Valor";
        //    jk.SelectedIndex = 23;




        public void CarregarDataGrid1()
            {
                DGV_1.DataSource = se.LocalizarPorNome(txtDescricao1.Text);
                DGV_1.Columns[0].HeaderText = ("CÓDIGO");
                DGV_1.AutoResizeColumns();
            }
        public void PreencherMarca()
        {
            cboMarca.DataSource = objClnUtil.PreencherMarca();
            cboMarca.ValueMember = "MARCA"; //Valor que pode ou não ser guardado
            cboMarca.DisplayMember = "MARCA"; //Valor apresentado
            cboMarca.SelectedIndex = -1;  //Deixar sem valor a combo use -1 ou o 23 é SP
        }
        public void PreencherModelo()
        {
            cboModelo.DataSource = objClnUtil.PreencherModelo(cboMarca.Text);
            cboModelo.ValueMember = "MODELO"; //Valor que pode ou não ser guardado
            cboModelo.DisplayMember = "MODELO"; //Valor apresentado
            cboModelo.SelectedIndex = -1;  //Deixar sem valor a combo use -1 ou o 23 é SP
        }
        public void CarregarDataGrid()
        {
            DGV.DataSource = objMecanica.LocalizarPorNome(txtDescricao.Text);
            DGV.Columns[0].HeaderText = ("CÓDIGO");
            DGV.AutoResizeColumns();
 //.......................>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            if (DGV.RowCount == 0)
            {

              
                //btnPagar.Enabled = false;
                //btnCompra.Enabled = false;

                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV.DataSource = null;
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }
            else
            {

                
                //btnPagar.Enabled = true;
                //btnCompra.Enabled = true;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSairOS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncho_Click(object sender, EventArgs e)
        {
            Guincho newGu = new Guincho();
            newGu.ShowDialog();

        }

        private void txtServicoOS_TextChanged(object sender, EventArgs e)
        {
           

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            //for (int cont = 0; cont < DGV_2.RowCount ; cont++)
            //    foreach (DataGridViewRow row in DGV_2.Rows)
            //    {
            //        produto = produto + row.Cells[1].Value.ToString();
            //        //produto = produto + Convert.ToString(produto);
            //    }
            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //    foreach (DataGridViewRow row in DGV_2.Rows)
            //    {
            //        valor = valor + row.Cells[3].Value.ToString();
            //        //valor = valor + Convert.ToString(valor);
            //    }
            Pagamento objPagamento = new Pagamento();
            objPagamento.nome = txtNome.Text;
            objPagamento.CPF = txtCPF.Text;
            objPagamento.codigo_os = txtCodigoC.Text;
            objPagamento.produto_P = produto;
            objPagamento.modelo = modelo;
            objPagamento.valor_P = valor;
            objPagamento.total = txtTotalOS.Text;
            objPagamento.ShowDialog();


            //esta jogando dados das celulas do dgv  nas variaveis 




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailOs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
         
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veiculo_Pesquisar p = new Veiculo_Pesquisar();
            p.ShowDialog();
        }
        public string codigo,produto,modelo, valor;
        private void DGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { 

            NovoProduto ObjClientt = new NovoProduto();

            DataGridViewRow row = this.DGV.Rows[e.RowIndex];

            //esta jogando dados das celulas do dgv  nas variaveis 

            codigo = row.Cells[0].Value.ToString();
            produto = row.Cells[1].Value.ToString();
            modelo= row.Cells[2].Value.ToString();
            valor =  row.Cells[3].Value.ToString();

            //DGV_2.Columns.Add("Codigo", "Codigo");
            //DGV_2.Columns.Add("Produto", "Produto");
            //DGV_2.Columns.Add("Modelo", "Modelo");
            //DGV_2.Columns.Add("Valor", "Valor");

            DGV_2.Rows.Add(codigo, produto, modelo, valor);


            

           
          double retira = 0;
            double qua = 0;

            //ObjClientt.Text = ">>> ALTERAR <<<";
            //ObjClientt.txtCOD_Produto.Enabled = false;
            //ObjClientt.btnGravar.Text = "&Alterar";
            //ObjClientt.txtCOD_Produto.Text = Convert.ToString(DGV.CurrentRow.Cells[0].Value);
            //ObjClientt.txtquantidade.Text = Convert.ToString(qua);
            //ObjClientt.txtquantidade.Focus();
           //retira =Convert.ToDouble(row.Cells["Quantidade"].Value );
       
           

            CarregarDataGrid();
            if (DGV_2.RowCount == 1)
            {


               // btnPagar.Enabled = false;
              
                btnExcluir.Enabled = false;
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DGV.DataSource = null;
                //txtDescricao.Text = "";
                //txtDescricao.Focus();
            }
            else
            {


               // btnPagar.Enabled = true;
              
                btnExcluir.Enabled = true;
            }
            //.......>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Compra
            btnPagar.Enabled = true;
            produto = string.Empty;
            for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            {//acessar linha por linha no DGV

                // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                produto = produto + ";" + Convert.ToString(DGV_2.Rows[cont].Cells[1].Value.ToString()) +
                   " R$ " + Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

            }
            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //{//acessar linha por linha no DGV

            //    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
            //    valor = valor +";"+ Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

            //}



            //double total = 0, servico = 0, desconto = 0, Subtotal = 0;
            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //    foreach (DataGridViewRow row in DGV_2.Rows)
            //    {
            //        Subtotal = Convert.ToDouble(valor);
            //    }

            for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            {//acessar linha por linha no DGV

                // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());

            }

            txtPecas.Text = Convert.ToString(Subtotal);
            decimal.TryParse(txtDescontoOS.Text, out desconto);
            // decimal.TryParse(txtServiço.Text, out servico);
            decimal.TryParse(txtPecas.Text, out peca);

           

           
            txtTotalOS.Text = ((servico + peca+m) - desconto).ToString();
           
            Subtotal = 0;
            m = 0;
            //servico = Convert.ToDouble(txtDescontoOS.Text);
            //desconto = Convert.ToDouble(txtServiço.Text);


            //txtTotalOS.Text = Convert.ToString(Subtotal);
            //Calcular valor do dgv

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>compra

        }
        private void dgv_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            //DataGridViewRow row = this.DGV.Rows[e.RowIndex];

            // //esta jogando dados das celulas do dgv  nas variaveis 
            // Objcompra.PRODUTO = row.Cells[1].Value.ToString();
            // Objcompra.MODELO = row.Cells[2].Value.ToString();
            // Objcompra.VALOR = row.Cells[3].Value.ToString();
            // Objcompra.QUANTIDADE = row.Cells[4].Value.ToString();
            // CarregarDataGridcompra();
            //Objcompra.Gravar();

        }
        string l_desconto, L_servico;
        double Subtotal;
       decimal servico, desconto, total, peca;
        private void btnCompra_Click(object sender, EventArgs e)
        {
            //btnPagar.Enabled = true;
            //produto = string.Empty;
            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //{//acessar linha por linha no DGV

            //    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
            //    produto = produto + ";" + Convert.ToString(DGV_2.Rows[cont].Cells[1].Value.ToString()) +
            //       " R$ " + Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

            //}
            ////for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            ////{//acessar linha por linha no DGV

            ////    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
            ////    valor = valor +";"+ Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

            ////}



            ////double total = 0, servico = 0, desconto = 0, Subtotal = 0;
            ////for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            ////    foreach (DataGridViewRow row in DGV_2.Rows)
            ////    {
            ////        Subtotal = Convert.ToDouble(valor);
            ////    }

            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //{//acessar linha por linha no DGV

            //    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
            //    Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());

            //}

            //txtPecas.Text = Convert.ToString(Subtotal);
            //decimal.TryParse(txtDescontoOS.Text, out desconto);
            //// decimal.TryParse(txtServiço.Text, out servico);
            //decimal.TryParse(txtPecas.Text, out peca);



            //txtTotalOS.Text = ((servico + peca) - desconto).ToString();
            //Subtotal = 0;

            ////servico = Convert.ToDouble(txtDescontoOS.Text);
            ////desconto = Convert.ToDouble(txtServiço.Text);


            ////txtTotalOS.Text = Convert.ToString(Subtotal);
            ////Calcular valor do dgv




        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Servico s = new Servico();
            //s.CarregarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //s.CarregarDataGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
            CarregarDataGrid1();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }
      //  public string cod, ser, valor1;
        private void DGV_1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             
      

            NovoProduto ObjClientt = new NovoProduto();

            DataGridViewRow row = this.DGV_1.Rows[e.RowIndex];

            //esta jogando dados das celulas do dgv  nas variaveis 

            codigo = row.Cells[0].Value.ToString();
            produto = row.Cells[1].Value.ToString();
            valor = row.Cells[2].Value.ToString();
            modelo = string.Empty;
            //DGV_2.Columns.Add("Codigo", "Codigo");
            //DGV_2.Columns.Add("Produto", "Produto");
            //DGV_2.Columns.Add("Modelo", "Modelo");
            //DGV_2.Columns.Add("Valor", "Valor");
          
           DGV_2.Rows.Add(codigo, produto, modelo, valor);
            if (DGV_2.RowCount == 1)
            {


                // btnPagar.Enabled = false;
               
                btnExcluir.Enabled = false;
                //MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMÇÃO" + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DGV.DataSource = null;
                //txtDescricao.Text = "";
                //txtDescricao.Focus();
            }
            else
            {


                // btnPagar.Enabled = true;
              
                btnExcluir.Enabled = true;
            }
            //.......>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Compra
            btnPagar.Enabled = true;
            produto = string.Empty;
            for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            {//acessar linha por linha no DGV

                // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                produto = produto + ";" + Convert.ToString(DGV_2.Rows[cont].Cells[1].Value.ToString()) +
                   " R$ " + Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

            }
            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //{//acessar linha por linha no DGV

            //    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
            //    valor = valor +";"+ Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

            //}



            //double total = 0, servico = 0, desconto = 0, Subtotal = 0;
            //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            //    foreach (DataGridViewRow row in DGV_2.Rows)
            //    {
            //        Subtotal = Convert.ToDouble(valor);
            //    }

            for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
            {//acessar linha por linha no DGV

                // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());

            }

            txtPecas.Text = Convert.ToString(Subtotal);
            decimal.TryParse(txtDescontoOS.Text, out desconto);
            // decimal.TryParse(txtServiço.Text, out servico);
            decimal.TryParse(txtPecas.Text, out peca);



            txtTotalOS.Text = ((servico + peca+m) - desconto).ToString();
            Subtotal = 0;
            m = 0;
            //servico = Convert.ToDouble(txtDescontoOS.Text);
            //desconto = Convert.ToDouble(txtServiço.Text);


            //txtTotalOS.Text = Convert.ToString(Subtotal);
            //Calcular valor do dgv

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>compra

        }

        private void txtPecas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") || (txtCPF.Text == "")||(cboModelo.Text =="")||(cboMarca.Text =="")||(txtPlaca.Text =="")||(txtCor.Text == ""))
            {
                MessageBox.Show("Os campos do cliente : Nome,CPF e  todos os campos de informações do veículo   são Obrigatórios", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
            else
            {
                Pagamento objPagamento = new Pagamento();
                objPagamento.nome = txtNome.Text;
                objPagamento.CPF = txtCPF.Text;
                objPagamento.codigo_os = txtCodigoC.Text;
                objPagamento.produto_P = produto;
                objPagamento.modelo = modelo;
                objPagamento.valor_P = valor;
                objPagamento.total = txtTotalOS.Text;
                objPagamento.telefone = txtTel.Text;
                objPagamento.MAODObra = MAOOBRA;
                objPagamento.M = m;
                objPagamento.ShowDialog();
            }
            //>>>>]
            if ((txtTotalOS.Text == ""))
            {
                MessageBox.Show("Os campos com * são Obrigatórios", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            //    ObjClnMecanica.Nome = txtNome.Text;
            //    ObjClnMecanica.Tel = txtTel.Text;
            //    ObjClnMecanica.Cpf = txtCPF.Text;
            //    ObjClnMecanica.Produto = produto;
            //    ObjClnMecanica.Total = txtTotalOS.Text;

               



            }


        }
        //>>>
    

        public void button1_Click_2(object sender, EventArgs e)

       {
            Pagamento p = new Pagamento();
            decimal a = 35;
            decimal cal = 0;
            decimal c = 100;
           

            decimal.TryParse(txtPecas.Text, out peca);
            cal = a * peca;

           m = ((cal)/c);
            //txtTotalOS.Text = (( m)).ToString();
            txtTotalOS.Text = ((servico + peca +m) - desconto).ToString();
            p.M = m;
            MAOOBRA = Convert.ToString("Mão de obra:  ");
            p.MAODObra = MAOOBRA;
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherModelo();
        }

        private void txtTotalOS_TextChanged(object sender, EventArgs e)
        {
          
            
           
        }

        private void txtDescontoOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { CarregarDataGrid(); }
        }
     

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DGV_2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // pega o index da linha selecioanada
                int index = DGV_2.CurrentRow.Index;

                // conforme o index, ele remove a linha do
                // datagridview
                DGV_2.Rows.RemoveAt(index);

                //........>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                btnPagar.Enabled = true;
                produto = string.Empty;
                for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
                {//acessar linha por linha no DGV

                    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                    produto = produto + ";" + Convert.ToString(DGV_2.Rows[cont].Cells[1].Value.ToString()) +
                       " R$ " + Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

                }
                //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
                //{//acessar linha por linha no DGV

                //    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                //    valor = valor +";"+ Convert.ToString(DGV_2.Rows[cont].Cells[3].Value.ToString());

                //}



                //double total = 0, servico = 0, desconto = 0, Subtotal = 0;
                //for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
                //    foreach (DataGridViewRow row in DGV_2.Rows)
                //    {
                //        Subtotal = Convert.ToDouble(valor);
                //    }

                for (int cont = 0; cont < DGV_2.RowCount - 1; cont++)
                {//acessar linha por linha no DGV

                    // Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());
                    Subtotal = Subtotal + Convert.ToDouble(DGV_2.Rows[cont].Cells[3].Value.ToString());

                }

                txtPecas.Text = Convert.ToString(Subtotal);
                decimal.TryParse(txtDescontoOS.Text, out desconto);
                // decimal.TryParse(txtServiço.Text, out servico);
                decimal.TryParse(txtPecas.Text, out peca);



                txtTotalOS.Text = ((servico + peca) - desconto).ToString();
                Subtotal = 0;
                //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


            }
            // caso a linha não esteje selecionada, ocorrerá um erro
            catch
            {
                MessageBox.Show("Selecione uma linha!",
                  "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
    }
