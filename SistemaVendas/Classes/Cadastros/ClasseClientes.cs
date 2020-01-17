using System;
using System.Data;
using System.Text.RegularExpressions;
using SistemaVendas.Classes.BancoDeDados;


namespace SistemaVendas.Classes.Cadastros
{

    public class ClasseClientes : BancoDados
    {
        #region Metodos Privados

        //Valida os campos e retorna o erro. Só segue se retornar ok.
        private string ValidarCamposCliente(string Nome, string Cpf, string Nascimento, string Endereco, string Bairro, string Cidade, string UF, string Cep, string Celular, int idCliente)

        {
            //Se não cair em menhum if, retorna ok
            string Retorno = "ok";
            if (Nome == "")
            {
                Retorno = "Prencha corretamente o nome";
                return Retorno;
            }

            if (Cpf == "")
            {
                Retorno = "Prencha corretamente o CPF";
                return Retorno;
            }

            if ((ValidarCPFCNPJ(Cpf, false) == false))
            {
                Retorno = "CPF Inválido";
                return Retorno;
            }
            else
            {
                bool x = ValidarCPFCNPJ(Cpf, false);
            }

            if (Nascimento == "")
            {
                Retorno = "Prencha corretamente a Data de Nascimento";
                return Retorno;
            }

            if ((ValidarData(Nascimento) == false))
            {
                Retorno = "Data Inválida";
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

            if (Celular == "")
            {
                Retorno = "Prencha corretamente a Celular";
                return Retorno;
            }

            if (Cep == "")
            {
                Retorno = "Prencha corretamente a Cep";
                return Retorno;
            }

            //Valida se o CPF já está cadastrado, para não gerar duplicidade.
            if (ValidarCpfJaCadastrado(idCliente, Cpf))
            {
                Retorno = "Esse CPF já está cadastrado para outro cliente";
                return Retorno;
            }

            return Retorno;
        }

        //Valida se CPF já foi cadastrado, para não gerar duplicidade.
        private static bool ValidarCpfJaCadastrado(int IdAtual, string Cpf)
        {
            var classeClientes = new ClasseClientes();
            int IdCliente = classeClientes.RetornaIdCliente(Cpf);
            //Quando a função RetornaIDCliente não encontra o cpf, retorna 0.
            if (IdCliente == 0)
            {
                return false;
            }
            //Se retornou o id atual da pessoa, é alteração da própria pessoa e não é duplicado.
            if (IdCliente == IdAtual)
            {
                return false;
            }
            //Se retornou qualquer outro id, já existe cadastrado.
            return true;
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

        //Função que valida o Cpf e retorna verdadeiro ou falso.
        public bool ValidarCPFCNPJ(string cpfcnpj, bool vazio)
        {
            if (string.IsNullOrEmpty(cpfcnpj))
                return vazio;
            else
            {
                int[] d = new int[14];
                int[] v = new int[2];
                int j, i, soma;
                string Sequencia, SoNumero;

                SoNumero = Regex.Replace(cpfcnpj, "[^0-9]", string.Empty);

                //verificando se todos os numeros são iguais
                if (new string(SoNumero[0], SoNumero.Length) == SoNumero) return false;

                // se a quantidade de dígitos numérios for igual a 11
                // iremos verificar como CPF
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
                // CPF ou CNPJ inválido se
                // a quantidade de dígitos numérios for diferente de 11 e 14
                else return false;
            }
        }

        #endregion

        #region Metodos Publicos

        public string IncluirCliente(string Nome, string Cpf, string Nascimento, string Endereco, string Bairro,
            string Cidade, string UF, string Cep, string Celular)
        {
            var MsgRetorno = "Cadastro Concluido com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            //Passamos -1 como id para informar que é novo cliente.
            string ResultadoValidacao = (ValidarCamposCliente(Nome, Cpf, Nascimento, Endereco, Bairro,
                Cidade, UF, Cep, Celular, -1));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Converte de texto para formato de data.
                DateTime DataNascimento = Convert.ToDateTime(Nascimento);
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"Insert into clientes (nome, Cpf, nascimento, endereco, bairro, cidade, uf, cep, celular) values ('{Nome}','{Cpf}', convert(datetime, '{DataNascimento}', 103),'{Endereco}','{Bairro}','{Cidade}','{UF}','{Cep}','{Celular}')");
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

        public string AlterarCliente(int ID, string Nome, string Cpf, string Nascimento, string Endereco, string Bairro,
            string Cidade, string UF, string Cep, string Celular)
        {
            var MsgRetorno = "Atualização feita com Sucesso";
            //Se passar nas validações, insere no banco e retorna ok
            string ResultadoValidacao = (ValidarCamposCliente(Nome, Cpf, Nascimento, Endereco, Bairro,
                Cidade, UF, Cep, Celular, ID));
            //Se a validacao deu certo, pode inserir os dados no banco
            if (ResultadoValidacao == "ok")
            {
                //Converte de texto para formato de data.
                DateTime DataNascimento = Convert.ToDateTime(Nascimento);
                try
                {
                    AbrirConexao();
                    RodarScript(
                        $"update clientes set nome = '{Nome}', Cpf ='{Cpf}', nascimento = convert(datetime, '{Nascimento}', 103), endereco='{Endereco}', bairro='{Bairro}', cidade = '{Cidade}' , uf='{UF}', cep='{Cep}', celular ='{Celular}' where clientes.id ={ID}");
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

        //Exclui o cliente.
        public string ExcluirCliente(int ID)
        {
            try
            {
                AbrirConexao();
                RodarScript(
                    $"delete from clientes where clientes.id ={ID}");
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

        //Retorna a id do cliente a partir do CPF.
        public int RetornaIdCliente(string Cpf)
        {
            int id = 0;
            AbrirConexao();
            var dados = LerDadosBancoDeDados($"select id from clientes where Cpf = '{Cpf}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                string campo = dados.Rows[0]["ID"].ToString();
                id = Int32.Parse(campo);
            }
            FecharConexao();
            return id;
        }

        //Retorna a id do cliente a partir do CPF.
        public string RetornaCPFCliente(string Nome)
        {
            string cpf ="";
            AbrirConexao();
            var dados = LerDadosBancoDeDados(Script: $"select cpf from clientes where nome Like  '%{Nome}%'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                cpf = dados.Rows[0]["cpf"].ToString();                
            }
            FecharConexao();
            return cpf;
        }

        //Retorna a razão social do Fornecedor através do seu id
        public string RetornaNomeCliente(int id)
        {
            string RazaoSocial; AbrirConexao();
            var dados = LerDadosBancoDeDados($"select nome from clientes where id = '{id}'");
            //Se não retornar nada no Select, não traz o id
            if (dados.Rows.Count > 0)
            {
                RazaoSocial = dados.Rows[0]["nome"].ToString();
            }
            else
            {
                RazaoSocial = "Erro";
            }
            FecharConexao();
            return RazaoSocial;
        }

        //Retorna os dados de um unico cliente para um datatable a partir do seu id
        public DataTable RetornaDadosCliente(int id)
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select * from clientes where id = {id}");
            FecharConexao();
            return lerdados;
        }

        //Retorna os dados de todos os clientes para um datatable
        public DataTable RetonarDadosTodosClientes()
        {
            AbrirConexao();
            var lerdados = LerDadosBancoDeDados($"select * from clientes");
            FecharConexao();
            return lerdados;
        }

        #endregion
    }
}