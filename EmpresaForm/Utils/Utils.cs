using System;
using System.Text.RegularExpressions;

namespace EmpresaForm.Utils
{
    static public class Validacao
    {
        public static bool ValidarCpf(string cpf)
        {
            cpf = LimparString(cpf);

            if (cpf.Length != 11 || VerificarIgual(cpf))
            {
                return false;
            }

            // para validação do penúltimo dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * i;
            }

            if (soma % 11 >= 10)
            {
                soma = 0;
            }

            // para validação do último dígito verificador
            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += Convert.ToInt32(cpf[i].ToString()) * i;
            }

            if (soma2 % 11 >= 10)
            {
                soma2 = 0;
            }

            // validação final
            var penultimoDigito = Convert.ToInt32(cpf[9].ToString());
            var ultimoDigito = Convert.ToInt32(cpf[10].ToString());

            return !(soma % 11 != penultimoDigito
                && soma2 % 11 != ultimoDigito);
        }

        private static bool VerificarIgual(string textoLimpo)
        {
            int i = 0;
            for (i = 0; i < textoLimpo.Length; i++)
            {
                if (textoLimpo[i] != textoLimpo[0])
                {
                    break;
                }
            }

            return i == textoLimpo.Length;
        }

        private static string LimparString(string texto)
        {
            return Regex.Replace(texto, "[^0-9]", "");
        }
    }

    //

    static public class UFs
    {
        static public string[] Lista { get; } = new string[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"
        };
    }
}
