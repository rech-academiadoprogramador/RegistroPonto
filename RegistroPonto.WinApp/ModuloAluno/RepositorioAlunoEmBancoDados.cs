using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.WinApp.ModuloAluno
{
    internal class RepositorioAlunoEmBancoDados : IRepositorioAluno
    {
        public void Adicionar(Aluno aluno)
        {
            string sqlInserir =
                $"INSERT INTO TBALUNO (ID, NOME, TELEFONE) VALUES ({aluno.Id}, {aluno.Nome}, {aluno.Telefone} )";

            SqlCommand comandoInserir = new SqlCommand(sqlInserir);
            comandoInserir.ExecuteNonQuery();

        }

        public List<Aluno> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
