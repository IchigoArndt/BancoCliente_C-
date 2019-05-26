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
        public void PopularListagem(IList<ClienteFisico> Clientes)
        {
            lbClienteFisico.Items.Clear();

            foreach (var item in Clientes)
            {
                lbClienteFisico.Items.Add(item);
            }          
        }
        public ClienteFisico ObtemItemSelecionado()
        {
            return (ClienteFisico)lbClienteFisico.SelectedItem;
        }
    }
}
