using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int facultad_id { get; set; }
        [Display(Name = "Nombre de la Facultad")]
        public String? nombre_facultad { get; set; }

    }
}
