using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Cadastros;
using SistemaVendas.Classes.Movimentacoes;

namespace SistemaVendas.Telas.Listas
{
    public partial class frmListaVendas : Form
    {
        public readonly ClasseVendas classeVendas;
        public readonly FrmVendas frmVendas;
        public readonly ClasseClientes classeClientes;

        public frmListaVendas()
        {
            var classeVendas = new ClasseVendas();
            InitializeComponent();
        }

        //Carrega o grid ao iniciar.
        private void ListaVendas_Load(object sender, EventArgs e)
        {
            var classeVendas = new ClasseVendas();
            BindingSourceVendas.DataSource = classeVendas.RetonarDadosTodasVendas();
            DataGridVendas.DataSource = BindingSourceVendas;
            DataGridVendas.RowHeadersVisible = false;
            DataGridVendas.AllowUserToAddRows = false;
            DataGridVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridVendas.Columns[0].Visible = true;
            DataGridVendas.Columns[0].HeaderText = "Código da Venda";
            DataGridVendas.Columns[1].HeaderText = "Data da Venda";
            DataGridVendas.Columns[2].HeaderText = "Codigo do Produto";
            DataGridVendas.Columns[3].HeaderText = "Produto";
            DataGridVendas.Columns[4].HeaderText = "Cliente";
            DataGridVendas.Columns[5].HeaderText = "Quantidade";
            DataGridVendas.Columns[6].HeaderText = "Valor Total";
            DataGridVendas.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridVendas.ReadOnly = true;
        }       

        //Pesquisa pelo campo que estiver preenchido
        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            var classeVendas = new ClasseVendas();            
            var classeClientes = new ClasseClientes();
            //Se o campo Codigo estiver preenchido, pesquisa por ele
            if (txtCodListaVenda.Text != "")
            {
                if (!int.TryParse(txtCodListaVenda.Text, out int Incorreto))
                {
                    string Retorno = "Preencha Corretamente o Codigo da Venda";
                    MessageBox.Show(Retorno);
                    return;
                }
                int IdVenda = Int32.Parse(txtCodListaVenda.Text);
                BindingSourceVendas.DataSource = classeVendas.RetornaDadosVenda(IdVenda);
                DataGridVendas.DataSource = BindingSourceVendas;
                DataGridVendas.RowHeadersVisible = false;
                DataGridVendas.AllowUserToAddRows = false;
                DataGridVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridVendas.Columns[0].Visible = true;
                DataGridVendas.Columns[0].HeaderText = "Código da Venda";
                DataGridVendas.Columns[1].HeaderText = "Data da Venda";
                DataGridVendas.Columns[2].HeaderText = "Codigo do Produto";
                DataGridVendas.Columns[3].HeaderText = "Produto";
                DataGridVendas.Columns[4].HeaderText = "Cliente";
                DataGridVendas.Columns[5].HeaderText = "Quantidade";
                DataGridVendas.Columns[6].HeaderText = "Valor Total";
                DataGridVendas.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.DisplayedCells);
                DataGridVendas.ReadOnly = true;
            }
            //Se o campo Cliente estiver preenchido, pesquisa por ele
            if (textpesNomeV.Text != "")
            {
                string cpfCliente = classeClientes.RetornaCPFCliente(textpesNomeV.Text);
                int idCliente = classeClientes.RetornaIdCliente(cpfCliente);                
                BindingSourceVendas.DataSource = classeVendas.RetornaDadosVendaCliente(idCliente);
                DataGridVendas.DataSource = BindingSourceVendas;
                DataGridVendas.RowHeadersVisible = false;
                DataGridVendas.AllowUserToAddRows = false;
                DataGridVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridVendas.Columns[0].Visible = true;
                DataGridVendas.Columns[0].HeaderText = "Código da Venda";
                DataGridVendas.Columns[1].HeaderText = "Data da Venda";
                DataGridVendas.Columns[2].HeaderText = "Codigo do Produto";
                DataGridVendas.Columns[3].HeaderText = "Produto";
                DataGridVendas.Columns[4].HeaderText = "Cliente";
                DataGridVendas.Columns[5].HeaderText = "Quantidade";
                DataGridVendas.Columns[6].HeaderText = "Valor Total";
                DataGridVendas.AutoResizeColumns(
                   DataGridViewAutoSizeColumnsMode.DisplayedCells);
                DataGridVendas.ReadOnly = true;
            }

            //Se o campo Data estiver preenchido, pesquisa por ele
            if (mskDataListaVenda.Text != ("  /  /"))
            {
                if (classeVendas.ValidarData(mskDataListaVenda.Text))
                {
                    DateTime Data = Convert.ToDateTime(mskDataListaVenda.Text);
                    BindingSourceVendas.DataSource = classeVendas.RetornaDadosVenda(Data);
                    DataGridVendas.DataSource = BindingSourceVendas;
                    DataGridVendas.RowHeadersVisible = false;
                    DataGridVendas.AllowUserToAddRows = false;
                    DataGridVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridVendas.Columns[0].Visible = true;
                    DataGridVendas.Columns[0].HeaderText = "Código da Venda";
                    DataGridVendas.Columns[1].HeaderText = "Data da Venda";
                    DataGridVendas.Columns[2].HeaderText = "Codigo do Produto";
                    DataGridVendas.Columns[3].HeaderText = "Produto";
                    DataGridVendas.Columns[4].HeaderText = "Cliente";
                    DataGridVendas.Columns[5].HeaderText = "Quantidade";
                    DataGridVendas.Columns[6].HeaderText = "Valor Total";
                    DataGridVendas.AutoResizeColumns(
                       DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    DataGridVendas.ReadOnly = true;
                }
            }
        }

        //Limpa a pesquisa, recarrega o grid com os dados originais.
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            var classeVendas = new ClasseVendas();
            BindingSourceVendas.DataSource = classeVendas.RetonarDadosTodasVendas();
            DataGridVendas.DataSource = BindingSourceVendas;
            DataGridVendas.RowHeadersVisible = false;
            DataGridVendas.AllowUserToAddRows = false;
            DataGridVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridVendas.Columns[0].Visible = true;
            DataGridVendas.Columns[0].HeaderText = "Código da Venda";
            DataGridVendas.Columns[1].HeaderText = "Data da Venda";
            DataGridVendas.Columns[2].HeaderText = "Codigo do Produto";
            DataGridVendas.Columns[3].HeaderText = "Produto";
            DataGridVendas.Columns[4].HeaderText = "Cliente";
            DataGridVendas.Columns[5].HeaderText = "Quantidade";
            DataGridVendas.Columns[6].HeaderText = "Valor Total";
            DataGridVendas.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.DisplayedCells);
            DataGridVendas.ReadOnly = true;
            txtCodListaVenda.Text = "";
            mskDataListaVenda.Text = "";
        }
    }
}

