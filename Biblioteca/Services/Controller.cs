﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca.Services
{
    public class Controller
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

        public bool ValidarSenha(string senha)
        {
            // Cria a expressao regular de validacao
            string regexSenha = @"^(?=.*[@#$%^&+çÇ=])(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,10}$";
            return Regex.IsMatch(senha, regexSenha, RegexOptions.IgnoreCase);
        }

        public void Cancelar()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {                
                //Chama a tela principal
                LoginForm form = new LoginForm();               
                form.Show();
            }
        }

    }
}
