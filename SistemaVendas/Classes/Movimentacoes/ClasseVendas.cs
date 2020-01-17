using SistemaVendas.Classes.BancoDeDados;
using SistemaVendas.Classes.Cadastros;
using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace SistemaVendas.Classes.Movimentacoes
{
    public class ClasseVendas : BancoDados
    {
        private ClasseClientes classeClientes;
        private ClasseProdutos classeProdutos;

        public ClasseVendas()
        {
            classeProdutos = new ClasseProdutos();
            classeClientes = new ClasseClientes();
        }

        #region Metodos Privados
        //Calcula a quantidade de produto que vai ser alterada na tabela de produtos.
        private int CalcularNovaQuantidadeProduto(int IdProduto, int Quantidade)
        {
            int NovaQuantidade = 0;
            int QuantidadeAtual = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select quantidade from produtos where id = '{IdProduto}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string QuantidadeValor = dados.Rows[0]["Quantidade"].ToString();
                QuantidadeAtual = Int32.Parse(QuantidadeValor);
            }
            FecharConexao();
            //Na venda, a quantidade é subtraida
            NovaQuantidade = QuantidadeAtual - Quantidade;
            return NovaQuantidade;
        }

        private string ValidarCamposVenda(string Produto, string Cliente, int Quantidade, string Data, double ValorTotal)

        {
            //Se não cair em menhum if, retorna ok
            string Retorno = "ok";
            if (Produto == "")
            {
                Retorno = "Selecione corretamente o Produto";
                return Retorno;
            }

            if (Cliente == "")
            {
                Retorno = "Selecione corretamente o Cliente";
                return Retorno;
            }

            if (Quantidade == 0)
            {
                Retorno = "Preencha corretamente a Quantidade";
                return Retorno;
            }

            if (ValorTotal == 0)
            {
                Retorno = "Preencha corretamente a Quantidade";
                return Retorno;
            }

            if (ValidarData(Data) == false)
            {
                Retorno = "Data Inválida";
                return Retorno;
            }
            return Retorno;
        }

        #endregion

        #region Metodos Publicos

        //Valida se data está em formato válido e se está entre 1900 e 2060
        public bool ValidarData(string data)
        {
            DateTime Minimo = Convert.ToDateTime("01/01/1900");
            DateTime Maximo = Convert.ToDateTime("01/01/2060");
            try
            {
                DateTime DataNascimento = Convert.ToDateTime(data);
                if (DataNascimento < Minimo)
                {
                    return false;
                }
                if (DataNascimento > Maximo)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                //Se cair aqui, retorna o erro e sai da função
                return false;
            }
            data = data + " 00:00";
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4} \d{2}:\d{2})");
            return r.Match(data).Success;
        }

        public string IncluirVenda(int CodigoProduto, string DescricaoProduto, string CPF, string RazaoSocial, string Quantidade, double ValorTotal, string DataVenda)
        {
            int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
            int IdCliente = classeClientes.RetornaIdCliente(CPF);
            var MsgRetorno = "Venda Concluida com Êxito";
            //Transforma quantidade em inteiro pra poder inserir no banco
            int quantidade = Convert.ToInt32(Quantidade);
            int QuantidadeAtual = CalcularNovaQuantidadeProduto(IdProduto, quantidade);
            //Se passar nas validações, insere no banco e retorna ok            
            string ResultadoValidacao = (ValidarCamposVenda(DescricaoProduto, CPF, quantidade, DataVenda, ValorTotal));
            if (QuantidadeAtual < 0)
            {
                ResultadoValidacao = "Não é possível efetuar essa venda, pois não há produto em quantidade suficiente no estoque";
            }

            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Força o separador do float como . para não dar erro na hora de inserir no banco
                string CultureName = Thread.CurrentThread.CurrentCulture.Name;
                CultureInfo ci = new CultureInfo(CultureName);
                if (ci.NumberFormat.NumberDecimalSeparator != ".")
                {
                    ci.NumberFormat.NumberDecimalSeparator = ".";
                    Thread.CurrentThread.CurrentCulture = ci;
                }
                DateTime Data = Convert.ToDateTime(DataVenda);
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"Insert into vendas (data, produto_id, cliente_id, quantidade, valor_total) values (convert(datetime, '{Data}', 103),'{IdProduto}','{IdCliente}',{quantidade},{ValorTotal})");
                    FecharConexao();
                    AbrirConexao();
                    RodarScript(
                        $"update produtos set quantidade = '{QuantidadeAtual}' where produtos.id ={IdProduto}");
                    FecharConexao();

                }
                //Se gerar erro, a função retorna o erro gerado.
                catch (Exception MsgErro)
                {
                    //Se cair aqui, retorna o erro e sai da função
                    return MsgErro.ToString();
                }

                //Se chegar até aqui, retorna OK.
                return MsgRetorno;
            }
            //Não passou na validacao, retorna a mensagem
            return ResultadoValidacao;
        }

        public string AlterarVenda(int ID, int CodigoProduto, string DescricaoProduto, string CPF, string RazaoSocial, int QuantidadeInicial, int QuantidadeFinal, double ValorTotal, string DataVenda)
        {
            int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
            int IdCliente = classeClientes.RetornaIdCliente(CPF);
            var MsgRetorno = "Cadastro Concluido com Êxito";
            //Se passar nas validações, insere no banco e retorna ok            
            string ResultadoValidacao = (ValidarCamposVenda(DescricaoProduto, CPF, QuantidadeFinal, DataVenda, ValorTotal));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Força o separador do float como . para não dar erro na hora de inserir no banco
                string CultureName = Thread.CurrentThread.CurrentCulture.Name;
                CultureInfo ci = new CultureInfo(CultureName);
                if (ci.NumberFormat.NumberDecimalSeparator != ".")
                {
                    ci.NumberFormat.NumberDecimalSeparator = ".";
                    Thread.CurrentThread.CurrentCulture = ci;
                }
                //Transforma quantidade em inteiro pra poder inserir no banco
                DateTime Data = Convert.ToDateTime(DataVenda);
                int QuantidadeAlteracao = QuantidadeFinal - QuantidadeInicial;
                QuantidadeAlteracao = (classeProdutos.RetornaQuantidadeProduto(IdProduto) + QuantidadeAlteracao);
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"update vendas set data = convert(datetime, '{Data}', 103) , produto_id = '{IdProduto}' , cliente_id = '{IdCliente}', quantidade= '{QuantidadeFinal}', valor_total = '{ValorTotal}' where vendas.id ={ID}");
                    FecharConexao();
                    AbrirConexao();
                    RodarScript(
                      $"update produtos set quantidade = '{QuantidadeAlteracao}' where produtos.id ={IdProduto}");
                    FecharConexao();

                }
                //Se gerar erro, a função retorna o erro gerado.
                catch (Exception MsgErro)
                {
                    //Se cair aqui, retorna o erro e sai da função
                    return MsgErro.ToString();
                }

                //Se chegar até aqui, retorna OK.
                return MsgRetorno;
            }

            //Não passou na validacao, retorna a mensagem
            return ResultadoValidacao;
        }

        //Retorna os dados de uma unica venda para um datatable a partir do seu id
        public DataTable RetornaDadosVenda(int id)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select vendas.id, vendas.data, produtos.codigo, produtos.descricao, clientes.nome, vendas.quantidade, cast((vendas.valor_total) as decimal(16,2)) from vendas inner join produtos on produtos.id = vendas.produto_id inner join clientes on clientes.id = vendas.cliente_id where vendas.id = {id}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de uma unica venda para um datatable a partir do seu id
        public DataTable RetornaDadosVenda(DateTime data)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select vendas.id, vendas.data, produtos.codigo, produtos.descricao, clientes.nome, vendas.quantidade, cast((vendas.valor_total) as decimal(16,2)) from vendas inner join produtos on produtos.id = vendas.produto_id inner join clientes on clientes.id = vendas.cliente_id where vendas.data = '{data}'");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de uma unica venda para um datatable a partir do seu id
        public DataTable RetornaDadosVendaCliente(int IdCliente)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select vendas.id, vendas.data, produtos.codigo, produtos.descricao, clientes.nome, vendas.quantidade, cast((vendas.valor_total) as decimal(16,2)) from vendas inner join produtos on produtos.id = vendas.produto_id inner join clientes on clientes.id = vendas.cliente_id where clientes.id = '{IdCliente}'");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de todas as vendas para um datatable
        public DataTable RetonarDadosTodasVendas()
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select vendas.id, vendas.data, produtos.codigo, produtos.descricao, clientes.nome, vendas.quantidade, cast((vendas.valor_total) as decimal(16,2)) from vendas inner join produtos on produtos.id = vendas.produto_id inner join clientes on clientes.id = vendas.cliente_id");
            FecharConexao();
            return lerdados;
        }

        //Retorna se já existe cliente cadastrado em alguma venda, impedindo que o mesmo seja excluido.
        public bool ExisteCliente(int ClienteId)
        {
            bool existe;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select clientes.id from clientes inner join vendas on clientes.id = vendas.cliente_id where clientes.id = {ClienteId}");
            FecharConexao();
            if (dados.Rows.Count > 0)
            {
                existe = true;
                return existe;
            }
            else
            {
                existe = false;
                return existe;
            }
        }

        //Retorna se já existe produto cadastrado em alguma venda, impedindo que o mesmo seja excluido.
        public bool ExisteProduto(int ProdutoId)
        {
            bool existe;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select produtos.id from produtos inner join vendas on produtos.id = vendas.produto_id where produtos.id = {ProdutoId}");
            FecharConexao();
            if (dados.Rows.Count > 0)
            {
                existe = true;
                return existe;
            }
            else
            {
                existe = false;
                return existe;
            }
        }

        //Calcula o valor total da venda, a partir do valor do produto (da tabela produtos) e da quantidade informada na tela de vendas.
        public double CalcularValorVenda(int quantidade, int idProduto)
        {
            double ValorVenda;
            ValorVenda = classeProdutos.RetornaValorProduto(idProduto);
            ValorVenda = ValorVenda * quantidade;
            return ValorVenda;
        }

        #endregion
    }
}
