using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Facultades
    {
        [Key]
        public int facultad_id { get; set; }
        public String? nombre_facultad { get; set; }

    }
}
