using System.Data;
using System.Data.SqlClient;


namespace SistemaVendas.Classes.BancoDeDados
{
    public class BancoDados
    {
		//Autenticação Windows
        //string StringConexao = "server=localhost\\sqlexpress;database=sistemavendas;Uid=auth_windows";
		//Autenticação SQL Server		
		private string StringConexao = "server=localhost\\sqlexpress;database=sistemavendas;UID=sa;password=123";
        private SqlConnection ConexaoBanco;

        #region Metodos Protegidos
        //Metodo para abrir conexão no banco de dados.
        protected void AbrirConexao()
        {
            ConexaoBanco = new SqlConnection(StringConexao);
            ConexaoBanco.Open();
        }

        //Metodo para encerrar conexão no banco de dados
        protected void FecharConexao()
        {
            ConexaoBanco.Close();
        }

        //Metodo para rodar comando SQL no banco
        protected void RodarScript(string Script)
        {
            SqlCommand ComandoSql = new SqlCommand(Script, ConexaoBanco);
            ComandoSql.ExecuteNonQuery();
        }

        //Metodo para retornar dados do banco de dados através de um select
        protected DataTable LerDadosBancoDeDados(string Script)
        {
            var Dt = new DataTable();
            SqlCommand ComandoSql = new SqlCommand(Script, ConexaoBanco);
            SqlDataReader Dados = ComandoSql.ExecuteReader();
            Dt.Load(Dados);
            Dados.Close();
            return Dt;
        }

        //Metodo para ler os dados do banco para que possam ser carregados num componente datagridview (tabela)
        protected object ShowDataInGridView(string Script)
        {
            SqlDataAdapter Dados = new SqlDataAdapter(Script, ConexaoBanco);
            DataSet ds = new DataSet();
            Dados.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        #endregion
    }
}
