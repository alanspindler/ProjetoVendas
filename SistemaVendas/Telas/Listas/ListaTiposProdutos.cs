using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Cadastros;

namespace SistemaVendas.Telas.Listas
{
    public partial class frmListaTiposProdutos : Form
    {
        public readonly ClasseProdutos classeProdutos;

        public frmListaTiposProdutos()
        {
            InitializeComponent();
        }

        #region Metodos Privados

        //Carrega o grid com os dados dos clientes.
        private void ListaTipoProdutos_Load(object sender, EventArgs e)
        {
            var classeTiposProdutos = new ClasseTiposProdutos();
            BindingSourceTiposProdutos.DataSource = classeTiposProdutos.RetonarDadosTodosTiposProdutos();
            DataGridTiposProdutos.DataSource = BindingSourceTiposProdutos;
            DataGridTiposProdutos.RowHeadersVisible = false;
            DataGridTiposProdutos.AllowUserToAddRows = false;
            DataGridTiposProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridTiposProdutos.Columns[0].Visible = false;
            DataGridTiposProdutos.Columns[1].HeaderText = "Descrição";
            DataGridTiposProdutos.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridTiposProdutos.ReadOnly = true;
        }

        //Cadastra um novo item. Botão foi excluido
        private void ListaCadastrar_Click(object sender, EventArgs e)
        {
            frmTiposProdutos frmTiposProdutos = new frmTiposProdutos(true, 0);
            frmTiposProdutos.FormClosing += new FormClosingEventHandler(this.FrmTiposProdutos_FormClosing);
            frmTiposProdutos.Show();
        }

        //Quando fechar a tela de clientes, atualiza o grid, pois provavelmente algo foi cadastrado/alterado.
        private void FrmTiposProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecarregarGridTiposProdutos();
        }

        //Altera o item selecionado.
        private void ListaAlterar_Click(object sender, EventArgs e)
        {
            if (DataGridTiposProdutos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridTiposProdutos.Rows[DataGridTiposProdutos.CurrentRow.Index].Cells[0].Value);
                frmTiposProdutos frmTiposProdutos = new frmTiposProdutos(false, id);
                frmTiposProdutos.FormClosing += new FormClosingEventHandler(this.FrmTiposProdutos_FormClosing);
                frmTiposProdutos.Show();
            }
        }

        //Exclui o item selecionado.
        private void ListaExcluir_Click(object sender, EventArgs e)
        {
            var TiposProdutos = new ClasseTiposProdutos();
            var classeProdutos = new ClasseProdutos();
            if (DataGridTiposProdutos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridTiposProdutos.Rows[DataGridTiposProdutos.CurrentRow.Index].Cells[0].Value);
                //Valida se já o tipo de produto já foi utilizado em algum produto. Se foi, não pode excluir.
                if (classeProdutos.ExisteTipoProduto(id))
                {
                    MessageBox.Show("Já existe produto cadastrado utilizando este tipo de produto, então o mesmo não pode ser excluído");
                    return;
                }
                TiposProdutos.ExcluirTipoProduto(id);
                RecarregarGridTiposProdutos();
            }
        }

        //Pesquisa pelo campo que estiver preenchido
        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            var classeTiposProdutos = new ClasseTiposProdutos();
            string descricao = txtpesqTipoProd.Text;
            //Se o campo Descricao estiver preenchido, pesquisa por ele
            if (descricao != "")
            {
                int IdProduto = classeTiposProdutos.RetornaIdTipoProduto(descricao);
                BindingSourceTiposProdutos.DataSource = classeTiposProdutos.RetornaDadosTipoProduto(IdProduto);
                DataGridTiposProdutos.DataSource = BindingSourceTiposProdutos;
                DataGridTiposProdutos.RowHeadersVisible = false;
                DataGridTiposProdutos.AllowUserToAddRows = false;
                DataGridTiposProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridTiposProdutos.Columns[0].Visible = false;
                DataGridTiposProdutos.Columns[1].HeaderText = "Descrição";
                DataGridTiposProdutos.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.DisplayedCells);
                DataGridTiposProdutos.ReadOnly = true;
            }
        }

        //Limpa a pesquisa, recarrega o grid com os dados sem filtro.
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            RecarregarGridTiposProdutos();
        }

        #endregion

        #region Metodos Publicos

        //Atualiza as informações do grid com os dados atualizados do banco.
        public void RecarregarGridTiposProdutos()
        {
            var classeTiposProdutos = new ClasseTiposProdutos();
            BindingSourceTiposProdutos.DataSource = classeTiposProdutos.RetonarDadosTodosTiposProdutos();
            DataGridTiposProdutos.DataSource = BindingSourceTiposProdutos;
            DataGridTiposProdutos.Columns[1].HeaderText = "Descrição";
        }

        #endregion
    }
}
