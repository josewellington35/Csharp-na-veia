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
    public partial class Veículo : Form
    {
        ClnVeiculo ObjClnMecanica = new ClnVeiculo();
        clnUtil objClnUtil = new clnUtil();
        public Veículo()
        {
            InitializeComponent();
        }
        public string cvc;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodVEICULO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if ((txtPlaca.Text == "") || (cboMarca.Text == "") || (txtCor.Text == "") || (cboModelo.Text == ""))
            
            {
                MessageBox.Show("Os campos com * são Obrigatórios", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ObjClnMecanica.Placa = txtPlaca.Text;
                ObjClnMecanica.Marca = cboMarca.Text;
                ObjClnMecanica.Cor = txtCor.Text;
                ObjClnMecanica.Modelo = cboModelo.Text;
                ObjClnMecanica.COD_CLIENTE1 = txtCod_Cliente.Text;



                if (txtCodVEICULO.Text == "")
                {
                    ObjClnMecanica.Gravar();
                    MessageBox.Show("Registo gravado com Sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtCodVEICULO.Text != "")
                {
                    ObjClnMecanica.Placa = txtCodVEICULO.Text;
                    ObjClnMecanica.Alterar();
                    MessageBox.Show("Registro Número " + txtCodVEICULO.Text + ", Alterado com sucesso", "alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Close();
            }

        }
         
        private void Veículo_Load(object sender, EventArgs e)
        {
            //cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            //PreencherMarca();
            //cboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            //PreencherModelo();

            PreencherMarca();



            txtCod_Cliente.Enabled = false; 
            
            // Esta recebndo o codigo do cliente
            txtCod_Cliente.Text = cvc;

           
            txtCodVEICULO.Enabled = false;
           
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

        public void txtCod_Cliente_TextChanged(object sender, EventArgs e)
        {
            //  Cliente ObjClnMecanica = new Cliente();

            txtCod_Cliente.Text = Convert.ToString(cvc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = 0;
            i  = r.Next(999);

                        
               
            
            if (txtCod_Cliente.Text == "")
            {
                txtCod_Cliente.Text = Convert.ToString(i);
            }
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtPlaca.MaxLength = 7;
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
         PreencherModelo();
        }
    }
}
