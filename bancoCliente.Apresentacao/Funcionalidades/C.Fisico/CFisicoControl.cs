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

        /*public void PopularListagem(IList<ClienteFisico> Clientes)
        {
            DataTable T_Gender = new DataTable();
            T_Gender.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID"),
                new DataColumn("Nome"),
                new DataColumn("Limite"),
                new DataColumn("Direito Cheque"),
                new DataColumn("Direito Cartão"),
                new DataColumn("Limite Pagamento"),
                new DataColumn("CPF"),
            });
            foreach (ClienteFisico item in Clientes)
            {
                T_Gender.Rows.Add(new object[] {item.id,item.nome,
                    item.getLimite(),
                    item.isDireitoCheque(),
                    item.isCartaoCredito(),
                    item.getLimitePagamento(),
                    item.getCpf()});
            }
            ugClienteFisico.DataSource = T_Gender;
        }
        */

        //public ClienteFisico ObtemDisciplinaSelecionada()
        //{
        //return (ClienteFisico)lbCFisicoControl.SelectedItem;
        //}
    }
}
