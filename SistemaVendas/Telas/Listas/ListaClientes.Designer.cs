namespace SistemaVendas.Telas.Listas
{
    partial class frmListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            this.BindingSourceClientes = new System.Windows.Forms.BindingSource(this.components);
            this.classeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskPesqCpf = new System.Windows.Forms.MaskedTextBox();
            this.bancoDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BindingSourceClientes
            // 
            this.BindingSourceClientes.DataSource = this.classeClientesBindingSource;
            // 
            // classeClientesBindingSource
            // 
            this.classeClientesBindingSource.DataSource = typeof(SistemaVendas.Classes.Cadastros.ClasseClientes);
            // 
            // DataGridClientes
            // 
            this.DataGridClientes.AllowUserToOrderColumns = true;
            this.DataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClientes.Location = new System.Drawing.Point(111, 87);
            this.DataGridClientes.Name = "DataGridClientes";
            this.DataGridClientes.Size = new System.Drawing.Size(852, 391);
            this.DataGridClientes.TabIndex = 6;
            this.DataGridClientes.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(3, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 40);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.Location = new System.Drawing.Point(3, 49);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(84, 40);
            this.bntExcluir.TabIndex = 5;
            this.bntExcluir.TabStop = false;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAlterar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntExcluir, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(90, 139);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.txtPesqNome);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 80);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Controls.Add(this.btnLimparPesquisa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPesquisarNome, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(447, 45);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLimparPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(52, 3);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(136, 26);
            this.btnLimparPesquisa.TabIndex = 14;
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
            // txtPesqNome
            // 
            this.txtPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNome.Location = new System.Drawing.Point(108, 49);
            this.txtPesqNome.Multiline = true;
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(211, 24);
            this.txtPesqNome.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 45);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // mskPesqCpf
            // 
            this.mskPesqCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPesqCpf.Location = new System.Drawing.Point(328, 49);
            this.mskPesqCpf.Mask = "999,999,999-99";
            this.mskPesqCpf.MinimumSize = new System.Drawing.Size(5, 5);
            this.mskPesqCpf.Name = "mskPesqCpf";
            this.mskPesqCpf.Size = new System.Drawing.Size(113, 24);
            this.mskPesqCpf.TabIndex = 2;
            this.mskPesqCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bancoDadosBindingSource
            // 
            this.bancoDadosBindingSource.DataSource = typeof(SistemaVendas.Classes.BancoDeDados.BancoDados);
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 490);
            this.Controls.Add(this.mskPesqCpf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DataGridClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaClientes";
            this.Text = "Consultar Lista Clientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource classeClientesBindingSource;
        private System.Windows.Forms.BindingSource bancoDadosBindingSource;
        private System.Windows.Forms.BindingSource BindingSourceClientes;
        private System.Windows.Forms.DataGridView DataGridClientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button btnPesquisarNome;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button bntExcluir;
        public System.Windows.Forms.MaskedTextBox mskPesqCpf;
        public System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}