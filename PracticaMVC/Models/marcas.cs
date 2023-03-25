using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }
        [Display(Name = "Nombre de la Marca")]
        public String? nombre_marca { get; set; }
        [Display(Name = "Estado")]
        public String? estados { get; set; }


    }
}
