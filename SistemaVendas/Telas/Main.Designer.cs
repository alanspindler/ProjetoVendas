namespace SistemaVendas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarTiposProd = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarTiposProd = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREDITOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPrincipal,
            this.cREDITOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuPrincipal.CheckOnClick = global::SistemaVendas.Properties.Settings.Default.A;
            this.MenuPrincipal.DoubleClickEnabled = true;
            this.MenuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuPrincipal.Image = global::SistemaVendas.Properties.Resources.magnifying_glass_color_icon_73268;
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.MenuPrincipal.Size = new System.Drawing.Size(79, 24);
            this.MenuPrincipal.Text = "MENU";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrar,
            this.MenuConsultarCliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // MenuCadastrar
            // 
            this.MenuCadastrar.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuCadastrar.Name = "MenuCadastrar";
            this.MenuCadastrar.Size = new System.Drawing.Size(141, 24);
            this.MenuCadastrar.Text = "Cadastrar";
            this.MenuCadastrar.Click += new System.EventHandler(this.MenuCadastrar_Click);
            // 
            // MenuConsultarCliente
            // 
            this.MenuConsultarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuConsultarCliente.Name = "MenuConsultarCliente";
            this.MenuConsultarCliente.Size = new System.Drawing.Size(141, 24);
            this.MenuConsultarCliente.Text = "Consultar";
            this.MenuConsultarCliente.Click += new System.EventHandler(this.MenuConsultarCliente_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFornecedor,
            this.MenuConsultarFornecedor});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(141, 24);
            this.MenuFornecedor.Text = "Cadastrar";
            this.MenuFornecedor.Click += new System.EventHandler(this.MenuFornecedor_Click);
            // 
            // MenuConsultarFornecedor
            // 
            this.MenuConsultarFornecedor.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuConsultarFornecedor.Name = "MenuConsultarFornecedor";
            this.MenuConsultarFornecedor.Size = new System.Drawing.Size(141, 24);
            this.MenuConsultarFornecedor.Text = "Consultar";
            this.MenuConsultarFornecedor.Click += new System.EventHandler(this.MenuConsultarFornecedor_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduto,
            this.MenuConsultarProd,
            this.CadastrarTiposProd,
            this.ConsultarTiposProd});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.produtoToolStripMenuItem.Text = "Produtos";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // MenuProduto
            // 
            this.MenuProduto.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(265, 24);
            this.MenuProduto.Text = "Cadastrar";
            this.MenuProduto.Click += new System.EventHandler(this.MenuProduto_Click);
            // 
            // MenuConsultarProd
            // 
            this.MenuConsultarProd.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuConsultarProd.Name = "MenuConsultarProd";
            this.MenuConsultarProd.Size = new System.Drawing.Size(265, 24);
            this.MenuConsultarProd.Text = "Consultar";
            this.MenuConsultarProd.Click += new System.EventHandler(this.MenuConsultarProd_Click);
            // 
            // CadastrarTiposProd
            // 
            this.CadastrarTiposProd.BackColor = System.Drawing.Color.AliceBlue;
            this.CadastrarTiposProd.Name = "CadastrarTiposProd";
            this.CadastrarTiposProd.Size = new System.Drawing.Size(265, 24);
            this.CadastrarTiposProd.Text = "Cadastrar Tipos de Produtos";
            this.CadastrarTiposProd.Click += new System.EventHandler(this.CadastrarTiposProd_Click);
            // 
            // ConsultarTiposProd
            // 
            this.ConsultarTiposProd.BackColor = System.Drawing.Color.AliceBlue;
            this.ConsultarTiposProd.Name = "ConsultarTiposProd";
            this.ConsultarTiposProd.Size = new System.Drawing.Size(265, 24);
            this.ConsultarTiposProd.Text = "Consultar Tipos de Produtos";
            this.ConsultarTiposProd.Click += new System.EventHandler(this.ConsultarTiposProd_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCompras,
            this.MenuConsultarCompras});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // MenuCompras
            // 
            this.MenuCompras.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(141, 24);
            this.MenuCompras.Text = "Cadastrar";
            this.MenuCompras.Click += new System.EventHandler(this.MenuCompras_Click);
            // 
            // MenuConsultarCompras
            // 
            this.MenuConsultarCompras.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuConsultarCompras.Name = "MenuConsultarCompras";
            this.MenuConsultarCompras.Size = new System.Drawing.Size(141, 24);
            this.MenuConsultarCompras.Text = "Consultar";
            this.MenuConsultarCompras.Click += new System.EventHandler(this.MenuConsultarCompras_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVenda,
            this.MenuConsultarVenda});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.vendaToolStripMenuItem.Text = "Vendas";
            // 
            // MenuVenda
            // 
            this.MenuVenda.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuVenda.Name = "MenuVenda";
            this.MenuVenda.Size = new System.Drawing.Size(185, 24);
            this.MenuVenda.Text = "Efetuar Venda";
            this.MenuVenda.Click += new System.EventHandler(this.MenuVenda_Click);
            // 
            // MenuConsultarVenda
            // 
            this.MenuConsultarVenda.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuConsultarVenda.Name = "MenuConsultarVenda";
            this.MenuConsultarVenda.Size = new System.Drawing.Size(185, 24);
            this.MenuConsultarVenda.Text = "Consultar Venda";
            this.MenuConsultarVenda.Click += new System.EventHandler(this.MenuConsultarVenda_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuáriosToolStripMenuItem,
            this.consultarUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuáriosToolStripMenuItem_Click);
            // 
            // consultarUsuáriosToolStripMenuItem
            // 
            this.consultarUsuáriosToolStripMenuItem.Name = "consultarUsuáriosToolStripMenuItem";
            this.consultarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.consultarUsuáriosToolStripMenuItem.Text = "Consultar Usuários";
            this.consultarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarUsuáriosToolStripMenuItem_Click);
            // 
            // cREDITOSToolStripMenuItem
            // 
            this.cREDITOSToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cREDITOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cREDITOSToolStripMenuItem.Name = "cREDITOSToolStripMenuItem";
            this.cREDITOSToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cREDITOSToolStripMenuItem.Text = "CREDITOS";
            this.cREDITOSToolStripMenuItem.Click += new System.EventHandler(this.cREDITOSToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 28);
            this.panel1.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuCadastrar;
        public System.Windows.Forms.ToolStripMenuItem MenuConsultarCliente;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        public System.Windows.Forms.ToolStripMenuItem MenuConsultarFornecedor;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuProduto;
        public System.Windows.Forms.ToolStripMenuItem MenuConsultarProd;
        public System.Windows.Forms.ToolStripMenuItem CadastrarTiposProd;
        private System.Windows.Forms.ToolStripMenuItem ConsultarTiposProd;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuCompras;
        public System.Windows.Forms.ToolStripMenuItem MenuConsultarCompras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem cREDITOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuVenda;
        public System.Windows.Forms.ToolStripMenuItem MenuConsultarVenda;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
    }
}

