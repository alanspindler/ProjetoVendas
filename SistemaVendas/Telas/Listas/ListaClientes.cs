using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Classes.Movimentacoes;
using SistemaVendas.Telas.Cadastros;

namespace SistemaVendas.Telas.Listas
{
    public partial class frmListaClientes : Form
    {
        public readonly ClasseClientes classeClientes;
        public readonly ClasseVendas classeVendas;

        public frmListaClientes()
        {
            InitializeComponent();
        }

        #region MetodosPrivados
        //Carrega o grid com os dados dos clientes.
        private void ListaClientes_Load(object sender, EventArgs e)
        {
            var classeClientes = new ClasseClientes();
            BindingSourceClientes.DataSource = classeClientes.RetonarDadosTodosClientes();
            DataGridClientes.DataSource = BindingSourceClientes;
            DataGridClientes.RowHeadersVisible = false;
            DataGridClientes.AllowUserToAddRows = false;
            DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridClientes.Columns[0].Visible = false;
            DataGridClientes.Columns[1].HeaderText = "Nome";
            DataGridClientes.Columns[2].HeaderText = "CPF";
            DataGridClientes.Columns[3].HeaderText = "Data de Nascimento";
            DataGridClientes.Columns[4].HeaderText = "Endereço";
            DataGridClientes.Columns[5].HeaderText = "Bairro";
            DataGridClientes.Columns[6].HeaderText = "Cidade";
            DataGridClientes.Columns[7].HeaderText = "Estado";
            DataGridClientes.Columns[8].HeaderText = "Cep";
            DataGridClientes.Columns[9].HeaderText = "Celular";
            DataGridClientes.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.AllCells);
            DataGridClientes.ReadOnly = true;
        }

