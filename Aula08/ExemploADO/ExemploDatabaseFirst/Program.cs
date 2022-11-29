using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CriarNovoAluno();
            //ListarTodosOsAlunos();
            //ListarTodosOsAlunosComecandoComJEmOrdemDecrescente();
            //AtualizarDadosDeAlunoEspecifico();
            //RemoverInvasoresDoDatabase();

            Console.ReadLine();
        }

        private static void RemoverInvasoresDoDatabase()
        {
            var contexto = new EscolaDBConnection();
            var alunosIncompletos = contexto.Alunos.Where(x => x.Nome.StartsWith("Invasor")).ToList();


            foreach (var item in alunosIncompletos)
            {
                contexto.Alunos.Remove(item);
            }

            contexto.SaveChanges();
        }

        private static void AtualizarDadosDeAlunoEspecifico()
        {
            var contexto = new EscolaDBConnection();
            var aluno = contexto.Alunos.FirstOrDefault(x => x.Id == 1);
            aluno.Nome = "Jônatas Afonso";
            aluno.DataNascimento = new DateTime(1984, 05, 29);
            aluno.NomePai = "Pai do Jônatas";

            contexto.SaveChanges();
        }

        private static void ListarTodosOsAlunosComecandoComJEmOrdemDecrescente()
        {
            var contexto = new EscolaDBConnection();
            var listagemAlunos = contexto.Alunos
                .Where(x => x.Nome.StartsWith("J"))
                .OrderByDescending(x => x.Nome)
                .ToList();

            foreach (var item in listagemAlunos)
            {
                Console.WriteLine(item.Nome);
            }
        }

        private static void ListarTodosOsAlunos()
        {
            var contexto = new EscolaDBConnection();
            var listagemAlunos = contexto.Alunos.ToList();

            foreach (var item in listagemAlunos)
            {
                Console.WriteLine(item.Nome);
            }
        }

        private static void CriarNovoAluno()
        {
            var alunoNovo = new Alunos
            {
                Nome = "Mateus",
                DataNascimento = new DateTime(2000, 02, 03),
                NomePai = "José da Silva"
            };


            var contexto = new EscolaDBConnection();
            contexto.Alunos.Add(alunoNovo);
            contexto.SaveChanges();
        }
    }
}
