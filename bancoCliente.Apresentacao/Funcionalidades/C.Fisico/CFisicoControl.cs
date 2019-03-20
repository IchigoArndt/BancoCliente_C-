using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bancoCliente.Dominio.Funcionalidades.Clientes;

namespace bancoCliente.Apresentacao.Funcionalidades.C.Fisico
{
    public partial class CFisicoControl : UserControl
    {
        public CFisicoControl()
        {
            InitializeComponent();
        }
        public void PopularListagemLivros(IList<ClienteFisico> Clientes)
        {
            lbCFisicoControl.Items.Clear();

            foreach (ClienteFisico item in Clientes)
            {
                lbCFisicoControl.Items.Add(item);
            }
        }
        public ClienteFisico ObtemDisciplinaSelecionada()
        {
            return (ClienteFisico)lbCFisicoControl.SelectedItem;
        }
    }
}
