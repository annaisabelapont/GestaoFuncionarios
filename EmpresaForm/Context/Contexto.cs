using System.Collections.Generic;
using EmpresaForm.Models;

namespace EmpresaForm.Context
{
    public static class Contexto
    {
        public static List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario>();
    }
}
