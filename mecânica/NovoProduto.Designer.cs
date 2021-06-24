namespace mecânica
{
    partial class NovoProduto
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
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label ValorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label lblFornecedor;
            System.Windows.Forms.Label lblMarca;
            System.Windows.Forms.Label label1;
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCOD_Produto = new System.Windows.Forms.TextBox();
            this.dataSet11 = new mecânica.DataSet1();
            this.Novo = new System.Windows.Forms.GroupBox();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            quantidadeLabel = new System.Windows.Forms.Label();
            ValorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            lblFornecedor = new System.Windows.Forms.Label();
            lblMarca = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.Novo.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(204, 92);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(29, 13);
            quantidadeLabel.TabIndex = 12;
            quantidadeLabel.Text = "Ano:";
            // 
            // ValorLabel
            // 
            ValorLabel.AutoSize = true;
            ValorLabel.Location = new System.Drawing.Point(22, 92);
            ValorLabel.Name = "ValorLabel";
            ValorLabel.Size = new System.Drawing.Size(34, 13);
            ValorLabel.TabIndex = 14;
            ValorLabel.Text = "Valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(204, 38);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 10;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new System.Drawing.Point(6, 35);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new System.Drawing.Size(64, 13);
            lblFornecedor.TabIndex = 8;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new System.Drawing.Point(385, 35);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(40, 13);
            lblMarca.TabIndex = 27;
            lblMarca.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(385, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 28;
            label1.Text = "Modelo:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(77, 86);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 15;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(260, 32);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Código";
            // 
            // txtCOD_Produto
            // 
            this.txtCOD_Produto.Location = new System.Drawing.Point(74, 10);
            this.txtCOD_Produto.Name = "txtCOD_Produto";
            this.txtCOD_Produto.Size = new System.Drawing.Size(54, 20);
            this.txtCOD_Produto.TabIndex = 29;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Novo
            // 
            this.Novo.Controls.Add(this.txtAno);
            this.Novo.Controls.Add(this.cboFornecedor);
            this.Novo.Controls.Add(this.cboModelo);
            this.Novo.Controls.Add(ValorLabel);
            this.Novo.Controls.Add(this.cboMarca);
            this.Novo.Controls.Add(lblFornecedor);
            this.Novo.Controls.Add(label1);
            this.Novo.Controls.Add(codigoProdutoLabel);
            this.Novo.Controls.Add(lblMarca);
            this.Novo.Controls.Add(this.txtvalor);
            this.Novo.Controls.Add(quantidadeLabel);
            this.Novo.Controls.Add(this.txtProduto);
            this.Novo.Location = new System.Drawing.Point(12, 47);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(569, 134);
            this.Novo.TabIndex = 31;
            this.Novo.TabStop = false;
            this.Novo.Text = " Produtos";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(77, 35);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cboFornecedor.TabIndex = 36;
            this.cboFornecedor.SelectedIndexChanged += new System.EventHandler(this.cboFornecedor_SelectedIndexChanged);
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(432, 86);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(121, 21);
            this.cboModelo.TabIndex = 35;
            this.cboModelo.SelectedIndexChanged += new System.EventHandler(this.cboModelo_SelectedIndexChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(432, 31);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 34;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(408, 187);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(506, 187);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(260, 84);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 37;
            this.txtAno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTel_MaskInputRejected);
            // 
            // NovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 222);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCOD_Produto);
            this.Name = "NovoProduto";
            this.Text = " ";
            this.Load += new System.EventHandler(this.NovoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.Novo.ResumeLayout(false);
            this.Novo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCOD_Produto;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtvalor;
        public System.Windows.Forms.TextBox txtProduto;
        public DataSet1 dataSet11;
        public System.Windows.Forms.GroupBox Novo;
        public System.Windows.Forms.ComboBox cboModelo;
        public System.Windows.Forms.ComboBox cboMarca;
        public System.Windows.Forms.ComboBox cboFornecedor;
        public System.Windows.Forms.MaskedTextBox txtAno;
    }
}