        //Quando clicar em Alterar, deve chamar a tela de cadastro, passando parametro de alteração e o id da pessoa a ser alterada
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (DataGridClientes.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridClientes.Rows[DataGridClientes.CurrentRow.Index].Cells[0].Value);
                frmClientes frmClientes = new frmClientes(false, id);
                frmClientes.FormClosing += new FormClosingEventHandler(this.FrmClientes_FormClosing);
                frmClientes.Show();
            }
        }

        //Exclui a pessoa selecionada e atualiza o grid.
        private void bntExcluir_Click(object sender, EventArgs e)
        {
            var Clientes = new ClasseClientes();
            var classeVendas = new ClasseVendas();
            if (DataGridClientes.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridClientes.Rows[DataGridClientes.CurrentRow.Index].Cells[0].Value);
                if (classeVendas.ExisteCliente(id))
                {
                    MessageBox.Show("Já existe venda cadastrada para este Cliente, então o mesmo não pode ser excluído");
                    return;
                }
                else
                {
                    Clientes.ExcluirCliente(id);
                    RecarregarGridClientes();
                }
            }

        }

        //Chama a tela de cadastro com parametro de inclusão e id 0.
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes(true, 0);
            frmClientes.FormClosing += new FormClosingEventHandler(this.FrmClientes_FormClosing);
            frmClientes.Show();
        }

        //Quando fechar a tela de clientes, atualiza o grid, pois provavelmente algo foi cadastrado/alterado.
        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecarregarGridClientes();
        }

        //Atualiza as informações do grid com os dados atualizados do banco.
        public void RecarregarGridClientes()
        {
            var classeClientes = new ClasseClientes();
            BindingSourceClientes.DataSource = classeClientes.RetonarDadosTodosClientes();
            DataGridClientes.DataSource = BindingSourceClientes;
        }

        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            var classeClientes = new ClasseClientes();
            string cpf = mskPesqCpf.Text;
            //Valida se o campo CPF está em branco
            if (cpf != "")
            {
                //Valida se o cpf é válido
                if (classeClientes.ValidarCPFCNPJ(cpf, false) == true)
                {
                    int IdCliente = classeClientes.RetornaIdCliente(cpf);
                    BindingSourceClientes.DataSource = classeClientes.RetornaDadosCliente(IdCliente);
                    DataGridClientes.DataSource = BindingSourceClientes;
                    DataGridClientes.RowHeadersVisible = false;
                    DataGridClientes.AllowUserToAddRows = false;
                    DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridClientes.Columns[0].Visible = false;
                    DataGridClientes.Columns[1].HeaderText = "Nome";
                    DataGridClientes.Columns[2].HeaderText = "CPF";
                    DataGridClientes.Columns[3].HeaderText = "Data de Nascimento";
                    DataGridClientes.Columns[4].HeaderText = "Endereço";
                    DataGridClientes.Columns[5].HeaderText = "Bairro";
                    DataGridClientes.Columns[6].HeaderText = "Cidade";
                    DataGridClientes.Columns[7].HeaderText = "Estado";
                    DataGridClientes.Columns[8].HeaderText = "Cep";
                    DataGridClientes.Columns[9].HeaderText = "Celular";
                    DataGridClientes.AutoResizeColumns(
                       DataGridViewAutoSizeColumnsMode.AllCells);
                    DataGridClientes.ReadOnly = true;
                }
                else
                {
                    string Retorno = "Preencha Corretamente o CPF";
                    MessageBox.Show(Retorno);
                    return;
                }
            }

            string nome = txtPesqNome.Text;
            //Valida se o nome está em branco
            if (nome != "")
            {
                string cpfCliente = classeClientes.RetornaCPFCliente(nome);
                int IdCliente = classeClientes.RetornaIdCliente(cpfCliente);
                BindingSourceClientes.DataSource = classeClientes.RetornaDadosCliente(IdCliente);
                DataGridClientes.DataSource = BindingSourceClientes;
                DataGridClientes.RowHeadersVisible = false;
                DataGridClientes.AllowUserToAddRows = false;
                DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridClientes.Columns[0].Visible = false;
                DataGridClientes.Columns[1].HeaderText = "Nome";
                DataGridClientes.Columns[2].HeaderText = "CPF";
                DataGridClientes.Columns[3].HeaderText = "Data de Nascimento";
                DataGridClientes.Columns[4].HeaderText = "Endereço";
                DataGridClientes.Columns[5].HeaderText = "Bairro";
                DataGridClientes.Columns[6].HeaderText = "Cidade";
                DataGridClientes.Columns[7].HeaderText = "Estado";
                DataGridClientes.Columns[8].HeaderText = "Cep";
                DataGridClientes.Columns[9].HeaderText = "Celular";
                DataGridClientes.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.AllCells);
                DataGridClientes.ReadOnly = true;
            }
        }

        //Limpa a pesquisa, recarrega o grid com os dados sem filtro
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            var classeClientes = new ClasseClientes();
            BindingSourceClientes.DataSource = classeClientes.RetonarDadosTodosClientes();
            DataGridClientes.DataSource = BindingSourceClientes;
            DataGridClientes.RowHeadersVisible = false;
            DataGridClientes.AllowUserToAddRows = false;
            DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridClientes.Columns[0].Visible = false;
            DataGridClientes.Columns[1].HeaderText = "Nome";
            DataGridClientes.Columns[2].HeaderText = "CPF";
            DataGridClientes.Columns[3].HeaderText = "Data de Nascimento";
            DataGridClientes.Columns[4].HeaderText = "Endereço";
            DataGridClientes.Columns[5].HeaderText = "Bairro";
            DataGridClientes.Columns[6].HeaderText = "Cidade";
            DataGridClientes.Columns[7].HeaderText = "Estado";
            DataGridClientes.Columns[8].HeaderText = "Cep";
            DataGridClientes.Columns[9].HeaderText = "Celular";
            DataGridClientes.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.AllCells);
            DataGridClientes.ReadOnly = true;
        }
        #endregion
    }
}




