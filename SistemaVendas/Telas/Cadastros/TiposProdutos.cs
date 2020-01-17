using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Listas;

namespace SistemaVendas.Telas.Cadastros
{
    public partial class frmTiposProdutos : Form
    {   
        public readonly ClasseTiposProdutos classeTiposProdutos;        
        public readonly frmListaTiposProdutos FrmListaTiposProdutos;
        public int id;
        public bool Inclusao;


        public frmTiposProdutos(bool EhInclusao, int produto_id)
        {
            Inclusao = EhInclusao;
            id = produto_id;
            InitializeComponent();
            //Inicializa instâncias das outras classes que serão usadas pelos métodos dessa classe
            classeTiposProdutos = new ClasseTiposProdutos();
            FrmListaTiposProdutos = new frmListaTiposProdutos();
        }

        #region Metodos Privados
        private void btnSalvarTipoProduto_Click(object sender, EventArgs e)
        {
            //Inclusão e alteração tem regras diferentes.
            if (Inclusao)
            {
                string Retorno = (classeTiposProdutos.IncluirTipoProduto(txtTipoProduto.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Cadastro Concluido com Sucesso"))
                {
                    FrmListaTiposProdutos.RecarregarGridTiposProdutos();
                    //Limpa a tela após salvar com êxito
                    txtTipoProduto.Text = "";
                }

            }
            else
            {
                //Aqui precisa passar o id da pessoa sendo alterada.
                string Retorno = (classeTiposProdutos.AlterarTipoProduto(id, txtTipoProduto.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Atualização feita com Sucesso"))
                {
                    FrmListaTiposProdutos.RecarregarGridTiposProdutos();
                    this.Close();
                }
            }
        }        

        private void frmTiposProdutos_Load(object sender, EventArgs e)
        {
            if (!Inclusao)
            {
                //Se for alteração, carrega os dados do tipo de produto
                var dados = classeTiposProdutos.RetornaDadosTipoProduto(id);
                txtTipoProduto.Text = dados.Rows[0]["descricao"].ToString();

            }
        }
        //Fecha a tela.
        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
