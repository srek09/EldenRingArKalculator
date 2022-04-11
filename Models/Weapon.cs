using System.ComponentModel.DataAnnotations;

namespace EldenRingArKalculator.Models
{
    public class Weapon
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public Scaling StrScaling { get; set; }
        public Scaling DexScaling { get; set; }
        public Scaling IntScaling { get; set; }
        public Scaling FaiScaling { get; set; }
        public Scaling ArcScaling { get; set; }
        public Attack  PhysAttack { get; set; }
        public Attack  MagiAttack { get; set; }
        public Attack  FireAttack { get; set; }
        public Attack  LighAttack { get; set; }
        public Attack  HolyAttack { get; set; }
    }
}