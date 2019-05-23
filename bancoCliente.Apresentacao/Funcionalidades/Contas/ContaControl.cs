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
        public void PopularListagem(IList<Conta> Contas)
        {
            //lbConta.Items.Clear();

            foreach (Conta item in Contas)
            {
            }
        }
        /*public Conta ObtemDisciplinaSelecionada()
        {
            return (Conta)lbConta.SelectedItem;
        }*/

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }
    }
}
