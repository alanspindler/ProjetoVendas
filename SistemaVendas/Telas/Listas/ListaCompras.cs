using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Cadastros;
using SistemaVendas.Classes.Movimentacoes;

namespace SistemaVendas.Telas.Listas
{
    public partial class FrmListaCompras : Form
    {
        public readonly ClasseCompras classeCompras;
        public readonly FrmCompras frmCompras;
        public readonly ClasseClientes classeClientes;
        public readonly ClasseFornecedores classeFornecedores;
        public readonly ClasseProdutos classeProdutos;

        public FrmListaCompras()
        {
            InitializeComponent();
        }

        #region Metodos Privados
        //Carrega o grid com os dados dos clientes.
        private void ListaCompras_Load(object sender, EventArgs e)
        {
            var classeCompras = new ClasseCompras();
            BindingSourceCompras.DataSource = classeCompras.RetonarDadosTodasCompras();
            DataGridCompras.DataSource = BindingSourceCompras;
            DataGridCompras.RowHeadersVisible = false;
            DataGridCompras.AllowUserToAddRows = false;
            DataGridCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCompras.Columns[0].Visible = false;
            DataGridCompras.Columns[1].HeaderText = "Data da Compra";
            DataGridCompras.Columns[2].HeaderText = "Codigo do Produto";
            DataGridCompras.Columns[3].HeaderText = "Produto";
            DataGridCompras.Columns[4].HeaderText = "Fornecedor";
            DataGridCompras.Columns[5].HeaderText = "CNPJ";
            DataGridCompras.Columns[6].HeaderText = "Quantidade";
            DataGridCompras.Columns[7].HeaderText = "Valor Total";
            DataGridCompras.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridCompras.ReadOnly = true;
        }

        //Quando fechar a tela de clientes, atualiza o grid, pois provavelmente algo foi cadastrado/alterado.
        private void FrmCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecarregarGridCompras();
        }

        //Abre a tela de cadastro para incluir uma nova compra.
        private void CadastrarCom_Click(object sender, EventArgs e)
        {
            FrmCompras frmCompras = new FrmCompras(true, 0);
            frmCompras.FormClosing += new FormClosingEventHandler(this.FrmCompras_FormClosing);
            frmCompras.Show();
        }

