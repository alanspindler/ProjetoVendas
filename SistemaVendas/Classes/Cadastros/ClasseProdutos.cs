using System;
using System.Data;
using SistemaVendas.Classes.BancoDeDados;
using System.Globalization;
using System.Threading;

namespace SistemaVendas.Classes.Cadastros
{
    public class ClasseProdutos : BancoDados
    {

        #region Metodos Privados

        private string ValidarCamposProduto(int Codigo, string Descricao, int tipo_produto_id, string subgenero, float valor_unitario, int idProduto)

        {
            //Se não cair em menhum if, retorna ok
            string Retorno = "ok";
            if (Codigo == 0)
            {
                Retorno = "Prencha corretamente o Código";
                return Retorno;
            }

            if (Descricao == "")
            {
                Retorno = "Prencha corretamente a Descrição";
                return Retorno;
            }

            if (tipo_produto_id == 0)
            {
                Retorno = "Selecione o Tipo de Produto";
                return Retorno;
            }

            if (subgenero == "")
            {
                Retorno = "Prencha corretamente a subgenero";
                return Retorno;
            }

            if (valor_unitario <= 0)
            {
                Retorno = "Prencha corretamente o Valor Unitário";
                return Retorno;
            }

            if (ValidarCodigoJaCadastrado(idProduto, Codigo))
            {
                Retorno = "Esse Código já está cadastrado para outro Produto";
                return Retorno;
            }

            if (ValidarDescricaoJaCadastrado(idProduto, Descricao))
            {
                Retorno = "Essa Descrição já está cadastrada para outro Produto";
                return Retorno;
            }

            return Retorno;
        }

        private bool ValidarCodigoJaCadastrado(int IdAtual, int Codigo)
        {
            var classeProdutos = new ClasseProdutos();
            int IdProduto = classeProdutos.RetornaIdProduto(Codigo);
            //Quando a função RetornaIDProduto não encontra o código, retorna 0.
            if (IdProduto == 0)
            {
                return false;
            }
            //Se retornou o id atual do produto, é alteração da própria pessoa e não é duplicado.
            if (IdProduto == IdAtual)
            {
                return false;
            }
            //Se retornou qualquer outro id, já existe cadastrado.
            return true;
        }

        private bool ValidarDescricaoJaCadastrado(int IdAtual, string Descricao)
        {
            var classeProdutos = new ClasseProdutos();
            int IdProduto = classeProdutos.RetornaIdProduto(Descricao);
            //Quando a função RetornaIDProduto não encontra o código, retorna 0.
            if (IdProduto == 0)
            {
                return false;
            }
            //Se retornou o id atual do produto, é alteração da própria pessoa e não é duplicado.
            if (IdProduto == IdAtual)
            {
                return false;
            }
            //Se retornou qualquer outro id, já existe cadastrado.
            return true;
        }

        #endregion

        #region Metodos Publicos

        //Retorna se já existe produto cadastrado em alguma venda, impedindo que o mesmo seja excluido.
        public bool ProdutoDisponivel(int ProdutoId)
        {
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select disponivel_venda from produtos where id = {ProdutoId}");
            FecharConexao();
            string campo = dados.Rows[0]["disponivel_venda"].ToString();
            if (campo == "1")
            {
                return true;
            }
            else
                return false;
        }

        public string IncluirProduto(int Codigo, string Descricao, string Quantidade, int TipoProdutoId, string SubGenero, float ValorUnitario, int DisponivelVenda)
        {
            var MsgRetorno = "Cadastro Concluido com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            //Passamos -1 como id para informar que é novo produto.
            string ResultadoValidacao = (ValidarCamposProduto(Codigo, Descricao, TipoProdutoId, SubGenero, ValorUnitario, -1));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Transforma quantidade em inteiro pra poder inserir no banco
                int quantidade = Convert.ToInt32(Quantidade);
                //Força o separador do float como . para não dar erro na hora de inserir no banco
                string CultureName = Thread.CurrentThread.CurrentCulture.Name;
                CultureInfo ci = new CultureInfo(CultureName);
                if (ci.NumberFormat.NumberDecimalSeparator != ".")
                {
                    ci.NumberFormat.NumberDecimalSeparator = ".";
                    Thread.CurrentThread.CurrentCulture = ci;
                }

                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"Insert into produtos (codigo, descricao, quantidade, tipo_produto_id, subgenero, valor_unitario, disponivel_venda) values ('{Codigo}','{Descricao}','{quantidade}','{TipoProdutoId}','{SubGenero}','{ValorUnitario}','{DisponivelVenda}')");
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

