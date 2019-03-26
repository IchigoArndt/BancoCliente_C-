using bancoCliente.Apresentacao.Funcionalidades.C.Fisico;
using bancoCliente.Apresentacao.Funcionalidades.ClienteJuridico;
using bancoCliente.Apresentacao.Funcionalidades.Conta;
using bancoCliente.Apresentacao.Funcionalidades.Empresa;
using bancoCliente.Apresentacao.Funcionalidades.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Procurar um jeito de refatorar 
        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "Fisico":
                 {
                  if(CFG == null)
                    {
                            CFG = new ClienteFGerenciadorFormulario();
                            CarregarCadastro(CFG);
                    }
                  break;
                 }
                case "Juridico":
                    {
                        if (CJ == null)
                        {
                            CJ = new GerenciadorFormularioCJ();
                            CarregarCadastro(CJ);
                        }
                        break;
                    }
                case "Conta":
                    {
                        if (CONTA == null)
                        {
                            CONTA = new GerenciadorFormularioConta();
                            CarregarCadastro(CONTA);
                        }
                        break;
                    }
                case "Empresa":
                    {
                        if (EMPRESA == null)
                        {
                            EMPRESA = new GeenciadorFormularioEmpresa();
                            CarregarCadastro(EMPRESA);
                        }
                        break;
                    }
                case "Funcionarios":
                    {
                        if (FUNCIONARIO == null)
                        {
                            FUNCIONARIO = new GerenciadorFormularioFuncionario();
                            CarregarCadastro(FUNCIONARIO);
                        }
                        break;
                    }
            }
            if (e.Tool.Key == "Adicionar")
            {
                if (_gerenciador != null) 
                {
                    _gerenciador.Adicionar();
                }
            }
            
        }

        private void CarregarCadastro(GerenciadorFormulario gerenciador)
        {
            _gerenciador = gerenciador;

            /*Estes Metodos serão utilizados quando houver conexão com o Banco de Dados
            //UserControl listagem = _gerenciador.CarregarListagem();
            //listagem.Dock = DockStyle.Fill;
            //PanelPrincipal.Controls.Clear();
            //Será Utilizado quando for realizada a consulta ao banco
            //panelControl.Controls.Add(listagem);
            //_gerenciador.Atualizar();
            */

            alteraEstadoBotoes(true);
        }


        private void alteraEstadoBotoes(bool estado)
        {
            ultraToolbarsManager1.Tools[9].SharedProps.Enabled = estado;
            ultraToolbarsManager1.Tools[10].SharedProps.Enabled = estado;
            ultraToolbarsManager1.Tools[11].SharedProps.Enabled = estado;
        }
    }
}
