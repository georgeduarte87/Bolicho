using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bolicho.Models
{

    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório.")]
        public string Sobrenome { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }

    }
}
