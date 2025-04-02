using System;
using System.Windows.Forms;
using EmpresaForm.Utils;
using EmpresaForm.Models;
using EmpresaForm.Context;

namespace EmpresaForm
{
    public partial class Cadastro2Form: Form
    {
        Funcionario funcionario = TemporaryContext.FuncionarioTemp[0];

        Cadastro1Form formAnterior = new Cadastro1Form();

        public Cadastro2Form(Cadastro1Form form)
        {
            InitializeComponent();

            formAnterior = form;

            cbUF.DataSource = UFs.Lista;
            cbUF.SelectedIndex = -1;
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            formAnterior.Show();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool camposPreenchidos = txtCidade.Text != "" || txtBairro.Text == ""
                || txtNumero.Text == "" || txtCep.Text == "";

            if (camposPreenchidos)
            {
                funcionario.Cidade = txtCidade.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.NumeroCasa = Convert.ToInt32(txtNumero.Text);
                funcionario.Cep = txtCep.Text;

                Contexto.ListaFuncionarios.Add(funcionario);

                TemporaryContext.FuncionarioTemp[0] = new Funcionario();

                LimparFormulario();
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);

                this.Close();
                formAnterior.Close();
            }
            else
            {
                MessageBox.Show("Preencha todas as informações antes de efetuar o cadastro!");
            }

        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbUF.SelectedIndex;
            if (index != -1)
            {
                funcionario.Uf = Utils.UFs.Lista[index];
            }
        }

        //

        private void LimparFormulario()
        {
            cbUF.SelectedIndex = -1;
            txtCidade.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCep.Clear();
        }
    }
}
