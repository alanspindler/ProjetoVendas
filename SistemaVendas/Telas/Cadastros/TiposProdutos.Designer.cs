namespace SistemaVendas.Telas.Cadastros
{
    partial class frmTiposProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposProdutos));
            this.BindingSourceTipoProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.btnSalvarTipoProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTipoProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(168, 509);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 44);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarProduto.Location = new System.Drawing.Point(291, 274);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(98, 38);
            this.btnCancelarProduto.TabIndex = 9;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // btnSalvarTipoProduto
            // 
            this.btnSalvarTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTipoProduto.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarTipoProduto.Location = new System.Drawing.Point(170, 272);
            this.btnSalvarTipoProduto.Name = "btnSalvarTipoProduto";
            this.btnSalvarTipoProduto.Size = new System.Drawing.Size(104, 38);
            this.btnSalvarTipoProduto.TabIndex = 8;
            this.btnSalvarTipoProduto.Text = "Salvar";
            this.btnSalvarTipoProduto.UseVisualStyleBackColor = true;
            this.btnSalvarTipoProduto.Click += new System.EventHandler(this.btnSalvarTipoProduto_Click);
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo de Produto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 463);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dados de Identificação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelarProduto);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnSalvarTipoProduto);
            this.panel1.Controls.Add(this.txtTipoProduto);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 390);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dados de Identificação";
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProduto.Location = new System.Drawing.Point(170, 220);
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(189, 26);
            this.txtTipoProduto.TabIndex = 6;
            this.txtTipoProduto.WordWrap = false;
            // 
            // frmTiposProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposProdutos";
            this.Text = "Cadastrar tipo de  Produtos";
            this.Load += new System.EventHandler(this.frmTiposProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTipoProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BindingSourceTipoProdutos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btnCancelarProduto;
        public System.Windows.Forms.Button btnSalvarTipoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.Label label1;
    }
}