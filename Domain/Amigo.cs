using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Amigo
    {
        public int id { get; set; }

        [Required(ErrorMessage ="==Esse é obrigatorio==")]
        [StringLength(60,ErrorMessage = "Campo deve ter no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "==Esse é obrigatorio==")]
        [StringLength(60, ErrorMessage = "Campo deve ter no máximo 60 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "==Esse é obrigatorio==")]
        public DateTime DataNascimento { get; set; }
    }
}
