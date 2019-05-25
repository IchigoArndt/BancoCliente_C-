using BancoCliente.Servico.Funcionalidade.Empresas;
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
        EmpresaServico _empresaServico;
        empresaControl _empresaControl; 
        public override void Adicionar()
        {
            CadastroEmpresa Empresa = new CadastroEmpresa();
            DialogResult result = Empresa.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    _empresaServico.Adicionar(Empresa.empresa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void Atualizar()
        {
            //throw new NotImplementedException();
        }

        public override UserControl CarregarListagem()
        {
            if(_empresaControl == null)
            {
                _empresaControl = new empresaControl();
            }
                return _empresaControl;
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
            return "Cadastro de Empresa";
        }
    }
}
