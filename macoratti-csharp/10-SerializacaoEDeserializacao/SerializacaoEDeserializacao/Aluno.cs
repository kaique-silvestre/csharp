using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SeriazalicaoXML
{
    public class Aluno
    {
        public Aluno() { }

        public Aluno(int id, string name, string email, int idade, string porpretyToIgnore)
        {
            Id = id;
            Name = name;
            Email = email;
            Idade = idade;
            PorpretyToIgnore = porpretyToIgnore;
        }

        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int Idade { get; set; }
        [JsonIgnore]
        public string PorpretyToIgnore { get; set; } = String.Empty;
    }
}
