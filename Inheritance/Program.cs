using System;
using System.ComponentModel;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var thisBird = new Bird("Cardinal", 0.25m, 3, 2, 6, false, true, 10);
            var thisReptile = new Reptile("Alligator", 150, 20, 4, 18, true, 15, true);

            Console.WriteLine("Animal List");
            Console.WriteLine(thisBird.SigLong());
            Console.WriteLine(thisReptile.SigLong());
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public decimal? Weight { get; set; }         //lbs
        public int? LifeExpectency { get; set; }
        public int? Legs { get; set; }

        public Animal() 
        {
        }

        public Animal(string nm, decimal? wt, int? life, int? lgs)
        {
            Name= nm;
            Weight= wt;
            LifeExpectency= life;
            Legs = lgs;
        }

        public string SigShort()
        {
            return $"{Name} @ {Weight}lbs with {Legs} legs";
        }
    }

    public class Bird : Animal
    {
        public int? AirSpeed { get; set; }       //mph
        public bool? DoesMigrate { get; set; }
        public bool? DoesFly { get; set; }
        public int? Range { get; set; }          //miles

        public Bird()
        {
        }

        public Bird(string nm, decimal? wt, int? life, int? lgs, int? speed, bool? migrates, bool? flies, int? rng)
        {
            Name= nm;
            Weight= wt;
            LifeExpectency= life;
            Legs= lgs;
            AirSpeed = speed;
            DoesMigrate = migrates;
            DoesFly = flies;
            Range= rng;
        }

        public string SigLong()
        {
            return $"{Name} @ {Weight}lbs with {Legs} legs, Migration:{DoesMigrate}, Flight Range:{Range} @ {AirSpeed}mph";
        }
    }

    public class Reptile : Animal
    {
        public int? LandSpeed { get; set; }         //mph
        public bool? DoesSwim { get; set; }
        public int? WaterSpeed { get; set; }        //mph
        public bool? BearsEggs { get; set; }


        public Reptile()
        {
        }

        public Reptile(string nm, decimal? wt, int? life, int? lgs, int? land, bool? swims, int? water, bool? eggs)
        {
            Name= nm;
            Weight = wt;
            LifeExpectency= life;
            Legs= lgs;
            LandSpeed= land;
            DoesSwim = swims;
            WaterSpeed= water;
            BearsEggs= eggs;
        }

        public string SigLong()
        {
            return $"{Name} @ {Weight}lbs with {Legs} legs, Speed:{LandSpeed}mph by land / {WaterSpeed}mph by water, Bears Eggs:{BearsEggs}";
        }
    }

}
