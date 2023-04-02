using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    public class Estados_reserva
    {
        [Key]
        [Display(Name = "ID")]
        public int estado_res_id { get; set; }
        [Display(Name = "Estado")]
        public String? estado { get; set; }
    }
}
