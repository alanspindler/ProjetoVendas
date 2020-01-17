using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Classes.Movimentacoes;
using SistemaVendas.Telas.Cadastros;

namespace SistemaVendas.Telas.Listas
{
    public partial class frmListaProdutos : Form
    {
        public readonly ClasseProdutos classeProdutos;
        public readonly ClasseCompras classeCompras;

        public frmListaProdutos()
        {
            InitializeComponent();
        }

        #region Metodos Privados
        //Carrega o grid com os dados dos clientes.
        private void ListaProdutos_Load(object sender, EventArgs e)
        {
            var classeProdutos = new ClasseProdutos();
            BindingSourceProdutos.DataSource = classeProdutos.RetonarDadosTodosProdutos();
            DataGridProdutos.DataSource = BindingSourceProdutos;
            DataGridProdutos.RowHeadersVisible = false;
            DataGridProdutos.AllowUserToAddRows = false;
            DataGridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridProdutos.Columns[0].Visible = false;
            DataGridProdutos.Columns[1].HeaderText = "Codigo";
            DataGridProdutos.Columns[2].HeaderText = "Descricao";
            DataGridProdutos.Columns[3].HeaderText = "Quantidade";
            DataGridProdutos.Columns[4].HeaderText = "Tipo Produto";
            DataGridProdutos.Columns[5].HeaderText = "Sub Gênero";
            DataGridProdutos.Columns[6].HeaderText = "Valor Unitário";
            //DataGridProdutos.Columns[7].HeaderText = "Disponivel Venda";         
            DataGridProdutos.Columns[7].Visible = false;
            DataGridProdutos.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridProdutos.ReadOnly = true;
        }

        //Quando fechar a tela de clientes, atualiza o grid, pois provavelmente algo foi cadastrado/alterado.
        private void FrmProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecarregarGridProdutos();
        }
        
        //Inclui um novo produto. O botão foi excluido
        private void ListaCadastrar_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos(true, 0);
            frmProdutos.FormClosing += new FormClosingEventHandler(this.FrmProdutos_FormClosing);
            frmProdutos.Show();
        }

        //Altera o item selecionado
        private void ListaAlterar_Click(object sender, EventArgs e)
        {
            if (DataGridProdutos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridProdutos.Rows[DataGridProdutos.CurrentRow.Index].Cells[0].Value);
                frmProdutos frmProdutos = new frmProdutos(false, id);
                frmProdutos.FormClosing += new FormClosingEventHandler(this.FrmProdutos_FormClosing);
                frmProdutos.Show();
            }
        }

        //Exclui o item selecionado.
        private void ListaExcluir_Click(object sender, EventArgs e)
        {
            var classeProdutos = new ClasseProdutos();
            var classeCompras = new ClasseCompras();
            var classeVendas = new ClasseVendas();
            if (DataGridProdutos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridProdutos.Rows[DataGridProdutos.CurrentRow.Index].Cells[0].Value);
                //Valida se existe compra utilizando esse produto. Se tiver, não permite excluir
                if (classeCompras.ExisteProduto(id))
                {
                    MessageBox.Show("Já existe compra cadastrada utilizando este produto, então o mesmo não pode ser excluído");
                    return;
                }
                if (classeVendas.ExisteProduto(id))
                {
                    MessageBox.Show("Já existe venda cadastrada utilizando este produto, então o mesmo não pode ser excluído");
                    return;
                }
                else
                {
                    classeProdutos.ExcluirProduto(id);
                    RecarregarGridProdutos();
                }
            }
        }
        
        //Pesquisa pelo campo que estiver preenchido
        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            var classeProdutos = new ClasseProdutos();
            string descricao = txtpesqProdu.Text;
            //Se o campo Descricao estiver preenchido, pesquisa por ele
            if (descricao != "")
            {
                int IdProduto = classeProdutos.RetornaIdProduto(descricao);
                BindingSourceProdutos.DataSource = classeProdutos.RetornaDadosProduto(IdProduto);
                DataGridProdutos.DataSource = BindingSourceProdutos;
                DataGridProdutos.RowHeadersVisible = false;
                DataGridProdutos.AllowUserToAddRows = false;
                DataGridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridProdutos.Columns[0].Visible = false;
                DataGridProdutos.Columns[1].HeaderText = "Codigo";
                DataGridProdutos.Columns[2].HeaderText = "Descricao";
                DataGridProdutos.Columns[3].HeaderText = "Quantidade";
                DataGridProdutos.Columns[4].HeaderText = "Tipo Produto";
                DataGridProdutos.Columns[5].HeaderText = "Sub Gênero";
                DataGridProdutos.Columns[6].HeaderText = "Valor Unitário";
                DataGridProdutos.Columns[7].HeaderText = "Disponivel Venda";
                DataGridProdutos.Columns[7].Visible = false;
                DataGridProdutos.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.DisplayedCells);
                DataGridProdutos.ReadOnly = true;
            }

            string codigo = txtpesqCod.Text;

            //Se o campo Codigo estiver preenchido, pesquisa por ele
            if (codigo != "")
            {
                if (!int.TryParse(codigo, out int Incorreto))
                {
                    string Retorno = "Preencha Corretamente o Codigo da Venda";
                    MessageBox.Show(Retorno);
                    return;
                }
                int codigoProduto = Convert.ToInt32(codigo);
                int IdProduto = classeProdutos.RetornaIdProduto(codigoProduto);
                BindingSourceProdutos.DataSource = classeProdutos.RetornaDadosProduto(IdProduto);
                DataGridProdutos.DataSource = BindingSourceProdutos;
                DataGridProdutos.RowHeadersVisible = false;
                DataGridProdutos.AllowUserToAddRows = false;
                DataGridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridProdutos.Columns[0].Visible = false;
                DataGridProdutos.Columns[1].HeaderText = "Codigo";
                DataGridProdutos.Columns[2].HeaderText = "Descricao";
                DataGridProdutos.Columns[3].HeaderText = "Quantidade";
                DataGridProdutos.Columns[4].HeaderText = "Tipo Produto";
                DataGridProdutos.Columns[5].HeaderText = "Sub Gênero";
                DataGridProdutos.Columns[6].HeaderText = "Valor Unitário";
                //DataGridProdutos.Columns[7].HeaderText = "Disponivel Venda";            
                DataGridProdutos.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.DisplayedCells);
                DataGridProdutos.ReadOnly = true;
            }
        }

        //Limpa a pesquisa, recarrega o grid com os dados originais
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            RecarregarGridProdutos();
        }

        #endregion

        #region Metodos Publicos
        //Atualiza as informações do grid com os dados atualizados do banco.
        public void RecarregarGridProdutos()
        {
            var classeProdutos = new ClasseProdutos();
            BindingSourceProdutos.DataSource = classeProdutos.RetonarDadosTodosProdutos();
            DataGridProdutos.DataSource = BindingSourceProdutos;
            DataGridProdutos.Columns[0].Visible = false;
            DataGridProdutos.Columns[7].Visible = false;
        }

        #endregion
    }
}
