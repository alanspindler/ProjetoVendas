namespace SistemaVendas.Telas.Cadastros
{
    partial class frmProdutos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbTipoProd = new System.Windows.Forms.ComboBox();
            this.CancelarProduto = new System.Windows.Forms.Button();
            this.SalvarProduto = new System.Windows.Forms.Button();
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BindingSourceTipoProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTipoProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.CancelarProduto);
            this.panel1.Controls.Add(this.chkDisponivel);
            this.panel1.Controls.Add(this.SalvarProduto);
            this.panel1.Controls.Add(this.cbGenero);
            this.panel1.Controls.Add(this.cbTipoProd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtValorProd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtQtdProd);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.txtCodigoProd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 600);
            this.panel1.TabIndex = 0;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(198, 285);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(15, 14);
            this.chkDisponivel.TabIndex = 7;
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // cbGenero
            // 
            this.cbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGenero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbGenero.DropDownHeight = 120;
            this.cbGenero.DropDownWidth = 200;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.IntegralHeight = false;
            this.cbGenero.Items.AddRange(new object[] {
            "Informatica",
            "perecível",
            "Não perecível",
            "Romance",
            "Aventura"});
            this.cbGenero.Location = new System.Drawing.Point(584, 163);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(189, 26);
            this.cbGenero.TabIndex = 4;
            // 
            // cbTipoProd
            // 
            this.cbTipoProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoProd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProd.FormattingEnabled = true;
            this.cbTipoProd.Items.AddRange(new object[] {
            "Alimento",
            "EletroDomestico",
            "Eletronico",
            "Higiene Pessoal",
            "Limpeza",
            "Livros"});
            this.cbTipoProd.Location = new System.Drawing.Point(195, 161);
            this.cbTipoProd.MaxDropDownItems = 50;
            this.cbTipoProd.Name = "cbTipoProd";
            this.cbTipoProd.Size = new System.Drawing.Size(189, 26);
            this.cbTipoProd.Sorted = true;
            this.cbTipoProd.TabIndex = 3;
            // 
            // CancelarProduto
            // 
            this.CancelarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarProduto.ForeColor = System.Drawing.Color.Black;
            this.CancelarProduto.Location = new System.Drawing.Point(308, 382);
            this.CancelarProduto.Name = "CancelarProduto";
            this.CancelarProduto.Size = new System.Drawing.Size(98, 38);
            this.CancelarProduto.TabIndex = 9;
            this.CancelarProduto.Text = "Cancelar";
            this.CancelarProduto.UseVisualStyleBackColor = true;
            this.CancelarProduto.Click += new System.EventHandler(this.CancelarProduto_Click);
            // 
            // SalvarProduto
            // 
            this.SalvarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarProduto.ForeColor = System.Drawing.Color.Black;
            this.SalvarProduto.Location = new System.Drawing.Point(198, 382);
            this.SalvarProduto.Name = "SalvarProduto";
            this.SalvarProduto.Size = new System.Drawing.Size(104, 38);
            this.SalvarProduto.TabIndex = 8;
            this.SalvarProduto.Text = "Salvar";
            this.SalvarProduto.UseVisualStyleBackColor = true;
            this.SalvarProduto.Click += new System.EventHandler(this.SalvarProduto_Click);
            // 
            // txtValorProd
            // 
            this.txtValorProd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProd.Location = new System.Drawing.Point(584, 216);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(189, 26);
            this.txtValorProd.TabIndex = 6;
            this.txtValorProd.Text = "\r\n";
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtQtdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQtdProd.Location = new System.Drawing.Point(195, 216);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(189, 26);
            this.txtQtdProd.TabIndex = 5;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(584, 113);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(189, 26);
            this.txtProduto.TabIndex = 2;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.Location = new System.Drawing.Point(195, 108);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(189, 26);
            this.txtCodigoProd.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 463);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo de Produto";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Disponível";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor Unidd";
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sub Genero";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome produto";
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dados de Identificação";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 460);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTipoProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtValorProd;
        public System.Windows.Forms.TextBox txtQtdProd;
        public System.Windows.Forms.TextBox txtProduto;
        public System.Windows.Forms.TextBox txtCodigoProd;
        public System.Windows.Forms.Button SalvarProduto;
        public System.Windows.Forms.Button CancelarProduto;
        public System.Windows.Forms.ComboBox cbGenero;
        public System.Windows.Forms.ComboBox cbTipoProd;
        private System.Windows.Forms.BindingSource BindingSourceTipoProdutos;
        public System.Windows.Forms.CheckBox chkDisponivel;
    }
}