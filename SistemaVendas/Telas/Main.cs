using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaVendas.Telas.Cadastros;
using SistemaVendas.Telas.Cadastros.Movimentacoes;
using SistemaVendas.Telas.Listas;

namespace SistemaVendas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CultureInfo cci = new CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
            cci.NumberFormat.NumberDecimalSeparator = ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaClientes frmListaClientes = new frmListaClientes();
            frmListaClientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           frmListaFornecedores frmListaFornecedores = new frmListaFornecedores();
           frmListaFornecedores.ShowDialog();
        }

        private void CadastrarCompras_Click(object sender, EventArgs e)
        {
            FrmCompras Compras = new FrmCompras(true, 0);
            Compras.ShowDialog();
        }

        private void CadastarProduto_Click(object sender, EventArgs e)
        {
            frmProdutos Produto = new frmProdutos(true, 0);
            Produto.ShowDialog();
            frmListaProdutos Produtos = new frmListaProdutos();
            Produtos.ShowDialog();

        }

        private void EfetuarVendas_Click(object sender, EventArgs e)
        {
            FrmVendas Vendas = new FrmVendas(true, 0);
            Vendas.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuCadastrar_Click(object sender, EventArgs e)
        {
            frmClientes Clientes = new frmClientes(true, 0);
            Clientes.ShowDialog();
        }

        private void MenuCompras_Click(object sender, EventArgs e)
        {
            FrmCompras compras = new FrmCompras(true, 0);
            compras.ShowDialog();
        }

        private void MenuFornecedor_Click(object sender, EventArgs e)
        {
           frmFornecedores fornecedor = new frmFornecedores(true, 0);
           fornecedor.ShowDialog();
        }

        private void MenuProduto_Click(object sender, EventArgs e)
        {
            frmProdutos prod = new frmProdutos(true, 0);
            prod.ShowDialog();
        }

        private void MenuVenda_Click(object sender, EventArgs e)
        {
            FrmVendas Vendas = new FrmVendas(true, 0);
            Vendas.ShowDialog();
        }

        private void MenuConsultarCliente_Click(object sender, EventArgs e)
        {
            frmListaClientes listaClientes = new frmListaClientes();
            listaClientes.ShowDialog();
        }

        private void MenuConsultarFornecedor_Click(object sender, EventArgs e)
        {
            frmListaFornecedores listaFornecedores = new frmListaFornecedores();
            listaFornecedores.ShowDialog();
        }

        private void MenuConsultarCompras_Click(object sender, EventArgs e)
        {
            FrmListaCompras listaComprass = new FrmListaCompras();
            listaComprass.ShowDialog();
            
        }

        private void MenuConsultarProd_Click(object sender, EventArgs e)
        {
            frmListaProdutos listaProdutos = new frmListaProdutos();
            listaProdutos.ShowDialog();
        }

        private void MenuConsultarVenda_Click(object sender, EventArgs e)
        {
            frmListaVendas listaVendas = new frmListaVendas();
            listaVendas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListaTiposProdutos listaProdutos = new frmListaTiposProdutos();            
            listaProdutos.ShowDialog();
        }    

        private void CadastrarTiposProd_Click(object sender, EventArgs e)
        {
            frmTiposProdutos TipoProd = new frmTiposProdutos(true,0);
            TipoProd.ShowDialog();
        }

        private void ConsultarTiposProd_Click(object sender, EventArgs e)
        {
            frmListaTiposProdutos listaProd = new frmListaTiposProdutos();
            listaProd.ShowDialog();
        }

        private void cREDITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creditos cred = new Creditos();
            cred.ShowDialog();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUsuarios = new CadastroUsuario();
            cadUsuarios.ShowDialog();

        }

        private void ConsultarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
