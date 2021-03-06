﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bancoCliente.Dominio.Funcionalidades.Clientes;

namespace bancoCliente.Apresentacao.Funcionalidades.ClientesJuridicos
{
    public partial class CJControl : UserControl
    {
        public CJControl()
        {
            InitializeComponent();
        }
        public void PopularListagem(IList<ClienteJuridico> Clientes)
        {
            lbCJ.Items.Clear();

            foreach (ClienteJuridico item in Clientes)
            {
                lbCJ.Items.Add(item);
            }
        }
        public ClienteJuridico ObtemClienteSelecionado()
        {
            return (ClienteJuridico)lbCJ.SelectedItem;
        }

        private void lbCJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
