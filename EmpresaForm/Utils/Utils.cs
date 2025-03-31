using System;
using System.Text.RegularExpressions;

namespace EmpresaForm.Utils
{
    static public class Validacao
    {
        public static bool ValidarCpf(string cpf)
        {
            cpf = LimparString(cpf);
            if (VerificarIgual(cpf)) return false;

            if (cpf.Length != 11) return false;

            int soma = 0; //penultimo digito
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * i;
            }

            int soma2 = 0; //ultimo digito
            for (int i = 0; i < 10; i++)
            {
                soma2 += Convert.ToInt32(cpf[i].ToString()) * i;
            }

            if (soma % 11 != Convert.ToInt32(cpf[9].ToString()) && soma2 % 11 != Convert.ToInt32(cpf[10].ToString())) return false;
            return true;
        }

        private static bool VerificarIgual(string textoLimpo)
        {
            int i = 0;
            for (i = 0; i < textoLimpo.Length; i++)
            {
                if (textoLimpo[i] != textoLimpo[0]) break;
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
