namespace SistemaVendas.Telas.Listas
{
    partial class FrmListaCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCompras));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AlterarCom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPesqFornecedor = new System.Windows.Forms.TextBox();
            this.mskPesqCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpesqNome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pesqCompras = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridCompras = new System.Windows.Forms.DataGridView();
            this.BindingSourceCompras = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AlterarCom, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(94, 132);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AlterarCom
            // 
            this.AlterarCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlterarCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarCom.Location = new System.Drawing.Point(3, 3);
            this.AlterarCom.Name = "AlterarCom";
            this.AlterarCom.Size = new System.Drawing.Size(88, 38);
            this.AlterarCom.TabIndex = 6;
            this.AlterarCom.TabStop = false;
            this.AlterarCom.Text = "Alterar";
            this.AlterarCom.UseVisualStyleBackColor = true;
            this.AlterarCom.Click += new System.EventHandler(this.AlterarCom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtPesqFornecedor);
            this.panel1.Controls.Add(this.mskPesqCNPJ);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textpesqNome);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 78);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fornecedor";
            // 
            // TxtPesqFornecedor
            // 
            this.TxtPesqFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtPesqFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesqFornecedor.Location = new System.Drawing.Point(274, 47);
            this.TxtPesqFornecedor.Name = "TxtPesqFornecedor";
            this.TxtPesqFornecedor.Size = new System.Drawing.Size(211, 24);
            this.TxtPesqFornecedor.TabIndex = 2;
            // 
            // mskPesqCNPJ
            // 
            this.mskPesqCNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.mskPesqCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPesqCNPJ.Location = new System.Drawing.Point(491, 46);
            this.mskPesqCNPJ.Mask = "99,999,999/9999-99";
            this.mskPesqCNPJ.Name = "mskPesqCNPJ";
            this.mskPesqCNPJ.Size = new System.Drawing.Size(160, 26);
            this.mskPesqCNPJ.TabIndex = 3;
            this.mskPesqCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskPesqCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Produto";
            // 
            // textpesqNome
            // 
            this.textpesqNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textpesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpesqNome.Location = new System.Drawing.Point(105, 46);
            this.textpesqNome.Multiline = true;
            this.textpesqNome.Name = "textpesqNome";
            this.textpesqNome.Size = new System.Drawing.Size(163, 24);
            this.textpesqNome.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Controls.Add(this.pesqCompras, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLimpar, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(657, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // pesqCompras
            // 
            this.pesqCompras.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.pesqCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesqCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesqCompras.Location = new System.Drawing.Point(3, 3);
            this.pesqCompras.Name = "pesqCompras";
            this.pesqCompras.Size = new System.Drawing.Size(43, 26);
            this.pesqCompras.TabIndex = 4;
            this.pesqCompras.UseVisualStyleBackColor = true;
            this.pesqCompras.Click += new System.EventHandler(this.pesqCompras_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(52, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 26);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar Pesquisa";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "CNPJ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 45);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fornecedor";
            // 
            // DataGridCompras
            // 
            this.DataGridCompras.AllowUserToOrderColumns = true;
            this.DataGridCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridCompras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCompras.Location = new System.Drawing.Point(106, 82);
            this.DataGridCompras.Name = "DataGridCompras";
            this.DataGridCompras.Size = new System.Drawing.Size(761, 411);
            this.DataGridCompras.TabIndex = 0;
            this.DataGridCompras.TabStop = false;
            // 
            // FrmListaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 505);
            this.Controls.Add(this.DataGridCompras);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaCompras";
            this.Text = "Consultar Lista Compras";
            this.Load += new System.EventHandler(this.ListaCompras_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button AlterarCom;
        private System.Windows.Forms.DataGridView DataGridCompras;
        private System.Windows.Forms.BindingSource BindingSourceCompras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TextBox TxtPesqFornecedor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mskPesqCNPJ;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button pesqCompras;
        public System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textpesqNome;
        private System.Windows.Forms.Label label4;
    }
}