        public string AlterarProduto(int ID, int Codigo, string Descricao, string Quantidade, int TipoProdutoId, string SubGenero, float ValorUnitario, int DisponivelVenda)
        {
            var MsgRetorno = "Atualização feita com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            string ResultadoValidacao = (ValidarCamposProduto(Codigo, Descricao, TipoProdutoId, SubGenero, ValorUnitario, ID));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Transforma quantidade em inteiro pra poder inserir no banco
                int quantidade = Convert.ToInt32(Quantidade);
                //Força o separador do float como . para não dar erro na hora de inserir no banco
                string CultureName = Thread.CurrentThread.CurrentCulture.Name;
                CultureInfo ci = new CultureInfo(CultureName);
                if (ci.NumberFormat.NumberDecimalSeparator != ".")
                {
                    ci.NumberFormat.NumberDecimalSeparator = ".";
                    Thread.CurrentThread.CurrentCulture = ci;
                }
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"update produtos set codigo = '{Codigo}' , descricao = '{Descricao}' , tipo_produto_id = '{TipoProdutoId}', subgenero = '{SubGenero}', valor_unitario = '{ValorUnitario}', disponivel_venda = '{DisponivelVenda}' where produtos.id ={ID}");
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

        public string ExcluirProduto(int ID)
        {
            try
            {
                AbrirConexao();
                RodarScript(
                    $"delete from produtos where produtos.id ={ID}");
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

        //Retorna a id do produto a partir do Código.
        public int RetornaIdProduto(int Codigo)
        {
            int id = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select id from produtos where codigo = '{Codigo}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string campo = dados.Rows[0]["ID"].ToString();
                id = Int32.Parse(campo);
            }
            FecharConexao();
            return id;
        }

        //Retorna a id do produto a partir da Descricao.
        public int RetornaIdProduto(string Descricao)
        {
            int id = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select id from produtos where descricao = '{Descricao}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string campo = dados.Rows[0]["ID"].ToString();
                id = Int32.Parse(campo);
            }
            FecharConexao();
            return id;
        }

        //Retorna a descrição do produto através do ID
        public string RetornaDescricaoProduto(int IdProduto)
        {
            string DescricaoProduto;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select descricao from produtos where id = '{IdProduto}'");
            FecharConexao();
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                DescricaoProduto = dados.Rows[0]["descricao"].ToString();
            }
            else
            {
                DescricaoProduto = "Erro";
            }
            return DescricaoProduto;
        }

        //Retorna a quantidade atual do produto através do ID.
        public int RetornaQuantidadeProduto(int IdProduto)
        {
            int Quantidade = -5000;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select quantidade from produtos where id = '{IdProduto}'");
            FecharConexao();
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string QuantidadeProduto = dados.Rows[0]["quantidade"].ToString();
                Quantidade = Convert.ToInt32(QuantidadeProduto);
            }
            return Quantidade;
        }

        //Retorna o valor do Produto através do ID
        public double RetornaValorProduto(int IdProduto)
        {
            double Valor = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select valor_unitario from produtos where id = '{IdProduto}'");
            FecharConexao();
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string ValorProduto = dados.Rows[0]["valor_unitario"].ToString();
                Valor = Convert.ToDouble(ValorProduto);
            }
            return Valor;
        }

        //Retorna os dados de um unico produto para um datatable a partir do seu id
        public DataTable RetornaDadosProduto(int id)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select produtos.id, produtos.codigo, produtos.descricao, produtos.quantidade, tipos_produtos.descricao as tipo, produtos.subgenero, produtos.valor_unitario, produtos.disponivel_venda from produtos inner join tipos_produtos on tipos_produtos.id = produtos.tipo_produto_id where produtos.id = {id}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de todos os produtos para um datatable
        public DataTable RetonarDadosTodosProdutos()
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select produtos.id, produtos.codigo, produtos.descricao, produtos.quantidade, tipos_produtos.descricao, produtos.subgenero, produtos.valor_unitario, produtos.disponivel_venda from produtos inner join tipos_produtos on tipos_produtos.id = produtos.tipo_produto_id");
            FecharConexao();
            return lerdados;
        }

        //Retorna se já existe cliente cadastrado em alguma venda, impedindo que o mesmo seja excluido.
        public bool ExisteTipoProduto(int TipoProdutoId)
        {
            bool existe;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select produtos.tipo_produto_id from produtos where produtos.tipo_produto_id = {TipoProdutoId}");
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