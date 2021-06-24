namespace mecânica
{
    partial class Pesquisar_Veícula
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
            System.Windows.Forms.Label lbldescricao;
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnp = new System.Windows.Forms.Button();
            lbldescricao = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(636, 205);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 32);
            this.btnExcluir.TabIndex = 61;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(636, 98);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(137, 32);
            this.btnConsultar.TabIndex = 63;
            this.btnConsultar.Text = "C&onsultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(636, 152);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 32);
            this.btnAlterar.TabIndex = 62;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(636, 42);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(137, 32);
            this.btnNovo.TabIndex = 64;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.DGV);
            this.groupBox.Location = new System.Drawing.Point(9, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(616, 262);
            this.groupBox.TabIndex = 60;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Produtos";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(17, 19);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(593, 225);
            this.DGV.TabIndex = 44;
            // 
            // lbldescricao
            // 
            lbldescricao.AutoSize = true;
            lbldescricao.Location = new System.Drawing.Point(21, 9);
            lbldescricao.Name = "lbldescricao";
            lbldescricao.Size = new System.Drawing.Size(110, 13);
            lbldescricao.TabIndex = 59;
            lbldescricao.Text = "Descrição do Produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(137, 6);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(480, 20);
            this.txtDescricao.TabIndex = 58;
            // 
            // btnp
            // 
            this.btnp.Location = new System.Drawing.Point(636, 3);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(137, 23);
            this.btnp.TabIndex = 57;
            this.btnp.Text = "Pesquisar";
            this.btnp.UseVisualStyleBackColor = true;
            // 
            // Pesquisar_Veícula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 307);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(lbldescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnp);
            this.Name = "Pesquisar_Veícula";
            this.Text = "Pesquisar_Veícula";
            this.Load += new System.EventHandler(this.Pesquisar_Veícula_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnp;
    }
}