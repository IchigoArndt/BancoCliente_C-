using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;

namespace bancoCliente.Apresentacao.Funcionalidades.Funcionarios
{
    public partial class funcionarioControl : UserControl
    {
        public funcionarioControl()
        {
            InitializeComponent();
        }

        public void PopularListagem(IList<Funcionario> Clientes)
        {
            lbFuncionario.Items.Clear();

            foreach (Funcionario item in Clientes)
            {
                lbFuncionario.Items.Add(item);
            }
        }
        public Funcionario ObtemDisciplinaSelecionada()
        {
            return (Funcionario)lbFuncionario.SelectedItem;
        }
    }
}
