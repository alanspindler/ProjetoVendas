namespace SistemaVendas.Telas.Listas
{
    partial class frmListaFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFornecedores));
            this.bntExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.DataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskpesqCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtpesqRazao = new System.Windows.Forms.TextBox();
            this.BindingSourceFornecedores = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFornecedores)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // bntExcluir
            // 
            this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.Location = new System.Drawing.Point(3, 49);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(84, 40);
            this.bntExcluir.TabIndex = 6;
            this.bntExcluir.TabStop = false;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(3, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 40);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // DataGridFornecedores
            // 
            this.DataGridFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridFornecedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFornecedores.Location = new System.Drawing.Point(105, 88);
            this.DataGridFornecedores.Name = "DataGridFornecedores";
            this.DataGridFornecedores.Size = new System.Drawing.Size(729, 363);
            this.DataGridFornecedores.TabIndex = 0;
            this.DataGridFornecedores.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAlterar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntExcluir, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(90, 139);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 81);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Controls.Add(this.btnLimparPesquisa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPesquisarNome, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(622, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel3.TabIndex = 12;
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
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(497, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Razao Social";
            // 
            // mskpesqCnpj
            // 
            this.mskpesqCnpj.BackColor = System.Drawing.SystemColors.Window;
            this.mskpesqCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskpesqCnpj.Location = new System.Drawing.Point(451, 49);
            this.mskpesqCnpj.Mask = "99,999,999/9999-99";
            this.mskpesqCnpj.Name = "mskpesqCnpj";
            this.mskpesqCnpj.Size = new System.Drawing.Size(166, 26);
            this.mskpesqCnpj.TabIndex = 2;
            this.mskpesqCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskpesqCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtpesqRazao
            // 
            this.txtpesqRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesqRazao.Location = new System.Drawing.Point(105, 49);
            this.txtpesqRazao.Name = "txtpesqRazao";
            this.txtpesqRazao.Size = new System.Drawing.Size(331, 26);
            this.txtpesqRazao.TabIndex = 1;
            // 
            // BindingSourceFornecedores
            // 
            this.BindingSourceFornecedores.DataSource = typeof(SistemaVendas.Classes.Cadastros.ClasseClientes);
            // 
            // frmListaFornecedores
            // 
            this.ClientSize = new System.Drawing.Size(846, 463);
            this.Controls.Add(this.txtpesqRazao);
            this.Controls.Add(this.mskpesqCnpj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DataGridFornecedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaFornecedores";
            this.Text = "Consulta Lista Fornecedores";
            this.Load += new System.EventHandler(this.ListaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFornecedores)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource BindingSourceFornecedores;
        public System.Windows.Forms.DataGridView DataGridFornecedores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox mskpesqCnpj;
        public System.Windows.Forms.TextBox txtpesqRazao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btnLimparPesquisa;
        public System.Windows.Forms.Button btnPesquisarNome;
    }
}