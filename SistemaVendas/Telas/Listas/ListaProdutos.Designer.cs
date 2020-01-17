namespace SistemaVendas.Telas.Listas
{
    partial class frmListaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListaAlterar = new System.Windows.Forms.Button();
            this.ListaExcluir = new System.Windows.Forms.Button();
            this.DataGridProdutos = new System.Windows.Forms.DataGridView();
            this.BindingSourceProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpesqCod = new System.Windows.Forms.TextBox();
            this.txtpesqProdu = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceProdutos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 57);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ListaAlterar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListaExcluir, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(90, 139);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ListaAlterar
            // 
            this.ListaAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAlterar.Location = new System.Drawing.Point(3, 3);
            this.ListaAlterar.Name = "ListaAlterar";
            this.ListaAlterar.Size = new System.Drawing.Size(84, 40);
            this.ListaAlterar.TabIndex = 99;
            this.ListaAlterar.TabStop = false;
            this.ListaAlterar.Text = "Alterar";
            this.ListaAlterar.UseVisualStyleBackColor = true;
            this.ListaAlterar.Click += new System.EventHandler(this.ListaAlterar_Click);
            // 
            // ListaExcluir
            // 
            this.ListaExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaExcluir.Location = new System.Drawing.Point(3, 49);
            this.ListaExcluir.Name = "ListaExcluir";
            this.ListaExcluir.Size = new System.Drawing.Size(84, 40);
            this.ListaExcluir.TabIndex = 11;
            this.ListaExcluir.TabStop = false;
            this.ListaExcluir.Text = "Excluir";
            this.ListaExcluir.UseVisualStyleBackColor = true;
            this.ListaExcluir.Click += new System.EventHandler(this.ListaExcluir_Click);
            // 
            // DataGridProdutos
            // 
            this.DataGridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProdutos.Location = new System.Drawing.Point(108, 103);
            this.DataGridProdutos.Name = "DataGridProdutos";
            this.DataGridProdutos.Size = new System.Drawing.Size(699, 441);
            this.DataGridProdutos.TabIndex = 0;
            this.DataGridProdutos.TabStop = false;
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(407, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome produto";
            // 
            // txtpesqCod
            // 
            this.txtpesqCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesqCod.Location = new System.Drawing.Point(354, 71);
            this.txtpesqCod.Name = "txtpesqCod";
            this.txtpesqCod.Size = new System.Drawing.Size(189, 26);
            this.txtpesqCod.TabIndex = 2;
            // 
            // txtpesqProdu
            // 
            this.txtpesqProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesqProdu.Location = new System.Drawing.Point(108, 71);
            this.txtpesqProdu.Name = "txtpesqProdu";
            this.txtpesqProdu.Size = new System.Drawing.Size(189, 26);
            this.txtpesqProdu.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Controls.Add(this.btnLimparPesquisa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPesquisarNome, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(549, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLimparPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(52, 3);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(136, 26);
            this.btnLimparPesquisa.TabIndex = 4;
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
            this.btnPesquisarNome.TabIndex = 3;
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.btnPesquisarNome_Click);
            // 
            // frmListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 556);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtpesqCod);
            this.Controls.Add(this.txtpesqProdu);
            this.Controls.Add(this.DataGridProdutos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaProdutos";
            this.Text = "Consular Listar Produtos";
            this.Load += new System.EventHandler(this.ListaProdutos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceProdutos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button ListaAlterar;
        public System.Windows.Forms.Button ListaExcluir;
        public System.Windows.Forms.DataGridView DataGridProdutos;
        private System.Windows.Forms.BindingSource BindingSourceProdutos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtpesqCod;
        public System.Windows.Forms.TextBox txtpesqProdu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btnLimparPesquisa;
        public System.Windows.Forms.Button btnPesquisarNome;
    }
}