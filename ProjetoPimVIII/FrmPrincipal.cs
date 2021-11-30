using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPimVIII
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Método para verificar se o formulário existe, caso não existir ele criará um novo formulário
        // Se existir ele mostrará o formulário criado
        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeuFormulario.FormCadastro == null)
            {
                MeuFormulario.FormCadastro = new FrmCadastroPessoas();
            }
            MeuFormulario.FormCadastro.Show();
            MeuFormulario.FormCadastro.Focus();
        }

        private void consultaDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeuFormulario.FormConsulta == null)
            {
                MeuFormulario.FormConsulta = new FrmConsultaPessoa();
            }
            MeuFormulario.FormConsulta.Show();
            MeuFormulario.FormConsulta.Focus();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
