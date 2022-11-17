using ExemploInterfaces.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterfaces.Classes
{
    public class Alunos : IOperacoes
    {
        public int NumeroAluno { get; set; }
        public string NomeDoAluno { get; set; }

        public void Exemplo()
        {
            throw new NotImplementedException();
        }

        public void Recuperar()
        {
            var path = @"e:\temp\dadosAlunos.txt";
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
        }

        public void Salvar()
        {
            var Dados = $"Numero: {NumeroAluno} - Nome: {NomeDoAluno}";
            File.WriteAllText(@"e:\temp\dadosAlunos.txt", Dados);
        }
    }
}
