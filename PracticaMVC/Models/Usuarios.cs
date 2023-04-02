using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Usuarios
    {
        [Key]
        [Display(Name = "ID")]
        public int usuario_id { get; set; }
        [Display(Name = "Nombre de Usuario")]
        public String? nombre { get; set; }
        [Display(Name = "Documento")]
        public String? documento { get; set; }
        [Display(Name = "Tipo")]
        public String? tipo { get; set; }
        [Display(Name = "Carnet")]
        public String? carnet { get; set; }
        [Display(Name = "Id de Carrera")]
        public int? carrera_id { get; set; }

    }
}
