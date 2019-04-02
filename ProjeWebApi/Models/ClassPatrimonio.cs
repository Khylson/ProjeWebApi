using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeWebApi.Models
{
    public class ClassPatrimonio
    {
        [Required(ErrorMessage = "Campo Obridatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obridatório")]
        public int MarcaId { get; set; }
        public string Descricao { get; set; }
        public int N_Tombo { get; set; }
    }
}