using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Carreras
    {
        [Key]
        [Display(Name = "ID")]
        public int carrera_id { get; set; }
        [Display(Name = "Nombre de Carrera")]
        public String? nombre_carrera { get; set; }
        [Display(Name = "Id de Facultad")]
        public int? facultad_id { get; set; }

    }
}
