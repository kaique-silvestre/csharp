using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao
{
    internal class Departamento
    {
        public string? Nome { get; set; }
        private List<Professor>? Professores { get; set; }

        public Departamento(string? nome)
        {
            this.Nome = nome;
            this.Professores = new List<Professor>();
        }
        public void IncluirProfessor(Professor professor)
        {
            this.Professores?.Add(professor);
        }
        public void ListarProfessores()
        {
            Console.WriteLine($"Departamento de: {this.Nome}");
            
            foreach (var professor in Professores)
            {
                Console.WriteLine($"{professor.Nome}");
            }
        }
    }
}