        //Abre a tela de cadastro para alteração com os dados do item da grid selecionado
        private void AlterarCom_Click(object sender, EventArgs e)
        {
            if (DataGridCompras.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridCompras.Rows[DataGridCompras.CurrentRow.Index].Cells[0].Value);
                FrmCompras frmCompras = new FrmCompras(false, id);
                frmCompras.FormClosing += new FormClosingEventHandler(this.FrmCompras_FormClosing);
                frmCompras.Show();
            }
        }

        //Pesquisa pelo campo que estiver preenchido
        private void pesqCompras_Click(object sender, EventArgs e)
        {
            var classeCompras = new ClasseCompras();
            var classeClientes = new ClasseClientes();
            var classeFornecedores = new ClasseFornecedores();
            var classeProdutos = new ClasseProdutos();
            string cnpj = mskPesqCNPJ.Text;
            string fornecedor = TxtPesqFornecedor.Text;
            string produto = textpesqNome.Text;
            //Se o CNPJ estiver preenchido, pesquisa por ele
            if (cnpj != "")
            {
                if (classeClientes.ValidarCPFCNPJ(cnpj, false) == true)
                {
                    int IdFornecedor = classeFornecedores.RetornaIdFornecedor(cnpj);
                    BindingSourceCompras.DataSource = classeCompras.RetornaDadosCompraPorFornecedor(IdFornecedor);
                    DataGridCompras.DataSource = BindingSourceCompras;
                    DataGridCompras.RowHeadersVisible = false;
                    DataGridCompras.AllowUserToAddRows = false;
                    DataGridCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridCompras.Columns[0].Visible = false;
                    DataGridCompras.Columns[1].HeaderText = "Data da Compra";
                    DataGridCompras.Columns[2].HeaderText = "Codigo do Produto";
                    DataGridCompras.Columns[3].HeaderText = "Produto";
                    DataGridCompras.Columns[4].HeaderText = "Fornecedor";
                    DataGridCompras.Columns[5].HeaderText = "CNPJ";
                    DataGridCompras.Columns[6].HeaderText = "Quantidade";
                    DataGridCompras.Columns[7].HeaderText = "Valor Total";
                    DataGridCompras.AutoResizeColumns(
                       DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    DataGridCompras.ReadOnly = true;
                }
                else
                {
                    string Retorno = "Preencha Corretamente o CPF";
                    MessageBox.Show(Retorno);
                    return;
                }
            }
            else
            {
                {
                    //Se a razão social do fornecedor estiver preenchido, pesquisa por ele
                    if (fornecedor != "")
                    {
                        int IdFornecedor = classeFornecedores.RetornaIdFornecedorPelaRazaoSocial(fornecedor);
                        BindingSourceCompras.DataSource = classeCompras.RetornaDadosCompraPorFornecedor(IdFornecedor);
                        DataGridCompras.DataSource = BindingSourceCompras;
                        DataGridCompras.RowHeadersVisible = false;
                        DataGridCompras.AllowUserToAddRows = false;
                        DataGridCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        DataGridCompras.Columns[0].Visible = false;
                        DataGridCompras.Columns[1].HeaderText = "Data da Compra";
                        DataGridCompras.Columns[2].HeaderText = "Codigo do Produto";
                        DataGridCompras.Columns[3].HeaderText = "Produto";
                        DataGridCompras.Columns[4].HeaderText = "Fornecedor";
                        DataGridCompras.Columns[5].HeaderText = "CNPJ";
                        DataGridCompras.Columns[6].HeaderText = "Quantidade";
                        DataGridCompras.Columns[7].HeaderText = "Valor Total";
                        DataGridCompras.AutoResizeColumns(
                           DataGridViewAutoSizeColumnsMode.DisplayedCells);
                        DataGridCompras.ReadOnly = true;
                    }
                    else
                    {
                        //Se o nome do produto estiver preenchido, pesquisa por ele
                        if (produto != "")
                        {
                            int IdProduto = classeProdutos.RetornaIdProduto(produto);
                            BindingSourceCompras.DataSource = classeCompras.RetornaDadosCompraPorProduto(IdProduto);
                            DataGridCompras.DataSource = BindingSourceCompras;
                            DataGridCompras.RowHeadersVisible = false;
                            DataGridCompras.AllowUserToAddRows = false;
                            DataGridCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            DataGridCompras.Columns[0].Visible = false;
                            DataGridCompras.Columns[1].HeaderText = "Data da Compra";
                            DataGridCompras.Columns[2].HeaderText = "Codigo do Produto";
                            DataGridCompras.Columns[3].HeaderText = "Produto";
                            DataGridCompras.Columns[4].HeaderText = "Fornecedor";
                            DataGridCompras.Columns[5].HeaderText = "CNPJ";
                            DataGridCompras.Columns[6].HeaderText = "Quantidade";
                            DataGridCompras.Columns[7].HeaderText = "Valor Total";
                            DataGridCompras.AutoResizeColumns(
                               DataGridViewAutoSizeColumnsMode.DisplayedCells);
                            DataGridCompras.ReadOnly = true;
                        }
                    }
                }
            }
        }

        //Limpa a pesquisa, recarrega o grid sem o filtro
        private void btnLimpar_Click(object sender, EventArgs e)
        {

            var classeCompras = new ClasseCompras();
            BindingSourceCompras.DataSource = classeCompras.RetonarDadosTodasCompras();
            DataGridCompras.DataSource = BindingSourceCompras;
            DataGridCompras.RowHeadersVisible = false;
            DataGridCompras.AllowUserToAddRows = false;
            DataGridCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCompras.Columns[0].Visible = false;
            DataGridCompras.Columns[1].HeaderText = "Data da Compra";
            DataGridCompras.Columns[2].HeaderText = "Codigo do Produto";
            DataGridCompras.Columns[3].HeaderText = "Produto";
            DataGridCompras.Columns[4].HeaderText = "Fornecedor";
            DataGridCompras.Columns[5].HeaderText = "CNPJ";
            DataGridCompras.Columns[6].HeaderText = "Quantidade";
            DataGridCompras.Columns[7].HeaderText = "Valor Total";
            DataGridCompras.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridCompras.ReadOnly = true;
        }


        private void ExcluirCompra_Click(object sender, EventArgs e)
        {
            var classeCompras = new ClasseCompras();
            {
                if (DataGridCompras.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(DataGridCompras.Rows[DataGridCompras.CurrentRow.Index].Cells[0].Value);
                    {
                        classeCompras.ExcluirCompra(id);
                        RecarregarGridCompras();
                    }
                }
            }
        }
        #endregion

        #region Metodos Publicos
        //Atualiza as informações do grid com os dados atualizados do banco.
        public void RecarregarGridCompras()
        {
            var classeCompras = new ClasseCompras();
            BindingSourceCompras.DataSource = classeCompras.RetonarDadosTodasCompras();
            DataGridCompras.DataSource = BindingSourceCompras;
        }
        #endregion
    }
}

