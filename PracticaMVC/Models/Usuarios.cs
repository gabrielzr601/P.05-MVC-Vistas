using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Usuarios
    {
        [Key]
        public int usuario_id { get; set; }
        public String? nombre { get; set; }
        public String? documento { get; set; }
        public String? tipo { get; set; }
        public String? carnet { get; set; }
        public int? carrera_id { get; set; }

    }
}
