using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Estados_equipos
    {
        [Key]
        public int id_estados_equipo { get; set; }
        public String? descripcion { get; set; }
        public string? estado { get; set; }

    }
}
