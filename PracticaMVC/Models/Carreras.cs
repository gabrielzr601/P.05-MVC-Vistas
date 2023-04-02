using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Carreras
    {
        [Key]
        public int carrera_id { get; set; }
        public String? nombre_carrera { get; set; }

        public int? facultad_id { get; set; }

    }
}
