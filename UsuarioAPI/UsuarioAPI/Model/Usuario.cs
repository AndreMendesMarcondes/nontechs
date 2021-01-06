using System;
using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
