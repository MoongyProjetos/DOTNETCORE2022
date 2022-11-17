using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStructsEEnums.Model.Classes
{
    public class PessoaSingular : Pessoa
    {

		public DateTime DataNascimento { get; set; }
        public string? NIF { get; set; }

		/// <summary>
		/// 123.456.789
		/// </summary>

		private string? numeroDoContribuinte;
		public string? NumeroDoContribuinte
		{
			get { return numeroDoContribuinte; }
			set { numeroDoContribuinte = value.Replace(".", ""); }
		}


		public string CodigoCliente { get; init; }


		public PessoaSingular()
		{
			//TODO: modificar isso aqui
			//HACK: Gambiarra Temporária		
		}


		public PessoaSingular(string codigo)
		{
			CodigoCliente = codigo;
		}

		public PessoaSingular(string CodigoCliente, string Nif)
		{
			this.CodigoCliente = CodigoCliente;


			//Caso queira acessar propriedade classe MAE
			//super - Java/JavaScript
			//self - Python
			//base - C# 
		}


		public int IdadeCliente => DateTime.Now.Year - this.DataNascimento.Year; //this mantido só para exemplo, mas não é obrigatório


	}
}
