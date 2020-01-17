using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas.Classes.Cadastros;
using SistemaVendas.Telas.Listas;

namespace SistemaVendas.Telas.Cadastros
{
    public partial class frmClientes : Form
    {        
        private frmListaClientes frmListaClientes;         
        private ClasseClientes classeClientes;
        private int id;
        private bool Inclusao;

        //Ao chamar o form de clientes, informamos se é inclusão ou alteração, e o id da pessoa. Se for inclusão, não tem id, então informamos 0.
        public frmClientes(bool EhInclusao, int cliente_id)
        {
            Inclusao = EhInclusao;
            id = cliente_id;
            InitializeComponent();
            //Inicializa instâncias das outras classes que serão usadas pelos métodos dessa classe
            classeClientes = new ClasseClientes();
            frmListaClientes = new frmListaClientes();            
        }

        #region Metodos Privados
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //Inclusão e alteração tem regras diferentes.
            if (Inclusao)
            {                
                string Retorno = (classeClientes.IncluirCliente(txtNome.Text, mskCPF.Text, msknasc.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, mskCEP.Text, mskCelular.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Cadastro Concluido com Sucesso"))
                {
                    frmListaClientes.RecarregarGridClientes();
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtEndereco.Text = "";
                    txtNome.Text = "";
                    txtUf.Text = "";
                    mskCelular.Text = "";
                    mskCEP.Text = "";
                    msknasc.Text = "";
                    mskCPF.Text = "";
                }

            }
            else
            {
                //Aqui precisa passar o id da pessoa sendo alterada.
                string Retorno = (classeClientes.AlterarCliente(id, txtNome.Text, mskCPF.Text, msknasc.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, mskCEP.Text, mskCelular.Text));
                MessageBox.Show(Retorno);
                if (Retorno.Equals("Atualização feita com Sucesso"))
                {
                    frmListaClientes.RecarregarGridClientes();
                    this.Close();
                }
            }

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Como não é inclusão, é alteração. Quando carregar a tela de clientes em modo alteração, deve carregar os dados da pessoa.
            if (!Inclusao)
            {
                var dados = classeClientes.RetornaDadosCliente(id);
                txtNome.Text = dados.Rows[0]["nome"].ToString();
                mskCPF.Text = dados.Rows[0]["cpf"].ToString();
                mskCEP.Text = dados.Rows[0]["cep"].ToString();
                mskCelular.Text = dados.Rows[0]["celular"].ToString();
                msknasc.Text = dados.Rows[0]["nascimento"].ToString();
                txtEndereco.Text = dados.Rows[0]["endereco"].ToString();
                txtBairro.Text = dados.Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Rows[0]["cidade"].ToString();
                txtUf.Text = dados.Rows[0]["uf"].ToString();
            }
        }

        //Cancela o cadastro e fecha a tela
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
