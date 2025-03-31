using System.Windows.Forms;
using EmpresaForm.Context;

namespace EmpresaForm
{
    public partial class ListagemForm: Form
    {
        public ListagemForm()
        {
            InitializeComponent();
            dtTabela.DataSource = Contexto.ListaFuncionarios;
        }
    }
}
