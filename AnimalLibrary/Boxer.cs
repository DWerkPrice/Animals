using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
   public class Boxer : Dog
    {
        public string MedDog { get; set; }

        public Boxer(string Name) : base(Name) {
            MedDog = "Medium";
            Muzzle = MuzzleType.Collapsed;
        }

        public override string GetTypeOfDog() {
            return "Boxer";
        }
        public Boxer() : this("Butch") {
        }
        
   }
}
