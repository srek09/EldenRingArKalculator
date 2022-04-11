using System.ComponentModel.DataAnnotations;

namespace EldenRingArKalculator.Models
{
    public class Scaling
    {
        [Key]
        public string WeaponName { get; set; }
        public double Arc25 { get; set; }
    }
}
