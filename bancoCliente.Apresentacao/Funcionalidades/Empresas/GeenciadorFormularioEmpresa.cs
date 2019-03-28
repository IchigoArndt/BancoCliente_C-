using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Empresas
{
    class GeenciadorFormularioEmpresa : GerenciadorFormulario
    {
        public override void Adicionar()
        {
            CadastroEmpresa Empresa = new CadastroEmpresa();
            DialogResult result = Empresa.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Chegou a tela de Empresa");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public override void Atualizar()
        {
            throw new NotImplementedException();
        }

        public override UserControl CarregarListagem()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override string ObtemTipoCadastro()
        {
            throw new NotImplementedException();
        }
    }
}
