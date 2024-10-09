using System.ComponentModel.DataAnnotations;

namespace Calculate.Models
{
    public class CalculateModel
    {
        [Required]
        public double Number1 { get; set; }
        [Required]
        public double Number2 { get; set; }
        public double Result { get; set; }
    }
}
