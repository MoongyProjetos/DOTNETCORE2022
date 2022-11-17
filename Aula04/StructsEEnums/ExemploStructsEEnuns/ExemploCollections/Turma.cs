using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCollections
{
    public class Turma
    {
        public Aluno[] AlunosArray { get; set; } //Array, criado uma vez tamanho pré-definido
        public List<Aluno> AlunosList { get; set; } 

        public Stack<Aluno> AlunoStack { get; set; }//A última é localizada mais rapidamente (FILO) -- pilha de pratos

        public Queue<Aluno> AlunoFila { get; set; } //O primeiro a entrar é o primeiro a ser atendido (FIFO) -- Fila do banco

        public Dictionary<int, string> DicionarioDeAlunos { get; set; }



    }
}
