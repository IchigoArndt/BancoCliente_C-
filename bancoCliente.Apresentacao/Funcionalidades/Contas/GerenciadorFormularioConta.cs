using bancoCliente.Dominio.Funcionalidades.Conta;
using BancoCliente.Servico.Funcionalidade.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Contas
{
    public class GerenciadorFormularioConta : GerenciadorFormulario
    {
        ContaServico _contaServico = new ContaServico();
        ContaControl _contaControl = new ContaControl();

        public override void Adicionar()
        {
            CadastroConta Conta = new CadastroConta();
            DialogResult result = Conta.ShowDialog();
            if(result == DialogResult.OK)
            {
                try
                {
                    _contaServico.Adicionar(Conta.conta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void Atualizar()
        {
           //
        }

        public override UserControl CarregarListagem()
        {
            if (_contaControl == null)
            {
                _contaControl = new ContaControl();
            }
            return _contaControl;
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
            return "Cadastro Conta";
        }
    }
}
