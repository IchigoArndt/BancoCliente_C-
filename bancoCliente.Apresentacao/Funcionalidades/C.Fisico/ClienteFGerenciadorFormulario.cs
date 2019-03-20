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
