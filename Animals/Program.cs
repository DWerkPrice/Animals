using System;
using System.Collections.Generic;
using AnimalLibrary;

class Animals //changed from program.cs to name 
{
    static void Main(string[] args) {
        // var germanSheperd = new AnimalLibrary.Dog(); would need this if you did not put in a using AnimalLibrary; above
       
        var gs1 = new GermanShepherd("Killer");
    
        var germanShepherd = new GermanShepherd {
            LongTail = true ,
            BarkPitch = BarkPitchType.Low ,
            Muzzle = MuzzleType.Long ,
            ExtremeSenseOfSmell = true ,
            BigDog = true ,  // if you want default can leave this out
            Name = "Fred"
        };

        var boxer1 = new Boxer("Gretchen");

        var pug2 = new Pug("Pudgy");

        var pug = new Dog {
            LongTail = true ,
            BarkPitch = BarkPitchType.Low ,
            Muzzle = MuzzleType.Long ,
            ExtremeSenseOfSmell = false,
            Name = "Alfred"
        };
        var pug1 = new Dog {
            LongTail = false ,
            BarkPitch = BarkPitchType.High ,
            Muzzle = MuzzleType.Collapsed ,
            ExtremeSenseOfSmell = false,
            Name = "Ralph"
        };
        var dogs = new List<Dog>();
        dogs.Add(pug1);
        dogs.Add(pug2);
        dogs.Add(germanShepherd);
        dogs.Add(boxer1);
        dogs.Add(pug);
        dogs.Add(gs1);
        foreach(var dog in dogs) {
            Console.WriteLine(dog.GetTypeOfDog());
        }
    }
}