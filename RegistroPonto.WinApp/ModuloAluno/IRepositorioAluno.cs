using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.WinApp.ModuloAluno
{
    public interface IRepositorioAluno
    {
        void Adicionar(Aluno aluno);

        List<Aluno> SelecionarTodos();
    }
}
