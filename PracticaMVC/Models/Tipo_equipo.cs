using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Tipo_equipo
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        public String? descripcion { get; set; }
        public String? estado { get; set; }

    }
}
