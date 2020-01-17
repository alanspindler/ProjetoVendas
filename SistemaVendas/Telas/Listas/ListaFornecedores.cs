using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Classes.Movimentacoes;
using SistemaVendas.Telas.Cadastros;

namespace SistemaVendas.Telas.Listas
{
    public partial class frmListaFornecedores : Form
    {
        public readonly ClasseFornecedores classeFornecdores;
        public readonly ClasseCompras classeCompras;
        public readonly ClasseClientes classeClientes;

        public frmListaFornecedores()
        {
            InitializeComponent();
        }

        #region Metodos Privados

        //Carrega o grid
        private void ListaFornecedores_Load(object sender, EventArgs e)
        {
            var classeFornecedores = new ClasseFornecedores();
            BindingSourceFornecedores.DataSource = classeFornecedores.RetonarDadosTodosFornecedores();
            DataGridFornecedores.DataSource = BindingSourceFornecedores;
            DataGridFornecedores.RowHeadersVisible = false;
            DataGridFornecedores.AllowUserToAddRows = false;
            DataGridFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridFornecedores.Columns[0].Visible = false;
            DataGridFornecedores.Columns[1].HeaderText = "Razão Social";
            DataGridFornecedores.Columns[2].HeaderText = "CNPJ";
            DataGridFornecedores.Columns[3].HeaderText = "Endereço";
            DataGridFornecedores.Columns[4].HeaderText = "Bairro";
            DataGridFornecedores.Columns[5].HeaderText = "Cidade";
            DataGridFornecedores.Columns[6].HeaderText = "Estado";
            DataGridFornecedores.Columns[7].HeaderText = "Cep";
            DataGridFornecedores.Columns[8].HeaderText = "Telefone";
            DataGridFornecedores.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridFornecedores.ReadOnly = true;
        }

        //Chama a tela de cadastro com parametro de inclusão e id 0.
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmFornecedores frmFornecedores = new frmFornecedores(true, 0);
            frmFornecedores.FormClosing += new FormClosingEventHandler(this.FrmFornecedores_FormClosing);
            frmFornecedores.Show();
        }

