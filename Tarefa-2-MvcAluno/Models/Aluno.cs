using System;
using System.ComponentModel.DataAnnotations;

namespace MvcAluno.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
    }
}