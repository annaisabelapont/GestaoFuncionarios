using System;
using System.Windows.Forms;

namespace EmpresaForm
{
    public partial class MenuInicialForm: Form
    {
        public MenuInicialForm()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            new Cadastro1Form().ShowDialog();
        }

        private void btListagem_Click(object sender, EventArgs e)
        {
            new ListagemForm().ShowDialog();
        }
    }
}
