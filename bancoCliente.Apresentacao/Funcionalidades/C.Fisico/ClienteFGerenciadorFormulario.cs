using BancoCliente.Servico.Funcionalidade.Clientes.Fisico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.C.Fisico
{
    public class ClienteFGerenciadorFormulario : GerenciadorFormulario
    {
        CFisicoControl _clienteFisicoControl;
        ClienteFisicoServico _clienteServico = new ClienteFisicoServico();

        public override void Adicionar()
        {
            CadastroClienteFisico dialog = new CadastroClienteFisico();

            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    /* Fica  Para quando for implementado o acesso ao banco 
                    */
                    //_livroService.Adicionar(dialog.livro);
                    //ListarLivros();
                    MessageBox.Show("Abriu a Tela !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void Atualizar()
        {
            //_clienteFisicoControl.PopularListagem(null);
        }

        public override UserControl CarregarListagem()
        {
            if(_clienteFisicoControl == null)
            {
                _clienteFisicoControl = new CFisicoControl();
            }
            return _clienteFisicoControl;
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
            return "Cadastro Cliente Físico";
        }
    }
}
