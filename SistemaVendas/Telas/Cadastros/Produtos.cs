using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Listas;


namespace SistemaVendas.Telas.Cadastros
{
    public partial class frmProdutos : Form
    {        
        public frmListaProdutos FrmListaProdutos;        
        public readonly ClasseProdutos classeProdutos;
        public readonly ClasseTiposProdutos classeTiposProdutos;
        public int id;
        public bool Inclusao;


        public frmProdutos(bool EhInclusao, int produto_id)
        {
            Inclusao = EhInclusao;
            id = produto_id;
            InitializeComponent();
            //Inicializa instâncias das outras classes que serão usadas pelos métodos dessa classe
            classeProdutos = new ClasseProdutos();
            classeTiposProdutos = new ClasseTiposProdutos();
            FrmListaProdutos = new frmListaProdutos();
        }

        #region Metodos Privados
        private void SalvarProduto_Click(object sender, EventArgs e)
        {

            //Transforma os valores da tela em valores corretos para chamar o método
            int disponivel;
            if (chkDisponivel.Checked)
            {
                disponivel = 1;
            }
            else
            {
                disponivel = 0;
            }

            int codigo;
            try
            {
                codigo = Convert.ToInt32(txtCodigoProd.Text);
            }
            catch (Exception)
            {
                codigo = 0;
            }

            float valor;
            try
            {
                valor = float.Parse(txtValorProd.Text);
            }
            catch (Exception)
            {
                valor = 0;
            }

            //Inclusão e alteração tem regras diferentes.
            if (Inclusao)
            {
                string Retorno = (classeProdutos.IncluirProduto(codigo, txtProduto.Text, "0", classeTiposProdutos.RetornaIdTipoProduto(cbTipoProd.Text), cbGenero.Text, valor , disponivel));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Cadastro Concluido com Sucesso"))
                {
                    FrmListaProdutos.RecarregarGridProdutos();
                    txtProduto.Text = "";
                    txtCodigoProd.Text = "";
                    txtQtdProd.Text = "";
                    txtValorProd.Text = "";
                    chkDisponivel.Checked = false;
                    cbGenero.Text = "";
                    cbTipoProd.SelectedIndex = 0;
                }
            }
            else
            {
                //Aqui precisa passar o id da pessoa sendo alterada.
                string Retorno = (classeProdutos.AlterarProduto(id, codigo, txtProduto.Text, "0", classeTiposProdutos.RetornaIdTipoProduto(cbTipoProd.Text), cbGenero.Text, valor, disponivel));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Atualização feita com Sucesso"))
                {
                    FrmListaProdutos.RecarregarGridProdutos();
                    this.Close();
                }
            }
        }

        private void CancelarProduto_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            //Carrega os valores da combo tipo de produto
            BindingSourceTipoProdutos.DataSource = classeTiposProdutos.RetonarDadosTodosTiposProdutos();
            cbTipoProd.DataSource = BindingSourceTipoProdutos;
            cbTipoProd.DisplayMember = "descricao";
            cbTipoProd.ValueMember = "descricao";
            cbTipoProd.DropDownStyle = ComboBoxStyle.DropDownList;
            txtQtdProd.Enabled = false;

            if (!Inclusao)
            {
                //Se for alteração, deve carregar os dados do produto
                var dados = classeProdutos.RetornaDadosProduto(id);
                txtCodigoProd.Text = dados.Rows[0]["codigo"].ToString();
                txtProduto.Text = dados.Rows[0]["descricao"].ToString();
                cbTipoProd.Text = dados.Rows[0]["tipo"].ToString();
                cbGenero.SelectedText = dados.Rows[0]["subgenero"].ToString();
                txtQtdProd.Text = dados.Rows[0]["quantidade"].ToString();
                txtValorProd.Text = dados.Rows[0]["valor_unitario"].ToString();
                if (dados.Rows[0]["disponivel_venda"].ToString().Equals("0"))
                {
                    chkDisponivel.Checked = false;
                }
                if (dados.Rows[0]["disponivel_venda"].ToString().Equals("1"))
                {
                    chkDisponivel.Checked = true;
                }
            }
        }
        #endregion
    }
}
