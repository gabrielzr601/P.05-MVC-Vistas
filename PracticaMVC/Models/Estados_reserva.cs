using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    public class Estados_reserva
    {
        [Key]
        public int estado_res_id { get; set; }
        public String? estado { get; set; }
    }
}
