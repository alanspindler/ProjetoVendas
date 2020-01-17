using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Classes.Movimentacoes;
using SistemaVendas.Telas.Listas;

namespace SistemaVendas.Telas.Cadastros
{
    public partial class FrmCompras : Form
    {
        public ClasseProdutos classeProdutos;
        public ClasseFornecedores classeFornecedores;
        public ClasseCompras classeCompras;
        public FrmListaCompras frmListaCompras;
        public int id;
        public bool Inclusao;
        public int QuantidadeInicial;
        public int QuantidadeFinal;

        public FrmCompras(bool EhInclusao, int CompraId)
        {
            Inclusao = EhInclusao;
            id = CompraId;
            classeProdutos = new ClasseProdutos();
            classeFornecedores = new ClasseFornecedores();
            classeCompras = new ClasseCompras();
            frmListaCompras = new FrmListaCompras();
            InitializeComponent();
        }

        //Carrega a tela de compras.
        private void Compras_Load(object sender, EventArgs e)
        {

            //Se não for inclusão, é alteração.
            //Se for alteração, deve carregar os dados do item atual.
            if (!Inclusao)
            {                
                var dados = classeCompras.RetornaDadosCompra(id);
                txtCodigoCompras.Text = dados.Rows[0]["CodigoProduto"].ToString();
                txtDescProduto.Text = dados.Rows[0]["DescricaoProduto"].ToString();
                mskCNPJ.Text = dados.Rows[0]["CNPJ"].ToString();
                txtFornCompras.Text = dados.Rows[0]["RazaoSocial"].ToString();
                txtQtdCompras.Text = dados.Rows[0]["Quantidade"].ToString();
                txtValorCompras.Text = dados.Rows[0]["Column1"].ToString();
                mskDataCompra.Text = dados.Rows[0]["DataCompra"].ToString();    
                QuantidadeInicial = Convert.ToInt32(txtQtdCompras.Text);
            }
        }

