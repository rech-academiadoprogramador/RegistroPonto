using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.WinApp.ModuloTurma
{
    internal class Turma
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, {Periodo}, {Ano}";
        }
    }
}
