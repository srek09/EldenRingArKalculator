using EldenRingArKalculator.Models;
using System.Linq;
namespace EldenRingArKalculator.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                if (!context.Weapons.Any())
                {
                    List<Weapon> weapons = new();
                    using (var sr = new StreamReader("seed.csv"))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(',');
                            string name = line[0];
                            line = line.Skip(1).ToArray();
                            double[] scale = Array.ConvertAll(line, a => double.Parse(a));
                            using (var sr2 = new StreamReader("seed2.csv"))
                            {
                                string[] line2 = sr.ReadLine().Split(',');
                                line = line.Skip(1).ToArray();
                                double[] attac = Array.ConvertAll(line2, a => double.Parse(a));

                                Weapon newWeapon = new Weapon()
                                {
                                    Name = name,
                                    StrScaling = new Scaling() {
                                        Lvl1 = scale[0],
                                        Lvl1 = scale[5],
                                        Lvl1 = scale[10],
                                        Lvl1 = scale[15],
                                        Lvl1 = scale[20],
                                        Lvl1 = scale[25],
                                        Lvl1 = scale[30],
                                        Lvl1 = scale[35],
                                        Lvl1 = scale[40],
                                        Lvl1 = scale[45],
                                        Lvl10 = scale[50],
                                        Lvl11 = scale[55],
                                        Lvl12 = scale[60],
                                        Lvl13 = scale[65],
                                        Lvl14 = scale[70],
                                        Lvl15 = scale[75],
                                        Lvl16 = scale[80],
                                        Lvl17 = scale[85],
                                        Lvl18 = scale[90],
                                        Lvl19 = scale[95],
                                        Lvl10 = scale[100],
                                        Lvl11 = scale[105],
                                        Lvl12 = scale[110],
                                        Lvl13 = scale[115],
                                        Lvl14 = scale[120],
                                        Lvl15 = scale[125],
                                    },
                                    DexScaling = new Scaling() {
                                        Lvl0 = scale[1],
                                        Lvl1 = scale[6],
                                        Lvl2 = scale[11],
                                        Lvl3 = scale[16],
                                        Lvl4 = scale[21],
                                        Lvl5 = scale[26],
                                        Lvl6 = scale[31],
                                        Lvl7 = scale[36],
                                        Lvl8 = scale[41],
                                        Lvl9 = scale[46],
                                        Lvl10 = scale[51],
                                        Lvl11 = scale[56],
                                        Lvl12 = scale[61],
                                        Lvl13 = scale[66],
                                        Lvl14 = scale[71],
                                        Lvl15 = scale[76],
                                        Lvl16 = scale[81],
                                        Lvl17 = scale[86],
                                        Lvl18 = scale[91],
                                        Lvl19 = scale[96],
                                        Lvl20 = scale[101],
                                        Lvl21 = scale[106],
                                        Lvl22 = scale[111],
                                        Lvl23 = scale[116],
                                        Lvl24 = scale[121],
                                        Lvl25 = scale[126],
                                    },
                                    IntScaling = new Scaling() {
                                        Lvl0 = scale[2],
                                        Lvl1 = scale[7],
                                        Lvl2 = scale[12],
                                        Lvl3 = scale[17],
                                        Lvl4 = scale[22],
                                        Lvl5 = scale[27],
                                        Lvl6 = scale[32],
                                        Lvl7 = scale[37],
                                        Lvl8 = scale[42],
                                        Lvl9 = scale[47],
                                        Lvl10 = scale[52],
                                        Lvl11 = scale[57],
                                        Lvl12 = scale[62],
                                        Lvl13 = scale[67],
                                        Lvl14 = scale[72],
                                        Lvl15 = scale[77],
                                        Lvl16 = scale[82],
                                        Lvl17 = scale[87],
                                        Lvl18 = scale[92],
                                        Lvl19 = scale[97],
                                        Lvl20 = scale[102],
                                        Lvl21 = scale[107],
                                        Lvl22 = scale[112],
                                        Lvl23 = scale[117],
                                        Lvl24 = scale[122],
                                        Lvl25 = scale[127],
                                    },
                                    FaiScaling = new Scaling() {
                                        Lvl0 = scale[3],
                                        Lvl1 = scale[8],
                                        Lvl2 = scale[13],
                                        Lvl3 = scale[18],
                                        Lvl4 = scale[23],
                                        Lvl5 = scale[28],
                                        Lvl6 = scale[33],
                                        Lvl7 = scale[38],
                                        Lvl8 = scale[43],
                                        Lvl9 = scale[48],
                                        Lvl10 = scale[53],
                                        Lvl11 = scale[58],
                                        Lvl12 = scale[63],
                                        Lvl13 = scale[68],
                                        Lvl14 = scale[73],
                                        Lvl15 = scale[78],
                                        Lvl16 = scale[83],
                                        Lvl17 = scale[88],
                                        Lvl18 = scale[93],
                                        Lvl19 = scale[98],
                                        Lvl20 = scale[103],
                                        Lvl21 = scale[108],
                                        Lvl22 = scale[113],
                                        Lvl23 = scale[118],
                                        Lvl24 = scale[123],
                                        Lvl25 = scale[128],
                                    },
                                    ArcScaling = new Scaling() {
                                        Lvl0 = scale[4],
                                        Lvl1 = scale[9],
                                        Lvl2 = scale[14],
                                        Lvl3 = scale[19],
                                        Lvl4 = scale[24],
                                        Lvl5 = scale[29],
                                        Lvl6 = scale[34],
                                        Lvl7 = scale[39],
                                        Lvl8 = scale[44],
                                        Lvl9 = scale[49],
                                        Lvl10 = scale[54],
                                        Lvl11 = scale[59],
                                        Lvl12 = scale[64],
                                        Lvl13 = scale[69],
                                        Lvl14 = scale[74],
                                        Lvl15 = scale[79],
                                        Lvl16 = scale[84],
                                        Lvl17 = scale[89],
                                        Lvl18 = scale[94],
                                        Lvl19 = scale[99],
                                        Lvl20 = scale[104],
                                        Lvl21 = scale[109],
                                        Lvl22 = scale[114],
                                        Lvl23 = scale[119],
                                        Lvl24 = scale[124],
                                        Lvl25 = scale[129],
                                    },
                                    PhysAttack = new List<double>{  },
                                    MagiAttack = new List<double> {  },
                                    FireAttack = new List<double> {  },
                                    LighAttack = new List<double> {  },
                                    HolyAttack = new List<double> {  }
                                };
                            }
                        }
                    }
                    context.Weapons.AddRange(weapons);
                    context.SaveChanges();
                }
            }
        }
    }
}
