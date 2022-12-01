using System.ComponentModel.DataAnnotations;

namespace LojaApi.Models{

    public class Pipoca{

        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(5, ErrorMessage = "O nome deve ter, pelo menos, 5 caracteres")]
        public String Nome {get; set;}

        public String Departamento {get; set;}

        public String Apelido {get; set;}


        public DateTime DataCadastro {get; set;}


    }
}