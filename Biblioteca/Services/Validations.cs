using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca.Services
{
    public class Validations
    {
        public bool ValidarEmail(string email)
        {
            // Cria a expressao regular de validacao
            string regexEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, regexEmail, RegexOptions.IgnoreCase); 
        }

        public bool ValidarCPF(string cpf)
        {
            // Cria a expressao regular de validacao
            string regexCPF = @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$";
            return Regex.IsMatch(cpf, regexCPF, RegexOptions.IgnoreCase);
        }

    }
}
