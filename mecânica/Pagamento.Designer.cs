namespace mecânica
{
    partial class Pagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbkDebito = new System.Windows.Forms.CheckBox();
            this.cbkCredito = new System.Windows.Forms.CheckBox();
            this.chkCartao = new System.Windows.Forms.CheckBox();
            this.cbkdinheiro = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintNF = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.txtATPGAR = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkCartao);
            this.groupBox1.Controls.Add(this.cbkdinheiro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.cbkDebito);
            this.groupBox3.Controls.Add(this.cbkCredito);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(120, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 98);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // cbkDebito
            // 
            this.cbkDebito.AutoSize = true;
            this.cbkDebito.Location = new System.Drawing.Point(25, 13);
            this.cbkDebito.Name = "cbkDebito";
            this.cbkDebito.Size = new System.Drawing.Size(75, 24);
            this.cbkDebito.TabIndex = 1;
            this.cbkDebito.Text = "Debito";
            this.cbkDebito.UseVisualStyleBackColor = true;
            this.cbkDebito.CheckedChanged += new System.EventHandler(this.cbkDebito_CheckedChanged);
            // 
            // cbkCredito
            // 
            this.cbkCredito.AutoSize = true;
            this.cbkCredito.Location = new System.Drawing.Point(26, 43);
            this.cbkCredito.Name = "cbkCredito";
            this.cbkCredito.Size = new System.Drawing.Size(79, 24);
            this.cbkCredito.TabIndex = 2;
            this.cbkCredito.Text = "Credito";
            this.cbkCredito.UseVisualStyleBackColor = true;
            this.cbkCredito.CheckedChanged += new System.EventHandler(this.cbkCredito_CheckedChanged);
            // 
            // chkCartao
            // 
            this.chkCartao.AutoSize = true;
            this.chkCartao.Location = new System.Drawing.Point(20, 74);
            this.chkCartao.Name = "chkCartao";
            this.chkCartao.Size = new System.Drawing.Size(76, 24);
            this.chkCartao.TabIndex = 3;
            this.chkCartao.Text = "Cartão";
            this.chkCartao.UseVisualStyleBackColor = true;
            this.chkCartao.CheckedChanged += new System.EventHandler(this.chkCartao_CheckedChanged);
            // 
            // cbkdinheiro
            // 
            this.cbkdinheiro.AutoSize = true;
            this.cbkdinheiro.Location = new System.Drawing.Point(20, 38);
            this.cbkdinheiro.Name = "cbkdinheiro";
            this.cbkdinheiro.Size = new System.Drawing.Size(87, 24);
            this.cbkdinheiro.TabIndex = 0;
            this.cbkdinheiro.Text = "Dinheiro";
            this.cbkdinheiro.UseVisualStyleBackColor = true;
            this.cbkdinheiro.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPagar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnPagar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCredito);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDebito);
            this.groupBox2.Controls.Add(this.lblDinheiro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 154);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cartão";
            // 
            // txtPagar
            // 
            this.txtPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagar.Location = new System.Drawing.Point(102, 25);
            this.txtPagar.Multiline = true;
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(123, 26);
            this.txtPagar.TabIndex = 26;
            this.txtPagar.TextChanged += new System.EventHandler(this.txtPagar_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(77, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Troco:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total do Cretido:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(234, 119);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(89, 29);
            this.btnPagar.TabIndex = 21;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total  do Debito:";
            // 
            // lblCredito
            // 
            this.lblCredito.Location = new System.Drawing.Point(144, 106);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(72, 20);
            this.lblCredito.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total em dinhero:";
            // 
            // lblDebito
            // 
            this.lblDebito.Location = new System.Drawing.Point(141, 86);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(75, 20);
            this.lblDebito.TabIndex = 21;
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.Location = new System.Drawing.Point(144, 66);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(76, 20);
            this.lblDinheiro.TabIndex = 20;
            this.lblDinheiro.Click += new System.EventHandler(this.lblDinheiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Digitar valor";
            // 
            // btnPrintNF
            // 
            this.btnPrintNF.Location = new System.Drawing.Point(142, 408);
            this.btnPrintNF.Name = "btnPrintNF";
            this.btnPrintNF.Size = new System.Drawing.Size(114, 29);
            this.btnPrintNF.TabIndex = 8;
            this.btnPrintNF.Text = "Imprimir";
            this.btnPrintNF.UseVisualStyleBackColor = true;
            this.btnPrintNF.Click += new System.EventHandler(this.btnPrintNF_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Gera nota fiscal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(268, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "S&air";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(349, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 316);
            this.listBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total a Pagar";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Valor da parcela";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtParcela
            // 
            this.txtParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(137, 276);
            this.txtParcela.Multiline = true;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(91, 26);
            this.txtParcela.TabIndex = 23;
            this.txtParcela.TextChanged += new System.EventHandler(this.txtParcela_TextChanged);
            // 
            // txtATPGAR
            // 
            this.txtATPGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtATPGAR.Location = new System.Drawing.Point(137, 315);
            this.txtATPGAR.Multiline = true;
            this.txtATPGAR.Name = "txtATPGAR";
            this.txtATPGAR.Size = new System.Drawing.Size(91, 26);
            this.txtATPGAR.TabIndex = 21;
            this.txtATPGAR.TextChanged += new System.EventHandler(this.txtATPGAR_TextChanged);
            this.txtATPGAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtATPGAR_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(137, 362);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(91, 26);
            this.txtTotal.TabIndex = 26;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.txtATPGAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrintNF);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPrintNF;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbkCredito;
        private System.Windows.Forms.CheckBox cbkDebito;
        private System.Windows.Forms.CheckBox cbkdinheiro;
        private System.Windows.Forms.CheckBox chkCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.TextBox txtATPGAR;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.TextBox txtTotal;
    }
}