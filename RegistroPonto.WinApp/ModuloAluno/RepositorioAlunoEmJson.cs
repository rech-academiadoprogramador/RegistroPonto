using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RegistroPonto.WinApp.ModuloAluno
{
    internal class RepositorioAlunoEmJson : IRepositorioAluno
    {
        private List<Aluno> alunos;

        public RepositorioAlunoEmJson(List<Aluno> alunos)
        {
            this.alunos = alunos;           
        }

        public void Adicionar(Aluno novoAluno)
        {
            this.alunos.Add(novoAluno);

            string arquivo = JsonSerializer.Serialize(alunos);

            File.WriteAllText(@"C:\temp\registroponto.json", arquivo);
        }

        public List<Aluno> SelecionarTodos()
        {
            string arquivo = File.ReadAllText(@"C:\temp\registroponto.json");

            return JsonSerializer.Deserialize<List<Aluno>>(arquivo)!;            
        }
    }
}
