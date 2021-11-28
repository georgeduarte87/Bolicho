using System;
using System.ComponentModel.DataAnnotations;

namespace Bolicho.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome Precisa Ter Entre 3 e 100 Caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição é Obrigatória.")]
        [Display(Name = "Descrição")]
        [StringLength(1000, MinimumLength = 100, ErrorMessage = "A Descrição Precisa Ter Entre 100 e 1000 Caracteres.")]
        public string Descicao { get; set; }

        [Required(ErrorMessage ="Valor é obrigatório.")]
        //[Column(TypeName = "decimal(18,2")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório.")]
        public int Estoque { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }

        [Required]
        public DateTime DataAtualizacao { get; set; }

    }
}
