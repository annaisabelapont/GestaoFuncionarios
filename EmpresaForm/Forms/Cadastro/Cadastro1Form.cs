using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EmpresaForm.Models;
using EmpresaForm.Utils;

namespace EmpresaForm
{
    public partial class Cadastro1Form: Form
    {
        static int IdFuncionario = 1;
        public Cadastro1Form()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
        private void btProx_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario();

            funcionario.Id = IdFuncionario;
            funcionario.Nome = txtNome.Text;
            funcionario.Rg = txtRg.Text;
            funcionario.Telefone = txtTel.Text;
            funcionario.Ctps = txtCtps.Text;
            funcionario.Setor = txtSetor.Text;
            funcionario.Funcao = txtFuncao.Text;
            funcionario.NumeroSala = Convert.ToInt32(txtSala.Text);

            bool camposPreenchidos = txtNome.Text != "" || txtRg.Text != "" || txtTel.Text != ""
                || txtCtps.Text != "" || txtSetor.Text != "" 
                || txtFuncao.Text != "" || txtSala.Text != "";

            if (camposPreenchidos && Validacao.ValidarCpf(txtCpf.Text))
            {
                funcionario.Cpf = txtCpf.Text;

                IdFuncionario++;

                TemporaryContext.FuncionarioTemp[0] = funcionario;

                this.Hide();

                new Cadastro2Form(this).ShowDialog();
            }
            else
            {
                MessageBox.Show("Consulte as informações antes de continuar.", "Erro", MessageBoxButtons.OK);
            }
        }

        //

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtTel.Clear();
            txtCtps.Clear();
            txtSetor.Clear();
            txtFuncao.Clear();
            txtSala.Clear();
        }
    }
}
