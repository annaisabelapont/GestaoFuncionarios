using EmpresaForm.Models;

namespace EmpresaForm
{
    // essa classe é como um cookie que mantém o contexto entre os 2 formulários de cadastro
    static public class TemporaryContext
    {
        //static public Funcionario[] FuncionarioTemp { get; set; } = new Funcionario[1];
        static public Funcionario FuncionarioTemp { get; set; }
    }
}
