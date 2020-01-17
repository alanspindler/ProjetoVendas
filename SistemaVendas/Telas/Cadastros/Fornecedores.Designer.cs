namespace SistemaVendas.Telas.Cadastros
{
    partial class frmFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelarFornecedor = new System.Windows.Forms.Button();
            this.SalvarFornecedor = new System.Windows.Forms.Button();
            this.mskTelefoneFor = new System.Windows.Forms.MaskedTextBox();
            this.txtUffor = new System.Windows.Forms.TextBox();
            this.txtCidadefor = new System.Windows.Forms.TextBox();
            this.txtBairrofor = new System.Windows.Forms.TextBox();
            this.txtEnderecofor = new System.Windows.Forms.TextBox();
            this.mskCEPfor = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.CancelarFornecedor);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.SalvarFornecedor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.mskTelefoneFor);
            this.panel1.Controls.Add(this.txtUffor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCidadefor);
            this.panel1.Controls.Add(this.txtBairrofor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEnderecofor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mskCEPfor);
            this.panel1.Controls.Add(this.txtRazao);
            this.panel1.Controls.Add(this.mskCNPJ);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 585);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(147, 505);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 44);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // CancelarFornecedor
            // 
            this.CancelarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarFornecedor.ForeColor = System.Drawing.Color.Black;
            this.CancelarFornecedor.Location = new System.Drawing.Point(269, 378);
            this.CancelarFornecedor.Name = "CancelarFornecedor";
            this.CancelarFornecedor.Size = new System.Drawing.Size(105, 38);
            this.CancelarFornecedor.TabIndex = 10;
            this.CancelarFornecedor.Text = "Cancelar";
            this.CancelarFornecedor.UseVisualStyleBackColor = true;
            this.CancelarFornecedor.Click += new System.EventHandler(this.CancelarFornecedor_Click);
            // 
            // SalvarFornecedor
            // 
            this.SalvarFornecedor.AllowDrop = true;
            this.SalvarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarFornecedor.ForeColor = System.Drawing.Color.Black;
            this.SalvarFornecedor.Location = new System.Drawing.Point(159, 378);
            this.SalvarFornecedor.Name = "SalvarFornecedor";
            this.SalvarFornecedor.Size = new System.Drawing.Size(104, 38);
            this.SalvarFornecedor.TabIndex = 9;
            this.SalvarFornecedor.Text = "Salvar";
            this.SalvarFornecedor.UseVisualStyleBackColor = true;
            this.SalvarFornecedor.Click += new System.EventHandler(this.SalvarFornecedor_Click);
            // 
            // mskTelefoneFor
            // 
            this.mskTelefoneFor.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskTelefoneFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefoneFor.Location = new System.Drawing.Point(150, 264);
            this.mskTelefoneFor.Mask = "(99) 0000-00000";
            this.mskTelefoneFor.Name = "mskTelefoneFor";
            this.mskTelefoneFor.Size = new System.Drawing.Size(134, 26);
            this.mskTelefoneFor.TabIndex = 8;
            this.mskTelefoneFor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtUffor
            // 
            this.txtUffor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUffor.Location = new System.Drawing.Point(580, 263);
            this.txtUffor.MaxLength = 2;
            this.txtUffor.Name = "txtUffor";
            this.txtUffor.Size = new System.Drawing.Size(43, 26);
            this.txtUffor.TabIndex = 7;
            // 
            // txtCidadefor
            // 
            this.txtCidadefor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadefor.Location = new System.Drawing.Point(580, 211);
            this.txtCidadefor.Name = "txtCidadefor";
            this.txtCidadefor.Size = new System.Drawing.Size(307, 26);
            this.txtCidadefor.TabIndex = 6;
            // 
            // txtBairrofor
            // 
            this.txtBairrofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairrofor.Location = new System.Drawing.Point(147, 211);
            this.txtBairrofor.Name = "txtBairrofor";
            this.txtBairrofor.Size = new System.Drawing.Size(307, 26);
            this.txtBairrofor.TabIndex = 5;
            // 
            // txtEnderecofor
            // 
            this.txtEnderecofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecofor.Location = new System.Drawing.Point(580, 153);
            this.txtEnderecofor.Name = "txtEnderecofor";
            this.txtEnderecofor.Size = new System.Drawing.Size(307, 26);
            this.txtEnderecofor.TabIndex = 4;
            // 
            // mskCEPfor
            // 
            this.mskCEPfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEPfor.Location = new System.Drawing.Point(147, 155);
            this.mskCEPfor.Mask = "99999-999";
            this.mskCEPfor.Name = "mskCEPfor";
            this.mskCEPfor.Size = new System.Drawing.Size(105, 26);
            this.mskCEPfor.TabIndex = 3;
            this.mskCEPfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCEPfor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtRazao
            // 
            this.txtRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazao.Location = new System.Drawing.Point(580, 105);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(307, 26);
            this.txtRazao.TabIndex = 2;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.mskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCNPJ.Location = new System.Drawing.Point(147, 105);
            this.mskCNPJ.Mask = "99,999,999/9999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(157, 26);
            this.mskCNPJ.TabIndex = 1;
            this.mskCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 463);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "UF";
            // 
            // label10
            // 
            this.label10.AccessibleName = "";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Razao Social";
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dados de Identificação";
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 432);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFornecedores";
            this.Text = "Cadastrar Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox mskCNPJ;
        public System.Windows.Forms.TextBox txtRazao;
        public System.Windows.Forms.MaskedTextBox mskCEPfor;
        public System.Windows.Forms.TextBox txtEnderecofor;
        public System.Windows.Forms.TextBox txtBairrofor;
        public System.Windows.Forms.TextBox txtCidadefor;
        public System.Windows.Forms.MaskedTextBox mskTelefoneFor;
        public System.Windows.Forms.Button SalvarFornecedor;
        public System.Windows.Forms.TextBox txtUffor;
        public System.Windows.Forms.Button CancelarFornecedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}