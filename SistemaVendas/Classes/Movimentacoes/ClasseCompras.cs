using SistemaVendas.Classes.BancoDeDados;
using SistemaVendas.Classes.Cadastros;
using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace SistemaVendas.Classes.Movimentacoes
{
    public class ClasseCompras : BancoDados
    {        
        private ClasseProdutos classeProdutos;
        private ClasseFornecedores classeFornecedores;
                
        public ClasseCompras()
        {
            classeProdutos = new ClasseProdutos();
            classeFornecedores = new ClasseFornecedores();
        }

        #region Metodos Privados

        private string ValidarCamposCompra(string Produto, string Fornecedor, int Quantidade, double ValorTotal, string Data)

        {
            //Se não cair em menhum if, retorna ok
            string Retorno = "ok";
            if (Produto == "")
            {
                Retorno = "Selecione corretamente o Produto";
                return Retorno;
            }

            if (Fornecedor == "")
            {
                Retorno = "Selecione corretamente o Fornecedor";
                return Retorno;
            }

            if (Quantidade == 0)
            {
                Retorno = "Preencha corretamente a Quantidade";
                return Retorno;
            }

            if (ValorTotal == 0)
            {
                Retorno = "Preencha corretamente o Valor Total";
                return Retorno;
            }

            if (ValidarData(Data) == false)
            {
                Retorno = "Data Inválida";
                return Retorno;
            }

            return Retorno;
        }

        //Calcula a quantidade do produto que vai ser alterada na tabela produtos.
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
            NovaQuantidade = QuantidadeAtual + Quantidade;
            return NovaQuantidade;
        }

        //Valida se data está em formato válido e se está entre 1900 e 2060
        private bool ValidarData(string data)
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

        #endregion

        #region Metodos Publicos

        public string IncluirCompra(int CodigoProduto, string DescricaoProduto, string CNPJFornecedor, string RazaoSocial, string Quantidade, double ValorTotal, string DataCompra)
        {
            int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
            int IdFornecedor = classeFornecedores.RetornaIdFornecedor(CNPJFornecedor);
            var MsgRetorno = "Compra Concluida com Êxito";
            //Transforma quantidade em inteiro pra poder inserir no banco
            int quantidade = Convert.ToInt32(Quantidade);
            int QuantidadeAtual = CalcularNovaQuantidadeProduto(IdProduto, quantidade);
            //Se passar nas validações, insere no banco e retorna ok            
            string ResultadoValidacao = (ValidarCamposCompra(DescricaoProduto, RazaoSocial, quantidade, ValorTotal, DataCompra));
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
                DateTime Data = Convert.ToDateTime(DataCompra);
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"Insert into compras (data, produto_id, fornecedor_id, quantidade, valor_total) values (convert(datetime, '{Data}', 103),'{IdProduto}','{IdFornecedor}',{quantidade},{ValorTotal})");
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
        
        public string AlterarCompra(int ID, int CodigoProduto, string DescricaoProduto, string CNPJFornecedor, string RazaoSocial, int QuantidadeInicial, int QuantidadeFinal, double ValorTotal, string DataCompra)
        {
            int IdProduto = classeProdutos.RetornaIdProduto(CodigoProduto);
            int IdFornecedor = classeFornecedores.RetornaIdFornecedor(CNPJFornecedor);
            var MsgRetorno = "Atualização feita com Sucesso";            
            //Se passar nas validações, insere no banco e retorna ok            
            string ResultadoValidacao = (ValidarCamposCompra(DescricaoProduto, RazaoSocial, QuantidadeFinal, ValorTotal, DataCompra));
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
                DateTime Data = Convert.ToDateTime(DataCompra);
                int QuantidadeAlteracao = QuantidadeFinal - QuantidadeInicial;                
                QuantidadeAlteracao = (classeProdutos.RetornaQuantidadeProduto(IdProduto) + QuantidadeAlteracao);
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"update compras set data = convert(datetime, '{Data}', 103) , produto_id = '{IdProduto}' , fornecedor_id = '{IdFornecedor}', quantidade= '{QuantidadeFinal}', valor_total = '{ValorTotal}' where compras.id ={ID}");
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

        public string ExcluirCompra(int ID)
        {
            try
            {
                AbrirConexao();
                RodarScript(
                    $"delete from compras where id ={ID}");
                FecharConexao();
            }
            //Se gerar erro, a função retorna o erro gerado.
            catch (Exception MsgErro)
            {
                //Se cair aqui, retorna o erro e sai da função
                return MsgErro.ToString();
            }

            //Se chegar até aqui sem erro, retorna OK.
            var MsgRetorno = "Ok";
            return MsgRetorno;
        }

        //Retorna os dados de uma unica compra para um datatable a partir do seu id
        public DataTable RetornaDadosCompra(int id)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select compras.id, compras.data as DataCompra, produtos.codigo as CodigoProduto, produtos.descricao as DescricaoProduto, fornecedores.razaosocial, fornecedores.cnpj as CNPJ, compras.quantidade as Quantidade, cast((compras.valor_total) as decimal(16,2)) from produtos inner join compras on produtos.id = compras.produto_id inner join fornecedores on fornecedores.id = compras.fornecedor_id where compras.id = {id}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de uma unica compra para um datatable a partir do id do fornecedor
        public DataTable RetornaDadosCompraPorFornecedor(int idFornecedor)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select compras.id, compras.data as DataCompra, produtos.codigo as CodigoProduto, produtos.descricao as DescricaoProduto, fornecedores.razaosocial, fornecedores.cnpj as CNPJ, compras.quantidade as Quantidade, cast((compras.valor_total) as decimal(16,2)) from produtos inner join compras on produtos.id = compras.produto_id inner join fornecedores on fornecedores.id = compras.fornecedor_id where compras.fornecedor_id = {idFornecedor}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de uma unica compra para um datatable a partir do id do fornecedor
        public DataTable RetornaDadosCompraPorProduto(int idProduto)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select compras.id, compras.data as DataCompra, produtos.codigo as CodigoProduto, produtos.descricao as DescricaoProduto, fornecedores.razaosocial, fornecedores.cnpj as CNPJ, compras.quantidade as Quantidade, cast((compras.valor_total) as decimal(16,2)) from produtos inner join compras on produtos.id = compras.produto_id inner join fornecedores on fornecedores.id = compras.fornecedor_id where compras.produto_id = {idProduto}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de todas as compras para um datatable
        public DataTable RetonarDadosTodasCompras()
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select compras.id, compras.data, produtos.codigo, produtos.descricao, fornecedores.razaosocial, fornecedores.cnpj, compras.quantidade, cast((compras.valor_total) as decimal(16,2)) from compras inner join produtos on produtos.id = compras.produto_id inner join fornecedores on fornecedores.id = compras.fornecedor_id");
            FecharConexao();
            return lerdados;
        }
        
        //Retorna se já existe fornecedor cadastrado em alguma compra, impedindo que o mesmo seja excluido.
       public bool ExisteFornecedor(int FornecedorId)
        {
            bool existe;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select fornecedores.id from fornecedores inner join compras on fornecedores.id = compras.fornecedor_id where fornecedores.id = {FornecedorId}");
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

        //Retorna se já existe produto cadastrado em alguma compra, impedindo que o mesmo seja excluido.
        public bool ExisteProduto(int ProdutoId)
        {
            bool existe;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select produtos.id from produtos inner join compras on produtos.id = compras.produto_id where produtos.id = {ProdutoId}");
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

        #endregion
    }
}
