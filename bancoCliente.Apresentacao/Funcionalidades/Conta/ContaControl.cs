using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bancoCliente.Dominio.Funcionalidades.Conta;

namespace bancoCliente.Apresentacao.Funcionalidades.Contas
{
    public partial class ContaControl : UserControl
    {
        public ContaControl()
        {
            InitializeComponent();
        }
        public void PopularListagem(IList<ContaDominio> Contas)
        {
            lbConta.Items.Clear();

            foreach (ContaDominio item in Contas)
            {
                lbConta.Items.Add(item);
            }
        }
        public ContaDominio ObtemContaSelecionada()
        {
            return (ContaDominio)lbConta.SelectedItem;
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }
    }
}
