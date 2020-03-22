using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Aluguel
    {
        #region Atributos
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion
        #region Construtor
        public Aluguel (string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
        #endregion
        public override string ToString()
        {
            return Nome + "," + Email;
        }
    }
}