        //Quando fechar a tela de clientes, atualiza o grid, pois provavelmente algo foi cadastrado/alterado.
        private void FrmFornecedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecarregarGridFornecedores();
        }

        //Abre a tela de cadastro para alterar o item selecionado.
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (DataGridFornecedores.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridFornecedores.Rows[DataGridFornecedores.CurrentRow.Index].Cells[0].Value);
                frmFornecedores frmFornecedores = new frmFornecedores(false, id);
                frmFornecedores.FormClosing += new FormClosingEventHandler(this.FrmFornecedores_FormClosing);
                frmFornecedores.Show();
            }
        }

        //Exclui o item selecionado
        private void bntExcluir_Click(object sender, EventArgs e)
        {
            var Fornecedores = new ClasseFornecedores();
            var classeCompras = new ClasseCompras();
            {
                if (DataGridFornecedores.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(DataGridFornecedores.Rows[DataGridFornecedores.CurrentRow.Index].Cells[0].Value);
                    //Valida se existe compra utilizando esse fornecedor. Se tiver, não permite excluir
                    if (classeCompras.ExisteFornecedor(id))
                    {
                        MessageBox.Show("Já existe compra cadastrada utilizando este fornecedor, então o mesmo não pode ser excluído");
                        return;
                    }
                    else
                    {
                        Fornecedores.ExcluirFornecedor(id);
                        RecarregarGridFornecedores();
                    }
                }
            }
        }

        //Pesquisa pelo campo que estiver preenchido
        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            var classeFornecedores = new ClasseFornecedores();
            var classeClientes = new ClasseClientes();
            string cnpj = mskpesqCnpj.Text;
            //Se o CNPJ estiver preenchido, pesquisa por ele
            if (cnpj != "")
            {
                if (classeClientes.ValidarCPFCNPJ(cnpj, false) == true)
                {
                    int IdFornecedor = classeFornecedores.RetornaIdFornecedor(cnpj);
                    BindingSourceFornecedores.DataSource = classeFornecedores.RetornaDadosFornecedor(IdFornecedor);
                    DataGridFornecedores.DataSource = BindingSourceFornecedores;
                    DataGridFornecedores.RowHeadersVisible = false;
                    DataGridFornecedores.AllowUserToAddRows = false;
                    DataGridFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridFornecedores.Columns[0].Visible = false;
                    DataGridFornecedores.Columns[1].HeaderText = "Razão Social";
                    DataGridFornecedores.Columns[2].HeaderText = "CNPJ";
                    DataGridFornecedores.Columns[3].HeaderText = "Endereço";
                    DataGridFornecedores.Columns[4].HeaderText = "Bairro";
                    DataGridFornecedores.Columns[5].HeaderText = "Cidade";
                    DataGridFornecedores.Columns[6].HeaderText = "Estado";
                    DataGridFornecedores.Columns[7].HeaderText = "Cep";
                    DataGridFornecedores.Columns[8].HeaderText = "Telefone";
                    DataGridFornecedores.AutoResizeColumns(
                       DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    DataGridFornecedores.ReadOnly = true;
                }
                else
                {
                    string Retorno = "Preencha Corretamente o CNPJ";
                    MessageBox.Show(Retorno);
                    return;
                }
            }

            string razaoSocial = txtpesqRazao.Text;
            //Se o a razão social estiver preenchido, pesquisa por ele
            if (razaoSocial != "")
            {
                int IdFornecedor = classeFornecedores.RetornaIdFornecedorPelaRazaoSocial(razaoSocial);
                BindingSourceFornecedores.DataSource = classeFornecedores.RetornaDadosFornecedor(IdFornecedor);
                DataGridFornecedores.DataSource = BindingSourceFornecedores;
                DataGridFornecedores.RowHeadersVisible = false;
                DataGridFornecedores.AllowUserToAddRows = false;
                DataGridFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridFornecedores.Columns[0].Visible = false;
                DataGridFornecedores.Columns[1].HeaderText = "Razão Social";
                DataGridFornecedores.Columns[2].HeaderText = "CNPJ";
                DataGridFornecedores.Columns[3].HeaderText = "Endereço";
                DataGridFornecedores.Columns[4].HeaderText = "Bairro";
                DataGridFornecedores.Columns[5].HeaderText = "Cidade";
                DataGridFornecedores.Columns[6].HeaderText = "Estado";
                DataGridFornecedores.Columns[7].HeaderText = "Cep";
                DataGridFornecedores.Columns[8].HeaderText = "Telefone";
                DataGridFornecedores.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.DisplayedCells);
                DataGridFornecedores.ReadOnly = true;
            }
        }

        //Limpa a pesquisa, recarrega o grid com os dados sem filtro
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            var classeFornecedores = new ClasseFornecedores();
            BindingSourceFornecedores.DataSource = classeFornecedores.RetonarDadosTodosFornecedores();
            DataGridFornecedores.DataSource = BindingSourceFornecedores;
            DataGridFornecedores.RowHeadersVisible = false;
            DataGridFornecedores.AllowUserToAddRows = false;
            DataGridFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridFornecedores.Columns[0].Visible = false;
            DataGridFornecedores.Columns[1].HeaderText = "Razão Social";
            DataGridFornecedores.Columns[2].HeaderText = "CNPJ";
            DataGridFornecedores.Columns[3].HeaderText = "Endereço";
            DataGridFornecedores.Columns[4].HeaderText = "Bairro";
            DataGridFornecedores.Columns[5].HeaderText = "Cidade";
            DataGridFornecedores.Columns[6].HeaderText = "Estado";
            DataGridFornecedores.Columns[7].HeaderText = "Cep";
            DataGridFornecedores.Columns[8].HeaderText = "Telefone";
            DataGridFornecedores.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridFornecedores.ReadOnly = true;
        }

        #endregion

        #region Metodos Publicos

        //Atualiza as informações do grid com os dados atualizados do banco.
        public void RecarregarGridFornecedores()
        {
            var classeFornecedores = new ClasseFornecedores();
            BindingSourceFornecedores.DataSource = classeFornecedores.RetonarDadosTodosFornecedores();
            DataGridFornecedores.DataSource = BindingSourceFornecedores;
        }

        #endregion
    }
}

