using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Aluno
    {
        public int Id{ get; set; }
        public string Nome { get; set; }    
        [DisplayName("E-mail")]
        public string email { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

    }
}
