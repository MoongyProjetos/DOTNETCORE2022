using System;
using System.Text;
using Model;
using ModeloDoEndereco;

namespace ExemploNet6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cliente lais = new Cliente(); //63
            lais.Nome = "Laís Rosa"; //11 bits
            ///lais.Idade = 15; //32bit , 4bytes
            lais.Nif = "123456789"; //2bit 20bits
            lais.DataNascimento = new DateTime(2007, 01, 01);
            lais.ValorDesconto = 25.2M;
            Console.WriteLine("A Laís tem: " + lais.Idade + " anos");



            var endereco = new Endereco();
            lais.Endereco = endereco;


            Funcionario nuno = new Funcionario();
            nuno.Nome = "Nuno";
            nuno.Endereco = endereco;
            nuno.DataNascimento = new DateTime(2000, 12, 25);
            nuno.DataContratacao = new DateTime(2020, 12, 25);
            Console.WriteLine($"O Nuno tem {nuno.Idade} anos");


            endereco.Rua = "Rua Principal de Lisboa";


            var luiz = new Funcionario();            
            luiz.Nome = "Luiz";
            luiz.DataNascimento = new DateTime(1990, 05, 01);



            Console.WriteLine(String.Format("O {0} possui {1} anos", luiz.Nome, luiz.Idade));


            Cliente diego = new();





            Console.WriteLine(lais.Endereco.Rua);
            Console.WriteLine(nuno.Endereco.Rua);
            diego.Endereco = new Endereco();
            Console.WriteLine(diego.Endereco.Rua);



            Console.WriteLine(1 + 1); //Soma
            Console.WriteLine("1" + "1"); //Concatenar Strings
            Console.WriteLine(1 - 1); //Subtracao
            Console.WriteLine(1 / 10); //Divisao (cuidado com o zero)
            Console.WriteLine(1 * 100); //Multiplicacao
            Console.WriteLine(1 % 10); //Resto da Divisao





        }
    }
}
