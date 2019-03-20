using bancoCliente.Apresentacao.Funcionalidades.C.Fisico;
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
        private GerenciadorFormulario _gerenciador;


        private void ClientArea_Fill_Panel_PaintClient(object sender, PaintEventArgs e)
        {

        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            if (e.Tool.Key == "Fisico")
            {
                if(CFG == null)
                {
                    CFG = new ClienteFGerenciadorFormulario();
                }
                CarregarCadastro(CFG);
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

            //UserControl listagem = _gerenciador.CarregarListagem();

            //listagem.Dock = DockStyle.Fill;

            //PanelPrincipal.Controls.Clear();

            //Será Utilizado quando for realizada a consulta ao banco
            //panelControl.Controls.Add(listagem);

            //_gerenciador.Atualizar();

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
