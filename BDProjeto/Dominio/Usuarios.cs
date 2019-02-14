using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjeto.Dominio
{
    public class Usuarios
    {
        public int Id { get; set; }
        //Mostra o nome do campo que deve ser preenchido
        [DisplayName("Nome")]
        [Required(ErrorMessage ="Preencha o campo usuário")]

        public string Nome { get; set; }

        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Preencha o campo cargo")]

        public string Cargo { get; set; }

        [DisplayName("Data de cadastro")]
        [Required(ErrorMessage = "Preencha o campo data")]
        //A forma que vai ser passada o campo data
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]

        public DateTime Data { get; set; }

    }
}
