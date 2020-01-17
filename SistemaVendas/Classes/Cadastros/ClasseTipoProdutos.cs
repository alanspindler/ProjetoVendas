using System;
using System.Data;
using System.Text.RegularExpressions;
using SistemaVendas.Classes.BancoDeDados;
using Microsoft.VisualBasic;


namespace SistemaVendas.Classes.Cadastros
{ 
    public class ClasseTiposProdutos : BancoDados
    {
        #region  Metodos Privados        

        private string ValidarCamposTipoProduto(string Descricao,int idTipoProduto)

        {
            //Se não cair em menhum if, retorna ok
            string Retorno = "ok";            

            if (Descricao == "")
            {
                Retorno = "Prencha corretamente a Descricao";
                return Retorno;
            }            

            if (ValidarDescricaoJaCadastrado(idTipoProduto, Descricao))
            {
                Retorno = "Essa Descrição já está cadastrada para outro Tipo de Produto";
                return Retorno;
            }

            return Retorno;
        }

        //Verifica se um tipo produto com a mesma descrição já está cadastrado, evitando duplicidade
        private bool ValidarDescricaoJaCadastrado(int IdAtual, string Descricao)
        {
            var classeTipoProdutos = new ClasseTiposProdutos();
            int IdProduto = classeTipoProdutos.RetornaIdTipoProduto(Descricao);
            //Quando a função RetornaIDTipoProduto não encontra o código, retorna 0.
            if (IdProduto == 0)
            {
                return false;
            }
            //Se retornou o id atual do tipoProduto, é alteração do próprio tipo de produto e não é duplicado.
            if (IdProduto == IdAtual)
            {
                return false;
            }
            //Se retornou qualquer outro id, já existe cadastrado.
            return true;
        }

        #endregion

        #region  Metodos Publicos
        
        public string IncluirTipoProduto(string Descricao)
        {
            var MsgRetorno = "Cadastro Concluido com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            //Passamos -1 como id para informar que é novo tipoProduto.
            string ResultadoValidacao = (ValidarCamposTipoProduto(Descricao, -1));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Converte de texto para formato de data.                
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"Insert into tipos_produtos (descricao) values ('{Descricao}')");
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

        public string AlterarTipoProduto(int ID, string Descricao)
        {
            var MsgRetorno = "Atualização feita com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            string ResultadoValidacao = (ValidarCamposTipoProduto(Descricao, ID));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {                
                try
                {
                    AbrirConexao();
                    RodarScript(
                      $"update tipos_produtos set descricao = '{Descricao}' where tipos_produtos.id ={ID}");
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

        public string ExcluirTipoProduto(int ID)
        {
            try
            {
                AbrirConexao();
                RodarScript(
                    $"delete from tipos_produtos where tipos_produtos.id ={ID}");
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

        //Retorna a id do tipoProduto a partir do Código.
        public int RetornaIdTipoProduto(string Descricao)
        {
            int id = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select id from tipos_produtos where descricao = '{Descricao}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string campo = dados.Rows[0]["ID"].ToString();
                id = Int32.Parse(campo);
            }
            FecharConexao();
            return id;
        }

        //Retorna os dados de um unico tipoProduto para um datatable a partir do seu id
        public DataTable RetornaDadosTipoProduto(int id)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select * from tipos_produtos where id = {id}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de todos os tipoProdutos para um datatable
        public DataTable RetonarDadosTodosTiposProdutos()
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select * from tipos_produtos");
            FecharConexao();
            return lerdados;
        }

        #endregion
    }
}