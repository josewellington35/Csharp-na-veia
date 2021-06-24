namespace mecânica
{
    partial class Pesquisar_OS
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnp = new System.Windows.Forms.Button();
            lbldescricao = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldescricao
            // 
            lbldescricao.AutoSize = true;
            lbldescricao.Location = new System.Drawing.Point(12, 9);
            lbldescricao.Name = "lbldescricao";
            lbldescricao.Size = new System.Drawing.Size(88, 13);
            lbldescricao.TabIndex = 67;
            lbldescricao.Text = "Descrição da OS";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(627, 79);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 32);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(627, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(137, 32);
            this.btnConsultar.TabIndex = 71;
            this.btnConsultar.Text = "C&onsultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.DGV);
            this.groupBox.Location = new System.Drawing.Point(0, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(616, 262);
            this.groupBox.TabIndex = 68;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "OS";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(15, 19);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(593, 225);
            this.DGV.TabIndex = 44;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(128, 6);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(480, 20);
            this.txtDescricao.TabIndex = 66;
            // 
            // btnp
            // 
            this.btnp.Location = new System.Drawing.Point(627, 3);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(137, 23);
            this.btnp.TabIndex = 65;
            this.btnp.Text = "Pesquisar";
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // Pesquisar_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(lbldescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnp);
            this.Name = "Pesquisar_OS";
            this.Text = "Pesquisar_OS";
            this.Load += new System.EventHandler(this.Pesquisar_OS_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnp;
    }
}