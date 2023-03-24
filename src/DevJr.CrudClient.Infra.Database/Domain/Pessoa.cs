using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevJr.CrudClient.Infra.Database.Domain
{
    public class Pessoa
    { 
        public string DescSexo()
        {
            if (this.Sexo == "m")
                return "Masculino";
            else
                return "Feminino";
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o CPF!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Digite a DATA DE NASCIMENTO!")]
        public DateTime DtNascimento { get ; set; }



        [Required(ErrorMessage = "Digite o NOME!")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione o SEXO!")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Digite o ENDEREÇO!")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do endereço são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Selecione o ESTADO!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Selecione a CIDADE!")]
        public string Cidade { get; set; }

    }
}
