using System;
using System.Data;
using System.Text.RegularExpressions;
using SistemaVendas.Classes.BancoDeDados;


namespace SistemaVendas.Classes.Cadastros
{
    public class ClasseFornecedores : BancoDados
    {
        #region Metodos Privados

        private string ValidarCamposfornecedor(string RazaoSocial, string Cnpj, string Endereco, string Bairro, string Cidade, string UF, string Cep, string Telefone, int idfornecedor)

        {
            //Se não cair em menhum if, retorna ok
            string Retorno = "ok";
            if (RazaoSocial == "")
            {
                Retorno = "Prencha corretamente a Razão Social";
                return Retorno;
            }

            if (Cnpj == "")
            {
                Retorno = "Prencha corretamente o CNPJ";
                return Retorno;
            }

            if ((ValidarCpfCnpj(Cnpj, false) == false))
            {
                Retorno = "CNPJ Inválido";
                return Retorno;
            }

            if (Endereco == "")
            {
                Retorno = "Prencha corretamente o Endereco";
                return Retorno;
            }

            if (Bairro == "")
            {
                Retorno = "Prencha corretamente o Bairro";
                return Retorno;
            }

            if (Cidade == "")
            {
                Retorno = "Prencha corretamente a Cidade";
                return Retorno;
            }

            if (UF == "")
            {
                Retorno = "Prencha corretamente o Estado";
                return Retorno;
            }

            if (Telefone == "")
            {
                Retorno = "Prencha corretamente o Telefone";
                return Retorno;
            }

            if (Cep == "")
            {
                Retorno = "Prencha corretamente a Cep";
                return Retorno;
            }

            if (ValidarCnpjJaCadastrado(idfornecedor, Cnpj))
            {
                Retorno = "Esse CNPJ já está cadastrado para outro Fornecedor";
                return Retorno;
            }

            return Retorno;
        }

        //Função que valida o cnpj e retorna verdadeiro ou falso.
        private bool ValidarCpfCnpj(string cnpjcnpj, bool vazio)
        {
            if (string.IsNullOrEmpty(cnpjcnpj))
                return vazio;
            else
            {
                int[] d = new int[14];
                int[] v = new int[2];
                int j, i, soma;
                string Sequencia, SoNumero;

                SoNumero = Regex.Replace(cnpjcnpj, "[^0-9]", string.Empty);

                //verificando se todos os numeros são iguais
                if (new string(SoNumero[0], SoNumero.Length) == SoNumero) return false;

                // se a quantidade de dígitos numérios for igual a 11
                // iremos verificar como cnpj
                if (SoNumero.Length == 11)
                {
                    for (i = 0; i <= 10; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 8 + i; j++) soma += d[j] * (10 + i - j);

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[9] & v[1] == d[10]);
                }
                // se a quantidade de dígitos numérios for igual a 14
                // iremos verificar como CNPJ
                else if (SoNumero.Length == 14)
                {
                    Sequencia = "6543298765432";
                    for (i = 0; i <= 13; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 11 + i; j++)
                            soma += d[j] * Convert.ToInt32(Sequencia.Substring(j + 1 - i, 1));

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[12] & v[1] == d[13]);
                }
                // cnpj ou CNPJ inválido se
                // a quantidade de dígitos numérios for diferente de 11 e 14
                else return false;
            }
        }

        //Valida se CNPJ já foi cadastrado
        private bool ValidarCnpjJaCadastrado(int IdAtual, string cnpj)
        {
            var classefornecedores = new ClasseFornecedores();
            int Idfornecedor = classefornecedores.RetornaIdFornecedor(cnpj);
            //Quando a função RetornaIDfornecedor não encontra o cnpj, retorna 0.
            if (Idfornecedor == 0)
            {
                return false;
            }
            //Se retornou o id atual da pessoa, é alteração da própria pessoa e não é duplicado.
            if (Idfornecedor == IdAtual)
            {
                return false;
            }
            //Se retornou qualquer outro id, já existe cadastrado.
            return true;
        }

        #endregion

        #region Metodos Publicos

        public string IncluirFornecedor(string RazaoSocial, string Cnpj, string Endereco, string Bairro,
            string Cidade, string UF, string Cep, string Telefone)
        {
            var MsgRetorno = "Cadastro Concluido com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            //Passamos -1 como id para informar que é novo fornecedor.
            string ResultadoValidacao = (ValidarCamposfornecedor(RazaoSocial, Cnpj, Endereco, Bairro,
                Cidade, UF, Cep, Telefone, -1));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"Insert into fornecedores (razaosocial, cnpj, endereco, bairro, cidade, uf, cep, telefone) values ('{RazaoSocial}','{Cnpj}', '{Endereco}','{Bairro}','{Cidade}','{UF}','{Cep}','{Telefone}')");
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

        public string AlterarFornecedor(int ID, string RazaoSocial, string Cnpj, string Endereco, string Bairro,
            string Cidade, string UF, string Cep, string Telefone)
        {
            {
                var MsgRetorno = "Atualização feita com Sucesso";
                //Se passar nas validações, insere no banco e retorna ok
                string ResultadoValidacao = (ValidarCamposfornecedor(RazaoSocial, Cnpj, Endereco, Bairro,
                    Cidade, UF, Cep, Telefone, ID));
                //Se a validacao deu certo, pode inserir os dados no banco
                if (ResultadoValidacao == "ok")
                {
                    //Converte de texto para formato de data.                
                    try
                    {
                        AbrirConexao();
                        RodarScript(
                            $"update fornecedores set razaosocial = '{RazaoSocial}', cnpj ='{Cnpj}', endereco='{Endereco}', bairro='{Bairro}', cidade = '{Cidade}' , uf='{UF}', cep='{Cep}', telefone ='{Telefone}' where fornecedores.id ={ID}");
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
        }

        public string ExcluirFornecedor(int ID)
        {
            try
            {
                AbrirConexao();
                RodarScript(
                    $"delete from fornecedores where fornecedores.id ={ID}");
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

        //Retorna a id do fornecedor a partir do cnpj.
        public int RetornaIdFornecedor(string cnpj)
        {
            int id = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select id from fornecedores where cnpj = '{cnpj}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string campo = dados.Rows[0]["ID"].ToString();
                id = Int32.Parse(campo);
            }
            FecharConexao();
            return id;
        }

        //Retorna a id do fornecedor a partir do cnpj.
        public int RetornaIdFornecedorPelaRazaoSocial(string razaoSocial)
        {
            int id = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select id from fornecedores where razaosocial = '{razaoSocial}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string campo = dados.Rows[0]["ID"].ToString();
                id = Int32.Parse(campo);
            }
            FecharConexao();
            return id;
        }

        //Retorna a razão social do Fornecedor através do seu id
        public string RetornaRazaoSocialFornecedor(int id)
        {
            string RazaoSocial; AbrirConexao();
            var dados = LerDadosBancoDeDados($"select razaosocial from fornecedores where id = '{id}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                RazaoSocial = dados.Rows[0]["razaosocial"].ToString();
            }
            else
            {
                RazaoSocial = "Erro";
            }
            FecharConexao();
            return RazaoSocial;
        }

        //Retorna os dados de um unico fornecedor para um datatable a partir do seu id
        public DataTable RetornaDadosFornecedor(int id)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select * from fornecedores where id = {id}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de todos os fornecedores para um datatable
        public DataTable RetonarDadosTodosFornecedores()
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select * from fornecedores");
            FecharConexao();
            return lerdados;
        }

        #endregion
    }
}

