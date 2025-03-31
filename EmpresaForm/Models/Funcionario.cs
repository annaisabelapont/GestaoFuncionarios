namespace EmpresaForm.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Ctps { get; set; }
        public string Funcao { get; set; }
        public string Setor { get; set; }
        public int NumeroSala { get; set; }
        public string Telefone { get; set; }

        //

        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int NumeroCasa { get; set; }
        public string Cep { get; set; }
    }
}
