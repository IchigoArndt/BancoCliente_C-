using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bancoCliente.Dominio.Funcionalidades.Empresa;

namespace bancoCliente.Apresentacao.Funcionalidades.Empresas
{
    public partial class empresaControl : UserControl
    {
        public empresaControl()
        {
            InitializeComponent();
        }
        public void PopularListagem(IList<Empresa> Clientes)
        {
            lbEmpresa.Items.Clear();

            foreach (Empresa item in Clientes)
            {
                lbEmpresa.Items.Add(item);
            }
        }
        public Empresa ObtemDisciplinaSelecionada()
        {
            return (Empresa)lbEmpresa.SelectedItem;
        }
    }
}