        //Salva a compra.
        private void SalvarCompras_Click(object sender, EventArgs e)
        {
            //Localiza o produto antes de salvar.
            //Caso o usuário tenha alterado o código depois de localizar.
            string RetornoFuncao;
            RetornoFuncao = LocalizarProduto();
            //Se não retornar nenhum dos erros, prossegue.
            if ((RetornoFuncao != "O Código Deve Possuir Apenas Números") && (RetornoFuncao != "Preencha o Código do Produto") && (RetornoFuncao != "Produto não Encontrado"))
            {

            }
            else
            {
                //Se cair em algum dos erros, sai da função.
                return;
            }
            //Localiza o fornecedor antes de salvar.
            //Caso o usuário tenha alterado o cnpj depois de localizar.
            RetornoFuncao = LocalizarFornecedor();
            //Se não retornar nenhum dos erros, prossegue.
            if ((RetornoFuncao != "Preencha o CNPJ do Fornecedor") && (RetornoFuncao != "Fornecedor não Encontrado"))
            {

            }
            else
            {
                //Se cair em algum dos erros, sai da função.
                return;
            }
            //Testa se o código é numérico.
            if (!int.TryParse(txtCodigoCompras.Text, out int Incorreto) || (txtCodigoCompras.Text == ""))
            {
                String Retorno = "Preencha Corretamente o Codigo do Produto";
                MessageBox.Show(Retorno);
                //Se não for numérico, sai da função.
                return;
            }
            //Converte o código de texto pra numero;
            int CodigoProduto = Convert.ToInt32(txtCodigoCompras.Text);

            //Verifica se a quantidade é numérica
            if (!int.TryParse(txtQtdCompras.Text, out int QtdIncorreto) || (txtQtdCompras.Text == ""))
            {
                String Retorno = "Preencha Corretamente a Quantidade";
                MessageBox.Show(Retorno);
                return;
            }
            string valorcampo;
            double valor;
            try
            {
                //Pega o valor do campo e transforma em double (exemplo 12.23)
                valorcampo = txtValorCompras.Text.Replace(",", ".");
                //Esse System.Globalization.CultureInfo.InvariantCulture foi como eu resolvi a conversão de , para .
                valor = double.Parse(valorcampo, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                valor = 0;
            }

            if (Inclusao)
            {
                string Retorno = (classeCompras.IncluirCompra(CodigoProduto, txtDescProduto.Text, mskCNPJ.Text, txtFornCompras.Text, txtQtdCompras.Text, valor, mskDataCompra.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Compra Concluida com Êxito"))
                {
                    //Se for inclusão e a compra foi concluída, deve limpar os campos para a próxima compra.
                    frmListaCompras.RecarregarGridCompras();
                    txtCodigoCompras.Text = "";
                    txtDescProduto.Text = "";
                    txtFornCompras.Text = "";
                    txtQtdCompras.Text = "";
                    txtValorCompras.Text = "";
                    mskCNPJ.Text = "";
                    mskDataCompra.Text = "";                 
                }
            }
            else
            {
                //Aqui precisa passar o id da compra sendo alterada.
                QuantidadeFinal = Convert.ToInt32(txtQtdCompras.Text);                
                string Retorno = (classeCompras.AlterarCompra(id, CodigoProduto, txtDescProduto.Text, mskCNPJ.Text, txtFornCompras.Text, QuantidadeInicial, QuantidadeFinal, valor, mskDataCompra.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Atualização feita com Sucesso"))
                {
                    frmListaCompras.RecarregarGridCompras();
                    this.Close();
                }
            }
        }

        //Localiza o produto.
        public string LocalizarProduto()
        {
            int CodigoProduto;
            string Retorno = "";
            //Se o código estiver em branco, avisa e não faz nada.
            if (txtCodigoCompras.Text == "")
            {
                Retorno = "Preencha o Código do Produto";
                MessageBox.Show(Retorno);
                return Retorno;
            }
            else
            {
                //Valida se o código é numérico.
                if (!int.TryParse(txtCodigoCompras.Text, out CodigoProduto))
                {
                    Retorno = "O Código Deve Possuir Apenas Números";
                    MessageBox.Show(Retorno);
                    //Sai da função se não for e retorna a mensagem de erro.
                    return Retorno;
                }
                else
                {
                    //Se chegou aqui, o código é um numero válido. Então converte pra inteiro.
                    CodigoProduto = Convert.ToInt32(txtCodigoCompras.Text);
                    int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
                    string DescricaoProduto = classeProdutos.RetornaDescricaoProduto(IdProduto);
                    //Se retornou erro, é pq o select não encontrou nenhum item.
                    if (DescricaoProduto == "Erro")
                    {
                        Retorno = "Produto não Encontrado";
                        MessageBox.Show(Retorno);
                        return Retorno;
                    }
                    else
                    {
                        Retorno = DescricaoProduto;
                        txtDescProduto.Text = Retorno;
                        return Retorno;
                    }
                }
            }
        }

        //Localiza o fornecedor.
        public string LocalizarFornecedor()
        {
            string Retorno = "";
            if (mskCNPJ.Text == "")
            {
                Retorno = "Preencha o CNPJ do Fornecedor";
                MessageBox.Show(Retorno);
                return Retorno;
            }
            else
            {
                //Se não for vazio, localiza o fornecedor.
                int IdFornecedor = classeFornecedores.RetornaIdFornecedor(mskCNPJ.Text);
                string RazaoSocial = classeFornecedores.RetornaRazaoSocialFornecedor(IdFornecedor);
                if (RazaoSocial == "Erro")
                {
                    //Se o retorno for Erro, é pq o Select não achou nenhum fornecedor com o CNPJ.
                    Retorno = "Fornecedor não Encontrado";
                    MessageBox.Show(Retorno);
                    return Retorno;
                }
                else
                {
                    Retorno = RazaoSocial;
                    txtFornCompras.Text = Retorno;
                    return Retorno;
                }
            }
        }

        //Fecha a tela.
        private void CancelarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)

        {
            LocalizarProduto();
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            LocalizarFornecedor();
        }
    }
}

