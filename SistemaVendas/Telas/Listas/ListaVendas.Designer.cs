namespace SistemaVendas.Telas.Listas
{
    partial class frmListaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaVendas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodListaVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDataListaVenda = new System.Windows.Forms.MaskedTextBox();
            this.DataGridVendas = new System.Windows.Forms.DataGridView();
            this.BindingSourceVendas = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textpesNomeV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceVendas)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 57);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Buscar Vendas";
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cod Venda";
            // 
            // txtCodListaVenda
            // 
            this.txtCodListaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodListaVenda.Location = new System.Drawing.Point(173, 156);
            this.txtCodListaVenda.Name = "txtCodListaVenda";
            this.txtCodListaVenda.Size = new System.Drawing.Size(189, 26);
            this.txtCodListaVenda.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data da Venda";
            // 
            // mskDataListaVenda
            // 
            this.mskDataListaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataListaVenda.Location = new System.Drawing.Point(173, 198);
            this.mskDataListaVenda.Mask = "00/00/0000";
            this.mskDataListaVenda.Name = "mskDataListaVenda";
            this.mskDataListaVenda.Size = new System.Drawing.Size(107, 26);
            this.mskDataListaVenda.TabIndex = 3;
            this.mskDataListaVenda.ValidatingType = typeof(System.DateTime);
            // 
            // DataGridVendas
            // 
            this.DataGridVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridVendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridVendas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVendas.Location = new System.Drawing.Point(3, 278);
            this.DataGridVendas.Name = "DataGridVendas";
            this.DataGridVendas.Size = new System.Drawing.Size(696, 304);
            this.DataGridVendas.TabIndex = 24;
            this.DataGridVendas.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Controls.Add(this.btnPesquisarNome, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLimparPesquisa, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(366, 192);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 32);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnPesquisarNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarNome.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(43, 26);
            this.btnPesquisarNome.TabIndex = 5;
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.btnPesquisarNome_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLimparPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(52, 3);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(136, 26);
            this.btnLimparPesquisa.TabIndex = 6;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cliente";
            // 
            // textpesNomeV
            // 
            this.textpesNomeV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpesNomeV.Location = new System.Drawing.Point(173, 109);
            this.textpesNomeV.Name = "textpesNomeV";
            this.textpesNomeV.Size = new System.Drawing.Size(189, 26);
            this.textpesNomeV.TabIndex = 1;
            // 
            // frmListaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 594);
            this.Controls.Add(this.textpesNomeV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.DataGridVendas);
            this.Controls.Add(this.mskDataListaVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodListaVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaVendas";
            this.Text = "Consulta Lista Vendas";
            this.Load += new System.EventHandler(this.ListaVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceVendas)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodListaVenda;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox mskDataListaVenda;
        public System.Windows.Forms.DataGridView DataGridVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource BindingSourceVendas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btnLimparPesquisa;
        public System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textpesNomeV;
    }
}