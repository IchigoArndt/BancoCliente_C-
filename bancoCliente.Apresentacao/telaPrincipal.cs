using bancoCliente.Apresentacao.Funcionalidades.C.Fisico;
using bancoCliente.Apresentacao.Funcionalidades.ClientesJuridicos;
using bancoCliente.Apresentacao.Funcionalidades.Contas;
using bancoCliente.Apresentacao.Funcionalidades.Empresas;
using bancoCliente.Apresentacao.Funcionalidades.Funcionarios;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
            alteraEstadoBotoes(false);
        }

        private static ClienteFGerenciadorFormulario CFG;
        private static GerenciadorFormularioCJ CJ;
        private static GerenciadorFormularioConta CONTA;
        private static GeenciadorFormularioEmpresa EMPRESA;
        private static GerenciadorFormularioFuncionario FUNCIONARIO;
        private GerenciadorFormulario _gerenciador;


        private void ClientArea_Fill_Panel_PaintClient(object sender, PaintEventArgs e)
        {

        }

        private void CarregarCadastro(GerenciadorFormulario gerenciador)
        {
             _gerenciador = gerenciador;
            /*Estes Metodos serão utilizados quando houver conexão com o Banco de Dados*/
             UserControl listagem = _gerenciador.CarregarListagem();
             listagem.Dock = DockStyle.Fill;
             PanelPrincipal.Controls.Clear();
            //Será Utilizado quando for realizada a consulta ao banco
             PanelPrincipal.Controls.Add(listagem);
            _gerenciador.Atualizar();
             alteraEstadoBotoes(true);
            lblCadastro.Text = _gerenciador.ObtemTipoCadastro();
        }


        private void alteraEstadoBotoes(bool estado)
        {
            btnCadastrar.Enabled = estado;
            btnEditar.Enabled = estado;
            btnExcluir.Enabled = estado;
    }

        private void tsmFisico_Click(object sender, System.EventArgs e)
        {
            if(CFG == null)
            {
                CFG = new ClienteFGerenciadorFormulario();
                CarregarCadastro(CFG);
            }
            else
            {
                CarregarCadastro(CFG);
            }
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            _gerenciador.Adicionar();
        }

        private void tsmJuridica_Click(object sender, System.EventArgs e)
        {
            if (CJ == null)
            {
                CJ = new GerenciadorFormularioCJ();
                CarregarCadastro(CJ);
            }
            else
            {
                CarregarCadastro(CJ);
            }
        }

        private void tsmItemConta_Click(object sender, System.EventArgs e)
        {
            if (CONTA == null)
            {
                CONTA = new GerenciadorFormularioConta();
                CarregarCadastro(CONTA);
            }
            else
            {
                CarregarCadastro(CONTA);
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(EMPRESA == null)
            {
                EMPRESA = new GeenciadorFormularioEmpresa();
                CarregarCadastro(EMPRESA);
            }
            else
            {
                CarregarCadastro(EMPRESA);
            }
        }
    }
}
