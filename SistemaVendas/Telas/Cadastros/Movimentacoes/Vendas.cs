using System;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Classes.Movimentacoes;
using SistemaVendas.Telas.Listas;

namespace SistemaVendas.Telas.Cadastros
{
    public partial class FrmVendas : Form
    {
        public ClasseProdutos classeProdutos;
        public ClasseClientes classeClientes;
        public ClasseVendas classeVendas;
        public int id;
        public bool Inclusao;
        public int QuantidadeInicial;
        public int QuantidadeFinal;

        public FrmVendas(bool EhInclusao, int VendaId)

        {
            Inclusao = EhInclusao;
            id = VendaId;
            classeProdutos = new ClasseProdutos();
            classeVendas = new ClasseVendas();
            classeClientes = new ClasseClientes();
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            //Linha abaixo carrega a data atual do Sistema:
            DataAtual.Text = DateTime.Now.ToShortDateString();

            if (!Inclusao)
            {
                //Se não for inclusão é alteração.
                //Se for alteração, deve carregar os dados da venda na tela.
                var dados = classeVendas.RetornaDadosVenda(id);
                txtCodigoVendas.Text = dados.Rows[0]["CodigoProduto"].ToString();
                txtNomeProd.Text = dados.Rows[0]["DescricaoProduto"].ToString();
                mskCPF.Text = dados.Rows[0]["CPF"].ToString();
                //txtValorUnidd.Text = dados.Rows[0]["Valor_Unitario"].ToString();
                txtNomeCliente.Text = dados.Rows[0]["NomeCliente"].ToString();
                txtQtdVendas.Text = dados.Rows[0]["Quantidade"].ToString();
                DataAtual.Text = dados.Rows[0]["DataVenda"].ToString();
                txtValorVenda.Text = dados.Rows[0]["Column1"].ToString();
            }
        }

