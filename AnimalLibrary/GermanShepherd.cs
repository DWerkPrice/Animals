using System;  //everything dog will do, germanshepherd will do and more because of ": Dog"
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class GermanShepherd : Dog {

        public bool BigDog { get; set; }

        public GermanShepherd(string Name) : base(Name) {
            this.LongTail = true;
            this.BigDog = true;
        }


        public GermanShepherd() {
            this.Muzzle = MuzzleType.Long;
        }
        /*   public new string GetTypeOfDog() {
               return "German Shepherd";
           } 
        */
        public override string GetTypeOfDog() {
            return "German Shepherd";
        }
    }
}
