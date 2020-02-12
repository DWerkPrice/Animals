using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
        public class Pug : Dog {

           public bool SmallDog { get; set; }

           public Pug(string Name) : base(Name) {
                SmallDog = true;
                Muzzle = MuzzleType.Collapsed;
            }
        public override string GetTypeOfDog() {
            return "Pug";
        }

            public Pug() :this("Spot") {
            }
            
        }

 }
