namespace SistemaVendas.Telas.Cadastros
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorUnidd = new System.Windows.Forms.TextBox();
            this.btnLocalizarCliente = new System.Windows.Forms.Button();
            this.btnLocalizarProduto = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtQtdVendas = new System.Windows.Forms.TextBox();
            this.txtCodigoVendas = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataAtual = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelarVenda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EfetuarVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CancelarVenda);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.EfetuarVenda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DataAtual);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtValorUnidd);
            this.panel1.Controls.Add(this.btnLocalizarCliente);
            this.panel1.Controls.Add(this.btnLocalizarProduto);
            this.panel1.Controls.Add(this.mskCPF);
            this.panel1.Controls.Add(this.txtNomeProd);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtValorVenda);
            this.panel1.Controls.Add(this.txtQtdVendas);
            this.panel1.Controls.Add(this.txtCodigoVendas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 549);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Valor do Produto";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nome Produto";
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(805, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "R$";
            // 
            // txtValorUnidd
            // 
            this.txtValorUnidd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtValorUnidd.Enabled = false;
            this.txtValorUnidd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnidd.Location = new System.Drawing.Point(627, 129);
            this.txtValorUnidd.Name = "txtValorUnidd";
            this.txtValorUnidd.Size = new System.Drawing.Size(102, 26);
            this.txtValorUnidd.TabIndex = 30;
            // 
            // btnLocalizarCliente
            // 
            this.btnLocalizarCliente.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLocalizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarCliente.Location = new System.Drawing.Point(316, 131);
            this.btnLocalizarCliente.Name = "btnLocalizarCliente";
            this.btnLocalizarCliente.Size = new System.Drawing.Size(29, 27);
            this.btnLocalizarCliente.TabIndex = 29;
            this.btnLocalizarCliente.UseVisualStyleBackColor = true;
            this.btnLocalizarCliente.Visible = false;
            this.btnLocalizarCliente.Click += new System.EventHandler(this.btnLocalizarCliente_Click);
            // 
            // btnLocalizarProduto
            // 
            this.btnLocalizarProduto.BackgroundImage = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.btnLocalizarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarProduto.Location = new System.Drawing.Point(375, 83);
            this.btnLocalizarProduto.Name = "btnLocalizarProduto";
            this.btnLocalizarProduto.Size = new System.Drawing.Size(29, 27);
            this.btnLocalizarProduto.TabIndex = 28;
            this.btnLocalizarProduto.UseVisualStyleBackColor = true;
            this.btnLocalizarProduto.Visible = false;
            this.btnLocalizarProduto.Click += new System.EventHandler(this.btnLocalizarProduto_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCPF.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(180, 129);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(130, 26);
            this.mskCPF.TabIndex = 19;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCPF_KeyPress);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNomeProd.Enabled = false;
            this.txtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.Location = new System.Drawing.Point(627, 86);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(189, 26);
            this.txtNomeProd.TabIndex = 2;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(177, 180);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(192, 26);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(697, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor Total";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(701, 369);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(98, 26);
            this.txtValorVenda.TabIndex = 7;
            // 
            // txtQtdVendas
            // 
            this.txtQtdVendas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtQtdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdVendas.Location = new System.Drawing.Point(627, 182);
            this.txtQtdVendas.MaxLength = 8;
            this.txtQtdVendas.Name = "txtQtdVendas";
            this.txtQtdVendas.Size = new System.Drawing.Size(102, 26);
            this.txtQtdVendas.TabIndex = 5;
            this.txtQtdVendas.TextChanged += new System.EventHandler(this.txtQtdVendas_LostFocus);
            // 
            // txtCodigoVendas
            // 
            this.txtCodigoVendas.AcceptsTab = true;
            this.txtCodigoVendas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCodigoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVendas.Location = new System.Drawing.Point(180, 84);
            this.txtCodigoVendas.Name = "txtCodigoVendas";
            this.txtCodigoVendas.Size = new System.Drawing.Size(189, 26);
            this.txtCodigoVendas.TabIndex = 1;
            this.txtCodigoVendas.Tag = "0";
            this.txtCodigoVendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoVendas_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(15, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 346);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nome Cliente";
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF Cliente";
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cod Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição da Venda";
            // 
            // DataAtual
            // 
            this.DataAtual.AccessibleName = "";
            this.DataAtual.AutoSize = true;
            this.DataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAtual.Location = new System.Drawing.Point(180, 221);
            this.DataAtual.Name = "DataAtual";
            this.DataAtual.Size = new System.Drawing.Size(50, 25);
            this.DataAtual.TabIndex = 34;
            this.DataAtual.Text = "data";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(177, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 41;
            this.button1.Text = "Adicionar Produto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CancelarVenda
            // 
            this.CancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarVenda.ForeColor = System.Drawing.Color.Black;
            this.CancelarVenda.Location = new System.Drawing.Point(561, 494);
            this.CancelarVenda.Name = "CancelarVenda";
            this.CancelarVenda.Size = new System.Drawing.Size(105, 45);
            this.CancelarVenda.TabIndex = 38;
            this.CancelarVenda.Text = "Cancelar";
            this.CancelarVenda.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 203);
            this.dataGridView1.TabIndex = 40;
            // 
            // EfetuarVenda
            // 
            this.EfetuarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EfetuarVenda.ForeColor = System.Drawing.Color.Black;
            this.EfetuarVenda.Location = new System.Drawing.Point(451, 493);
            this.EfetuarVenda.Name = "EfetuarVenda";
            this.EfetuarVenda.Size = new System.Drawing.Size(104, 45);
            this.EfetuarVenda.TabIndex = 39;
            this.EfetuarVenda.Text = "Efetuar Venda";
            this.EfetuarVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EfetuarVenda.UseVisualStyleBackColor = true;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 547);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        public System.Windows.Forms.TextBox txtCodigoVendas;
        public System.Windows.Forms.TextBox txtValorVenda;
        public System.Windows.Forms.TextBox txtQtdVendas;
        public System.Windows.Forms.TextBox txtNomeProd;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button btnLocalizarCliente;
        private System.Windows.Forms.Button btnLocalizarProduto;
        public System.Windows.Forms.TextBox txtValorUnidd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button CancelarVenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button EfetuarVenda;
        private System.Windows.Forms.Label DataAtual;
    }
}