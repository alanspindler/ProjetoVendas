namespace SistemaVendas.Telas.Cadastros
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.btnLocalizarProduto = new System.Windows.Forms.Button();
            this.mskDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtValorCompras = new System.Windows.Forms.TextBox();
            this.txtQtdCompras = new System.Windows.Forms.TextBox();
            this.txtFornCompras = new System.Windows.Forms.TextBox();
            this.txtCodigoCompras = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalvarCompras = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelarProd = new System.Windows.Forms.Button();
            this.BindingSourceProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSourceFornecedores = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CancelarProd);
            this.panel1.Controls.Add(this.SalvarCompras);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnLocalizarFornecedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mskCNPJ);
            this.panel1.Controls.Add(this.txtDescProduto);
            this.panel1.Controls.Add(this.btnLocalizarProduto);
            this.panel1.Controls.Add(this.mskDataCompra);
            this.panel1.Controls.Add(this.txtValorCompras);
            this.panel1.Controls.Add(this.txtQtdCompras);
            this.panel1.Controls.Add(this.txtFornCompras);
            this.panel1.Controls.Add(this.txtCodigoCompras);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 472);
            this.panel1.TabIndex = 0;
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLocalizarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(834, 110);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(29, 27);
            this.btnLocalizarFornecedor.TabIndex = 19;
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.mskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCNPJ.Location = new System.Drawing.Point(648, 111);
            this.mskCNPJ.Mask = "99,999,999/9999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(180, 26);
            this.mskCNPJ.TabIndex = 18;
            this.mskCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescProduto.Enabled = false;
            this.txtDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProduto.Location = new System.Drawing.Point(212, 160);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(189, 26);
            this.txtDescProduto.TabIndex = 17;
            // 
            // btnLocalizarProduto
            // 
            this.btnLocalizarProduto.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLocalizarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarProduto.Location = new System.Drawing.Point(407, 112);
            this.btnLocalizarProduto.Name = "btnLocalizarProduto";
            this.btnLocalizarProduto.Size = new System.Drawing.Size(29, 27);
            this.btnLocalizarProduto.TabIndex = 16;
            this.btnLocalizarProduto.UseVisualStyleBackColor = true;
            this.btnLocalizarProduto.Click += new System.EventHandler(this.btnLocalizarProduto_Click);
            // 
            // mskDataCompra
            // 
            this.mskDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCompra.Location = new System.Drawing.Point(648, 208);
            this.mskDataCompra.Mask = "00/00/0000";
            this.mskDataCompra.Name = "mskDataCompra";
            this.mskDataCompra.Size = new System.Drawing.Size(91, 26);
            this.mskDataCompra.TabIndex = 5;
            this.mskDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorCompras
            // 
            this.txtValorCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompras.Location = new System.Drawing.Point(212, 253);
            this.txtValorCompras.Name = "txtValorCompras";
            this.txtValorCompras.Size = new System.Drawing.Size(102, 26);
            this.txtValorCompras.TabIndex = 4;
            // 
            // txtQtdCompras
            // 
            this.txtQtdCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdCompras.Location = new System.Drawing.Point(212, 210);
            this.txtQtdCompras.Name = "txtQtdCompras";
            this.txtQtdCompras.Size = new System.Drawing.Size(189, 26);
            this.txtQtdCompras.TabIndex = 3;
            // 
            // txtFornCompras
            // 
            this.txtFornCompras.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFornCompras.Enabled = false;
            this.txtFornCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornCompras.Location = new System.Drawing.Point(648, 160);
            this.txtFornCompras.Name = "txtFornCompras";
            this.txtFornCompras.Size = new System.Drawing.Size(180, 26);
            this.txtFornCompras.TabIndex = 2;
            // 
            // txtCodigoCompras
            // 
            this.txtCodigoCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompras.Location = new System.Drawing.Point(212, 112);
            this.txtCodigoCompras.Name = "txtCodigoCompras";
            this.txtCodigoCompras.Size = new System.Drawing.Size(189, 26);
            this.txtCodigoCompras.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 463);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fornecedor";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor Total";
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data da Compra";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "CNPJ Fornecedor";
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cod Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dados de Identificação";
            // 
            // SalvarCompras
            // 
            this.SalvarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarCompras.ForeColor = System.Drawing.Color.Black;
            this.SalvarCompras.Location = new System.Drawing.Point(212, 360);
            this.SalvarCompras.Name = "SalvarCompras";
            this.SalvarCompras.Size = new System.Drawing.Size(104, 38);
            this.SalvarCompras.TabIndex = 7;
            this.SalvarCompras.Text = "Salvar";
            this.SalvarCompras.UseVisualStyleBackColor = true;
            this.SalvarCompras.Click += new System.EventHandler(this.SalvarCompras_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 513);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 44);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // CancelarProd
            // 
            this.CancelarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarProd.ForeColor = System.Drawing.Color.Black;
            this.CancelarProd.Location = new System.Drawing.Point(331, 360);
            this.CancelarProd.Name = "CancelarProd";
            this.CancelarProd.Size = new System.Drawing.Size(105, 38);
            this.CancelarProd.TabIndex = 8;
            this.CancelarProd.Text = "Cancelar";
            this.CancelarProd.UseVisualStyleBackColor = true;
            this.CancelarProd.Click += new System.EventHandler(this.CancelarProd_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodigoCompras;
        public System.Windows.Forms.TextBox txtQtdCompras;
        public System.Windows.Forms.TextBox txtValorCompras;
        private System.Windows.Forms.MaskedTextBox mskDataCompra;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button SalvarCompras;
        public System.Windows.Forms.Button CancelarProd;
        private System.Windows.Forms.Button btnLocalizarProduto;
        public System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtFornCompras;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        public System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource BindingSourceProdutos;
        private System.Windows.Forms.BindingSource BindingSourceFornecedores;
    }
}