using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Listas;

namespace SistemaVendas.Telas.Cadastros
{
    public partial class frmFornecedores : Form
    {
        public ClasseFornecedores ClasseFornecedores;
        public frmListaFornecedores frmListaFornecedores;
        public readonly ClasseFornecedores classeFornecedores;
        public readonly frmListaFornecedores FrmListaFornecedores;
        public int id;
        public bool Inclusao;

        public frmFornecedores(bool EhInclusao, int fornecedor_id)
        {
            Inclusao = EhInclusao;
            id = fornecedor_id;
            InitializeComponent();
            //Inicializa instâncias das outras classes que serão usadas pelos métodos dessa classe
            ClasseFornecedores = new ClasseFornecedores();            
            frmListaFornecedores = new frmListaFornecedores();

        }

        #region Metodos Privados

        private void SalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (Inclusao)
            {
                string Retorno = (ClasseFornecedores.IncluirFornecedor(txtRazao.Text, mskCNPJ.Text, txtEnderecofor.Text, txtBairrofor.Text, txtCidadefor.Text, txtUffor.Text, mskCEPfor.Text, mskTelefoneFor.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Cadastro Concluido com Sucesso"))
                {
                    //Se for inclusão, deve limpar os campos após salvar.
                    frmListaFornecedores.RecarregarGridFornecedores();
                    txtBairrofor.Text = "";
                    txtCidadefor.Text = "";
                    txtEnderecofor.Text = "";
                    txtRazao.Text = "";
                    txtUffor.Text = "";
                    mskCEPfor.Text = "";
                    mskCNPJ.Text = "";
                    mskTelefoneFor.Text = "";
                }

            }
            else
            {
                //Aqui precisa passar o id da pessoa sendo alterada.
                string Retorno = (ClasseFornecedores.AlterarFornecedor(id, txtRazao.Text, mskCNPJ.Text, txtEnderecofor.Text, txtBairrofor.Text, txtCidadefor.Text, txtUffor.Text, mskCEPfor.Text, mskTelefoneFor.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Atualização feita com Sucesso"))
                {
                    frmListaFornecedores.RecarregarGridFornecedores();
                    this.Close();
                }
            }
        }

        private void CancelarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            //Como não é inclusão, é alteração. Quando carregar a tela de clientes em modo alteração, deve carregar os dados da pessoa.
            if (!Inclusao)
            {
                var dados = ClasseFornecedores.RetornaDadosFornecedor(id);
                txtRazao.Text = dados.Rows[0]["razaosocial"].ToString();
                mskCNPJ.Text = dados.Rows[0]["cnpj"].ToString();                
                mskCEPfor.Text = dados.Rows[0]["cep"].ToString();                
                mskTelefoneFor.Text = dados.Rows[0]["telefone"].ToString();                
                txtEnderecofor.Text = dados.Rows[0]["endereco"].ToString();
                txtBairrofor.Text = dados.Rows[0]["bairro"].ToString();
                txtCidadefor.Text = dados.Rows[0]["cidade"].ToString();
                txtUffor.Text = dados.Rows[0]["uf"].ToString();
            }
        }

        #endregion
    }
}
