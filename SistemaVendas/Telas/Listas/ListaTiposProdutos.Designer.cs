namespace SistemaVendas.Telas.Listas
{
    partial class frmListaTiposProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTiposProdutos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListaExcluir = new System.Windows.Forms.Button();
            this.ListaAlterar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridTiposProdutos = new System.Windows.Forms.DataGridView();
            this.BindingSourceTiposProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtpesqTipoProd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTiposProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTiposProdutos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ListaExcluir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListaAlterar, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(89, 133);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ListaExcluir
            // 
            this.ListaExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaExcluir.Location = new System.Drawing.Point(3, 91);
            this.ListaExcluir.Name = "ListaExcluir";
            this.ListaExcluir.Size = new System.Drawing.Size(83, 39);
            this.ListaExcluir.TabIndex = 5;
            this.ListaExcluir.TabStop = false;
            this.ListaExcluir.Text = "Excluir";
            this.ListaExcluir.UseVisualStyleBackColor = true;
            this.ListaExcluir.Click += new System.EventHandler(this.ListaExcluir_Click);
            // 
            // ListaAlterar
            // 
            this.ListaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAlterar.Location = new System.Drawing.Point(3, 47);
            this.ListaAlterar.Name = "ListaAlterar";
            this.ListaAlterar.Size = new System.Drawing.Size(83, 38);
            this.ListaAlterar.TabIndex = 4;
            this.ListaAlterar.TabStop = false;
            this.ListaAlterar.Text = "Alterar";
            this.ListaAlterar.UseVisualStyleBackColor = true;
            this.ListaAlterar.Click += new System.EventHandler(this.ListaAlterar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(52, -41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 57);
            this.panel1.TabIndex = 5;
            // 
            // DataGridTiposProdutos
            // 
            this.DataGridTiposProdutos.AllowUserToOrderColumns = true;
            this.DataGridTiposProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTiposProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridTiposProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTiposProdutos.Location = new System.Drawing.Point(123, 93);
            this.DataGridTiposProdutos.Name = "DataGridTiposProdutos";
            this.DataGridTiposProdutos.Size = new System.Drawing.Size(119, 288);
            this.DataGridTiposProdutos.TabIndex = 0;
            this.DataGridTiposProdutos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo de Produto";
            // 
            // txtpesqTipoProd
            // 
            this.txtpesqTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesqTipoProd.Location = new System.Drawing.Point(123, 61);
            this.txtpesqTipoProd.Name = "txtpesqTipoProd";
            this.txtpesqTipoProd.Size = new System.Drawing.Size(189, 26);
            this.txtpesqTipoProd.TabIndex = 1;
            this.txtpesqTipoProd.WordWrap = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Controls.Add(this.btnLimparPesquisa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPesquisarNome, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(318, 59);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLimparPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(52, 3);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(136, 26);
            this.btnLimparPesquisa.TabIndex = 3;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnPesquisarNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarNome.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(43, 26);
            this.btnPesquisarNome.TabIndex = 2;
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.btnPesquisarNome_Click);
            // 
            // frmListaTiposProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.txtpesqTipoProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridTiposProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaTiposProdutos";
            this.Text = "ListaTipo Produtos";
            this.Load += new System.EventHandler(this.ListaTipoProdutos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTiposProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTiposProdutos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button ListaExcluir;
        public System.Windows.Forms.Button ListaAlterar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DataGridTiposProdutos;
        private System.Windows.Forms.BindingSource BindingSourceTiposProdutos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtpesqTipoProd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btnLimparPesquisa;
        public System.Windows.Forms.Button btnPesquisarNome;
    }
}