namespace mecânica
{
    partial class Ordem_de_Serviço
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod_OS = new System.Windows.Forms.TextBox();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.DGV_2 = new System.Windows.Forms.DataGridView();
            this.btnSairOS = new System.Windows.Forms.Button();
            this.txtDescontoOS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DGV_1 = new System.Windows.Forms.DataGridView();
            this.txtDescricao1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtTotalOS = new System.Windows.Forms.TextBox();
            this.txtPecas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "CPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCod_OS);
            this.groupBox1.Controls.Add(this.txtCodigoC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 73);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(361, 45);
            this.txtTel.Mask = "(99) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(83, 20);
            this.txtTel.TabIndex = 65;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(44, 41);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(96, 20);
            this.txtCPF.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Numero da OS";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 20);
            this.txtNome.TabIndex = 13;
            // 
            // txtCod_OS
            // 
            this.txtCod_OS.Location = new System.Drawing.Point(463, 39);
            this.txtCod_OS.Name = "txtCod_OS";
            this.txtCod_OS.Size = new System.Drawing.Size(82, 20);
            this.txtCod_OS.TabIndex = 67;
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Location = new System.Drawing.Point(361, 19);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.Size = new System.Drawing.Size(96, 20);
            this.txtCodigoC.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(471, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "Modelo";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(168, 80);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(104, 20);
            this.txtCor.TabIndex = 33;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(123, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 15);
            this.label18.TabIndex = 32;
            this.label18.Text = "Cor";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(294, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 30;
            this.label19.Text = "Marca";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Placa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescricao);
            this.groupBox3.Controls.Add(this.DGV);
            this.groupBox3.Location = new System.Drawing.Point(6, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 149);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Peças";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 19);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(579, 20);
            this.txtDescricao.TabIndex = 25;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(18, 45);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(573, 88);
            this.DGV.TabIndex = 45;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseDoubleClick);
            // 
            // DGV_2
            // 
            this.DGV_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_2.Location = new System.Drawing.Point(16, 19);
            this.DGV_2.Name = "DGV_2";
            this.DGV_2.Size = new System.Drawing.Size(583, 90);
            this.DGV_2.TabIndex = 46;
            this.DGV_2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_2_CellContentClick_1);
            // 
            // btnSairOS
            // 
            this.btnSairOS.Location = new System.Drawing.Point(626, 315);
            this.btnSairOS.Name = "btnSairOS";
            this.btnSairOS.Size = new System.Drawing.Size(116, 32);
            this.btnSairOS.TabIndex = 43;
            this.btnSairOS.Text = "Sair";
            this.btnSairOS.UseVisualStyleBackColor = true;
            this.btnSairOS.Click += new System.EventHandler(this.btnSairOS_Click);
            // 
            // txtDescontoOS
            // 
            this.txtDescontoOS.Location = new System.Drawing.Point(628, 381);
            this.txtDescontoOS.Name = "txtDescontoOS";
            this.txtDescontoOS.Size = new System.Drawing.Size(104, 20);
            this.txtDescontoOS.TabIndex = 46;
            this.txtDescontoOS.TextChanged += new System.EventHandler(this.txtDescontoOS_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(642, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = " Peças/Serviços";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(623, 262);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 32);
            this.btnExcluir.TabIndex = 63;
            this.btnExcluir.Text = "R&emover Item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(647, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = " Desconto";
            // 
            // DGV_1
            // 
            this.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_1.Location = new System.Drawing.Point(18, 39);
            this.DGV_1.Name = "DGV_1";
            this.DGV_1.Size = new System.Drawing.Size(574, 77);
            this.DGV_1.TabIndex = 46;
            this.DGV_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.DGV_1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_1_CellMouseClick);
            // 
            // txtDescricao1
            // 
            this.txtDescricao1.Location = new System.Drawing.Point(17, 13);
            this.txtDescricao1.Name = "txtDescricao1";
            this.txtDescricao1.Size = new System.Drawing.Size(574, 20);
            this.txtDescricao1.TabIndex = 47;
            this.txtDescricao1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescricao1);
            this.groupBox2.Controls.Add(this.DGV_1);
            this.groupBox2.Location = new System.Drawing.Point(6, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 126);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_2);
            this.groupBox4.Location = new System.Drawing.Point(2, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 126);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(623, 208);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(116, 32);
            this.btnPagar.TabIndex = 64;
            this.btnPagar.Text = "Efetuar Pagamento";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 65;
            this.button1.Text = "Calcular mão de obra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(52, 78);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(56, 20);
            this.txtPlaca.TabIndex = 68;
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(532, 85);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(121, 21);
            this.cboModelo.TabIndex = 70;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(344, 81);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 69;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // txtTotalOS
            // 
            this.txtTotalOS.Location = new System.Drawing.Point(626, 472);
            this.txtTotalOS.Name = "txtTotalOS";
            this.txtTotalOS.Size = new System.Drawing.Size(104, 20);
            this.txtTotalOS.TabIndex = 71;
            // 
            // txtPecas
            // 
            this.txtPecas.Location = new System.Drawing.Point(626, 422);
            this.txtPecas.Name = "txtPecas";
            this.txtPecas.Size = new System.Drawing.Size(104, 20);
            this.txtPecas.TabIndex = 72;
            // 
            // Ordem_de_Serviço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 516);
            this.Controls.Add(this.txtPecas);
            this.Controls.Add(this.txtTotalOS);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescontoOS);
            this.Controls.Add(this.btnSairOS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Name = "Ordem_de_Serviço";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem_de_Serviço";
            this.Load += new System.EventHandler(this.Ordem_de_Serviço_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtCor;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSairOS;
        public System.Windows.Forms.TextBox txtDescontoOS;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigoC;
        private System.Windows.Forms.DataGridView DGV_2;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV_1;
        private System.Windows.Forms.TextBox txtDescricao1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.MaskedTextBox txtTel;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod_OS;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MaskedTextBox txtPlaca;
        public System.Windows.Forms.ComboBox cboModelo;
        public System.Windows.Forms.ComboBox cboMarca;
        public System.Windows.Forms.TextBox txtTotalOS;
        public System.Windows.Forms.TextBox txtPecas;
    }
}