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
using System.IO;

namespace mecânica
{
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }
        ClnConsulta_os ObjClnCOnsulta = new ClnConsulta_os();
        ClnCLIENTE objMecanica = new ClnCLIENTE();
        decimal dtotal, ddebito, dcredito, ddinheiro,calt;
        public string nome,hora,MAODObra, telefone, CPF, produto, txtTotalOS, codigo_os, produto_P, valor_P, modelo, total, itendecp,dinheiro,debito,credito,lblAp;
        public decimal M;
        private void Pagamento_Load(object sender, EventArgs e)
        {
            



            comboBox1.Visible = false;
            if (cbkCredito.Checked)
            { comboBox1.Visible = true; }

                txtATPGAR.Enabled = false;
                txtParcela.Enabled = false;
                //if (txtPagar.Text == "")
                //{
                //    btnPagar1.Enabled = false;
                //}
                //else
                //{
                //  btnPagar1.Enabled = true;
                //}
                btnAdd.Enabled = false;
                if (txtPagar.Text == "0")
                {
                    btnAdd.Enabled = true;
                }
                if (listBox1.Text == "")
                {
                    btnPrintNF.Enabled = false;
                }
                else
                {
                    btnPrintNF.Enabled = true;
                }

                txtPagar.Enabled = false;

                label7.Visible = false;
                txtParcela.Visible = false;
                comboBox1.Visible = false;

                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
                comboBox1.Items.Add("8");
                comboBox1.Items.Add("9");
                comboBox1.Items.Add("10");
                comboBox1.Items.Add("11");
                comboBox1.Items.Add("12");
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;


                label8.Visible = false;
                cbkDebito.Visible = false;
                cbkCredito.Visible = false;
                txtTotal.Text = total;
                txtATPGAR.Text = total;
                txtPagar.Enabled = false;
                txtTotal.Enabled = false;



                }
        
        public void CarregarDataGrid()
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnPrintNF.Enabled = true;
            Ordem_de_Serviço O = new Ordem_de_Serviço();
            DateTime HORA = DateTime.Now;
            
            ObjClnCOnsulta.Nome = nome;
            ObjClnCOnsulta.Tel = telefone;
            ObjClnCOnsulta.Cpf = CPF;
            ObjClnCOnsulta.Produto = produto_P;
            ObjClnCOnsulta.Total = total;
            ObjClnCOnsulta.Hora1 = Convert.ToString(HORA);
            ObjClnCOnsulta.MaoOBRA = MAODObra;
            ObjClnCOnsulta.Valor_maoobra = Convert.ToString(M);
            ObjClnCOnsulta.Gravar();
            //if (ObjClnCOnsulta.Nome == "")
            //{
            //    MessageBox.Show("oi");
               


            //    MessageBox.Show("Registo gravado com Sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else if (ObjClnCOnsulta.Nome != "")
            //{
            //    ObjClnCOnsulta.Cod_os = txtCod_OS.Text;

            //    MessageBox.Show("Registro Número " + txtCod_OS.Text + ", Alterado com sucesso", "alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}

            listBox1.Items.Add("                                               NOTA FISCAL NÚMERO:  " +
             codigo_os); 
            listBox1.Items.Add("Nome do cliente:  "  +nome);
            listBox1.Items.Add("CPF do cliente:  " + CPF);
            listBox1.Items.Add(" "+MAODObra+M);
            listBox1.Items.Add("                          ");
            rodape();

            //produto_P = "";
            //produto = "";
            //nome = "";
            //CPF = "";
            //codigo_os = "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
           
          

        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

           



            if (cbkdinheiro.Checked)
            {
                comboBox1.Visible = false;
                chkCartao.Checked = false;
                chkCartao.Select();

            }
            else { cbkdinheiro.Select(); }
            txtPagar.Enabled = true;
        }

        private void cbkDebito_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            if (cbkDebito.Checked )
            {

                comboBox1.Visible = false;
                cbkCredito.Checked = false; 
               
                
            }
            else { cbkCredito.Select(); }
            txtPagar.Enabled = true;
        }
        
        private void chkCartao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkdinheiro.Checked)
            {


                cbkdinheiro.Select();

            }
            else
            {
                chkCartao.Select();
            }
            if (chkCartao.Checked)
            {
                cbkCredito.Visible = true;
                cbkDebito.Visible = true;
                cbkdinheiro.Checked = false;
            }
            else
            {
                cbkDebito.Visible = false;
                cbkCredito.Visible = false;
            }
            
        }

        private void cbkCredito_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbkCredito.Checked)
            {
                cbkDebito.Checked = false;
                comboBox1.Visible = true;
                cbkCredito.Select();
              
            }
            else { cbkDebito.Select(); comboBox1.Visible = false; }
            label7.Visible = true;
            txtParcela.Visible = true;
           

            txtPagar.Enabled = false;
           // btnPagar.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           /* double valorTotal, numeroParcela;
            double.TryParse(txtATPGAR.Text, out valorTotal);
           // double.TryParse(numericUpDown1.Text, out numeroParcela);
            double valorParcela;
            valorParcela = ((valorTotal) / numeroParcela);
           
            txtParcela.Text = "R$" + valorParcela; */



          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      

            double numeroP = System.Convert.ToDouble(comboBox1.Text);
            double valort = System.Convert.ToDouble(txtATPGAR.Text);
            double valorP = valort / numeroP;
            txtParcela.Text ="" + valort / numeroP;

            double t =  System.Convert.ToDouble(txtParcela.Text);
            //essa variavel "t" faz a multiplicação do valor, não apague ela
            txtPagar.Text =""+ t * numeroP;
            //double j = System.Convert.ToDouble(txtATPGAR.Text);
            //double k = System.Convert.ToDouble(txtPagar.Text);
            //txtATPGAR.Text = ((j) - k).ToString();
            //credito = txtParcela.Text;
            //txtPagar.Text = credito;
           // txtPagar.Text = "";

            label6.Visible = true;
            decimal.TryParse(lblCredito.Text, out dcredito);
         //  txtATPGAR.Text = ((dtotal) - dcredito).ToString();
            //cbkCredito.Enabled = false;
            //cbkCredito.Checked = false;


        }

        private void txtParcela_TextChanged(object sender, EventArgs e)
        {
            txtParcela.MaxLength = 7;
        }

        private void io_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPagar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtATPGAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57)) || (e.KeyChar == 8))
            {
                e.Handled = false; //Permite
            }
            else
            {
                e.Handled = true; //Não permite
            }
        }

        private void txtATPGAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 48) && (e.KeyChar <= 57)) || (e.KeyChar == 8))
            {
                e.Handled = false; //Permite
            }
            else
            {
                e.Handled = true; //Não permite
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal util;
            label8.Enabled = true;
            decimal.TryParse(txtATPGAR.Text, out util);
        //    util =Convert.ToDecimal( txtPagar.Text);
            if (util == 0)
            {
                btnAdd.Enabled = true;
                comboBox1.Enabled = false;
            }
            if (util < 0)
            {
                util = Math.Abs(-util);
                label9.Text = Convert.ToString(util);
                label8.Visible = true;
                txtATPGAR.Text = "";
                txtPagar.Enabled = false;

                btnAdd.Enabled = true;
            }
            //decimal ul;

            //decimal.TryParse(txtATPGAR.Text, out ul);

            //if (ul > 0)
            //{

            //    label9.Text = Convert.ToString(ul);
            //}
            //if (txtPagar.Text == "")
            //{
            //    btnPagar1.Enabled = true;
            //}
            int i = 0;

            // decimal.TryParse(lblCredito.Text, out dcredito);
            //decimal.TryParse(lblDebito.Text, out ddebito);
            //decimal.TryParse(lblDinheiro.Text, out ddinheiro);
            decimal.TryParse(txtATPGAR.Text, out dtotal);
            cbkdinheiro.Select();

            
            

                //txtATPGAR.Text =  ((dcredito + ddebito + ddinheiro ) - dtotal).ToString();

                if (cbkdinheiro.Checked)
                {


                    dinheiro = txtPagar.Text;
                    lblDinheiro.Text = dinheiro;
                    txtPagar.Text = "";
                    label4.Visible = true;
                    decimal.TryParse(lblDinheiro.Text, out ddinheiro);
                    txtATPGAR.Text = ((dtotal) - ddinheiro).ToString();
                    cbkdinheiro.Enabled = false;
                    cbkdinheiro.Checked = false;

            }
            if (cbkDebito.Checked)
                {

                    debito = txtPagar.Text;
                    lblDebito.Text = debito;
                    txtPagar.Text = "";


                    label5.Visible = true;
                    decimal.TryParse(lblDebito.Text, out ddebito);
                txtATPGAR.Text = ((dtotal) - ddebito).ToString();
                cbkDebito.Enabled = false;
                cbkDebito.Checked = false;
                }
                if (cbkCredito.Checked)
                {

                    credito = txtPagar.Text;
                    lblCredito.Text = credito;
                    txtPagar.Text = "";

                    label6.Visible = true;
                    decimal.TryParse(lblCredito.Text, out dcredito);

                txtATPGAR.Text = ((dtotal) - dcredito).ToString();
                cbkCredito.Enabled = false;
                cbkCredito.Checked = false;
              //  txtATPGAR.Text = ((dtotal) - dcredito).ToString();

            }
                //lblAPagar.Text = lblAp - credito;
                //for (int cont = 0; cont != dtotal;)


                //txtATPGAR.Text = ((dcredito + ddebito + ddinheiro) - dtotal).ToString();
                //txtATPGAR.Text = ((dtotal)-ddinheiro).ToString();
                //txtATPGAR.Text = ((dtotal) - ddebito).ToString();
                //txtATPGAR.Text = ((dtotal) - dcredito).ToString();

                decimal.TryParse(txtATPGAR.Text, out dtotal);
            if (dtotal == i)
            {
                txtPagar.Enabled = false;
                chkCartao.Visible = false;
                
                   
            }
            if (txtATPGAR.Text == "")
            {
                label7.Visible = false;
                txtParcela.Visible = false;
                comboBox1.Visible = false;
                txtPagar.Enabled = false;
                //btnPagar1.Enabled = false;
                cbkCredito.Visible = false;
                cbkDebito.Visible = false;
                cbkdinheiro.Enabled = false;
                chkCartao.Enabled = false;



            }


        }

        private void lblDinheiro_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            
        }

        private void lblAPagar_Click(object sender, EventArgs e)
        {   
          
        }

        private void rdbdebito_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkBoxDinheiro_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPrintNF_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\ImprimirNF.html";///Caminho gravação
            string unirTudo = cabecalhoHTML2() + RetornaListBox() + rodapeHTML();
            File.WriteAllText(path,unirTudo);
            frmWebBrowser frmImprimir = new frmWebBrowser(path);//enviar html
            frmImprimir.Text = "I M P R E S S Ã O";
            frmImprimir.ShowDialog();
        }
        public string rodapeHTML()
        {
            StringBuilder html = new StringBuilder();
            html.Append("</div>");
            html.Append("</body>");
            html.Append("</table>");
            html.Append("</html>");
            return html.ToString();
        }
        public string cabecalhoHTML2()
        {
            StringBuilder html = new StringBuilder();
            html.Append("<!DOCTYPE html>");
            html.Append("<html lang=\"pt-br\">");
            html.Append("<head>");
            html.Append("<meta charset=\"utf-8\"/>");
            html.Append("<meta content=\"width=device-width, inicial-scale=1, maximum-scale=1\"name=\"viewport\">");
            // html.Append("<title> R E L A T Ó R I O </title>");
            html.Append("</head>");

            html.Append("<div>");
            html.Append("<header>");//cabeçaloho
            html.Append("<center><h1> N O T A - F I S C A L </h1></center>");
            html.Append("<hr>");//linha
            html.Append("</header>");

            html.Append("<body>");
            html.Append("<font size=\"5\">");//tam fonte
            //gera cabaçalho da tabela
            html.Append("<table width=\"80%\" border=\"1\" cellspacing=\"1\" cellpadding=\"1\" aling=\"center\"");


            html.Append("<tr>");
            html.Append("</tr>");

            html.Append("<body>");
            return html.ToString();






        }
        public string RetornaListBox()
        {
            string strText = "";
            //percorre cada item e converte para STRING
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                strText = strText + listBox1.Items[i] + "<br>";

            }
            return strText;
        }

        public void cabecalho()
        {
            listBox1.Items.Add("                                  Nota fiscal Número:  ");
              
            listBox1.Items.Add("Nome do ç local");
            listBox1.Items.Add("Endderço, nr 390");
            listBox1.Items.Add("Jardim Campos de belo");
            listBox1.Items.Add("_________________________________________");
        }
        public void rodape()
        {
            List<string> lista = produto_P.Split(';').ToList();
            foreach(string value in lista)
            {
                listBox1.Items.Add(value);
            }
            //listBox1.Items.Add(""  + produto_P+"" +valor_P+"");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            //listBox1.Items.Add("                                      ");
            listBox1.Items.Add("======================================");
            listBox1.Items.Add(DateTime.Now);
            listBox1.Items.Add("Valor                            " + total);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}
