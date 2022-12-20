using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Projeto.DataModel
{
    
    public class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(0, int.MaxValue)]
        public int Id { get; }


        [MaxLength(200)]
        [MinLength(3)]
        [JsonPropertyName("NameOfUser")]
        public string? Nome { get; set; }


        [AtributoCustomizado(1, "jonatas@email.com")]
        public string? Detalhes { get; set; }


        
        public Sexo Sexo { get; set; }




        [Obsolete(message:"Please choose another method...")]
        public string GetNome(int id)
        {
            return Nome;
        }
    }
}
