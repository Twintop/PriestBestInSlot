using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SimulationCraftBlowtorchImport
{
    public class ProfileValues
    {
        public string ProfileName { get; set; }
        public string ScaleDirection { get; set; }
        public string FightType { get; set; } //Patchwerk, LightMove, HeavyMove, HelterSkelter
        public string FightSubType { get; set; } //None, 1 Add, 3 Adds
        public int MainTargetCount { get; set; }
        public string Level45 { get; set; }
        public string Level75 { get; set; }
        public string Level90 { get; set; }
        public string Level100 { get; set; }
        public double Intellect { get; set; }
        public double SpellPower { get; set; }
        public double Crit { get; set; }
        public double Haste { get; set; }
        public double Mastery { get; set; }
        public double Multistrike { get; set; }
        public double Versatility { get; set; }
        public double RunSpeed { get; set; }
        public int DPS { get; set; }
        public bool No4P { get; set; }
        public bool No2P { get; set; }
        public bool NoLegendaryRing { get; set; }
    }
}