        private void EfetuarVenda_Click(object sender, EventArgs e)
        {
            string RetornoFuncao;
            RetornoFuncao = LocalizarNomeProduto();
            LocalizarValorUnitarioProduto();
            if ((RetornoFuncao != "O Código Deve Possuir Apenas Números") && (RetornoFuncao != "Preencha o Código do Produto") && (RetornoFuncao != "Produto não Encontrado"))
            {

            }
            else
            {
                //Se caiu aqui, é pq a função retornou um dos erros. Sai da função.
                return;
            }
            RetornoFuncao = LocalizarCliente();
            if ((RetornoFuncao == "Preencha o CPF do Cliente") && (RetornoFuncao == "Cliente não Encontrado"))
            {
                //Se caiu aqui, é pq a função retornou um dos erros. Sai da função.
                return;
            }            
            //Valida se o código é numérico. Se não for, avisa e sai da função.
            if (!int.TryParse(txtCodigoVendas.Text, out int Incorreto) || (txtCodigoVendas.Text == ""))
            {
                String Retorno = "Preencha Corretamente o Codigo do Produto";
                MessageBox.Show(Retorno);
                return;
            }
            //Como o código é numérico, converte para inteiro.
            int CodigoProduto = Convert.ToInt32(txtCodigoVendas.Text);

            //Valida se a quantidade é numérica.  Se não for, sai da função.
            if (!int.TryParse(txtQtdVendas.Text, out int QtdIncorreto) || (txtQtdVendas.Text == ""))
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
                //Esse System.Globalization.CultureInfo.InvariantCulture foi como eu resolvi a conversão de , para .
                valorcampo = txtValorVenda.Text.Replace(",", ".");
                valor = double.Parse(valorcampo, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                valor = 0;
            }

            //Indica que é inclusão e não alteração
            if (Inclusao)
            {
                string Retorno = (classeVendas.IncluirVenda(CodigoProduto, txtNomeProd.Text, mskCPF.Text, txtNomeCliente.Text, txtQtdVendas.Text, valor, DataAtual.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Venda Concluida com Êxito"))
                {
                    //Se for inclusão, após finalizar o cadastro limpa os campos.
                    txtCodigoVendas.Text = "";
                    txtNomeCliente.Text = "";
                    txtNomeProd.Text = "";
                    txtQtdVendas.Text = "";
                    txtValorVenda.Text = "";
                    txtValorUnidd.Text = "";
                    mskCPF.Text = "";                    
                }
            }
            else
            {   
                //Se for alteração
                QuantidadeFinal = Convert.ToInt32(txtQtdVendas.Text);
                string Retorno = (classeVendas.AlterarVenda(id, CodigoProduto, txtNomeProd.Text, mskCPF.Text, txtNomeCliente.Text, QuantidadeInicial, QuantidadeFinal, valor, DataAtual.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Venda Concluida com Êxito"))
                {             
                    //Se for alteração, fecha a tela após salvar.
                    this.Close();
                }
            }           
        }

        //Localiza o nome do produto pelo código
        public string LocalizarNomeProduto()
        {
            int CodigoProduto;
            string Retorno = "";
            //Testa campo em branco
            if (txtCodigoVendas.Text == "")
            {
                Retorno = "Preencha o Código do Produto";
                MessageBox.Show(Retorno);
                return Retorno;
            }
            else
            {
                //Valida se o código possui apenas numeros
                if (!int.TryParse(txtCodigoVendas.Text, out CodigoProduto))
                {
                    Retorno = "O Código Deve Possuir Apenas Números";
                    MessageBox.Show(Retorno);
                    return Retorno;
                }
                else
                {
                    //Se apenas possui números, converte pra int
                    CodigoProduto = Convert.ToInt32(txtCodigoVendas.Text);
                    int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
                    string DescricaoProduto = classeProdutos.RetornaDescricaoProduto(IdProduto);
                    //Se retornou Erro é pq não existe na tabela.
                    if (DescricaoProduto == "Erro")
                    {
                        Retorno = "Produto não Encontrado";
                        MessageBox.Show(Retorno);
                        return Retorno;
                    }
                    else
                    {
                        //Se achou, verifica se o produto está com a opção disponível para venda (da tela de produtos) marcada.
                        bool produto_disponivel = classeProdutos.ProdutoDisponivel(IdProduto);
                        if (produto_disponivel)
                        {
                            Retorno = DescricaoProduto;
                            txtNomeProd.Text = Retorno;
                            return Retorno;
                        }
                        else
                        {
                            Retorno = "Produto não Disponivel para Vendas";
                            MessageBox.Show(Retorno);
                            return Retorno;
                        }
                    }
                }
            }
        }

        //Localiza o valor unitário do produto.
        public string LocalizarValorUnitarioProduto()
        {
            int CodigoProduto;
            string Retorno = "";
            CodigoProduto = Convert.ToInt32(txtCodigoVendas.Text);
            int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
            string ValorProduto = classeProdutos.RetornaValorProduto(IdProduto).ToString();
            Retorno = ValorProduto;
            txtValorUnidd.Text = Retorno;
            return Retorno;
        }

        //Localiza o nome do cliente pelo CPF
        public string LocalizarCliente()
        {
            string Retorno = "";
            if (mskCPF.Text == "")
            {
                Retorno = "Preencha o CPF do Cliente";
                MessageBox.Show(Retorno);
                return Retorno;
            }
            else
            {
                int IdCliente = classeClientes.RetornaIdCliente(mskCPF.Text);
                string NomeCliente = classeClientes.RetornaNomeCliente(IdCliente);
                if (NomeCliente == "Erro")
                {
                    Retorno = "Cliente não Encontrado";
                    MessageBox.Show(Retorno);
                    return Retorno;
                }
                else
                {
                    Retorno = NomeCliente;
                    txtNomeCliente.Text = Retorno;
                    return Retorno;
                }
            }
        }


        
        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            string RetornoFuncao = LocalizarNomeProduto();
            if ((RetornoFuncao != "O Código Deve Possuir Apenas Números") && (RetornoFuncao != "Preencha o Código do Produto") && (RetornoFuncao != "Produto não Encontrado") && RetornoFuncao != "Produto não Disponivel para Vendas")
            {
                LocalizarValorUnitarioProduto();
            }

        }

        private void btnLocalizarCliente_Click(object sender, EventArgs e)
        {
            LocalizarCliente();
        }

        //Calcula a o valor da venda quando altera o valor do campo quantidade
        private void txtQtdVendas_LostFocus(object sender, EventArgs e)
        {
            string RetornoFuncao;
            if (txtQtdVendas.Text != "")
            {
                //Precisa localizar novamente produto para garantir que o código é correto.
                RetornoFuncao = LocalizarNomeProduto();
                if ((RetornoFuncao != "O Código Deve Possuir Apenas Números") && (RetornoFuncao != "Preencha o Código do Produto") && (RetornoFuncao != "Produto não Encontrado"))
                {
                    {
                        //Pega o id do produto.
                        int codigoProduto = Convert.ToInt32(txtCodigoVendas.Text);
                        int idProduto = classeProdutos.RetornaIdProduto(codigoProduto);
                        if (txtQtdVendas.Text != "")
                        {
                            //Chama a função da classe de vendas para calcular o valor da venda
                            int quantidadeProduto = Convert.ToInt32(txtQtdVendas.Text);
                            double ValorVenda = classeVendas.CalcularValorVenda(quantidadeProduto, idProduto);
                            txtValorVenda.Text = ValorVenda.ToString();
                            LocalizarValorUnitarioProduto();
                        }
                    }
                }

                else
                {
                    //Se caiu aqui é pq gerou algum dos no retorno da função e sai da função.
                    return;
                }
            }
        }

        private void txtCodigoVendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventArgs enter = new KeyPressEventArgs((char)Keys.Enter);
            if ((Keys)e.KeyChar == Keys.Enter){
                btnLocalizarProduto_Click(this, enter);
                         
                mskCPF.Focus();
            }
        }

        private void mskCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventArgs enter = new KeyPressEventArgs((char)Keys.Enter);
            if ((Keys)e.KeyChar == Keys.Enter) {
                btnLocalizarCliente_Click(this,enter);
                txtQtdVendas.Focus();                
            }


        }
        

        private void CancelarVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
