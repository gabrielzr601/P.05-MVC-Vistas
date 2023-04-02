using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Tipo_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Descripción")]
        public String? descripcion { get; set; }
        [Display(Name = "Estado")]
        public String? estado { get; set; }

    }
}
