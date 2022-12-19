using CursosDeIdiomas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Domain
{
    public class Aluno : Base
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

    }
}
