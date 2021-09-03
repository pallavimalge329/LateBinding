using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBinding
{

    class Animal
    {
        public virtual void FoodHabits()
        {
            Console.WriteLine("Animals have different food  habits");
        }
    }

    class Carnivorous : Animal
    {
        public override void FoodHabits()
        {
            base.FoodHabits();
            Console.WriteLine("Carnivorous eat only meat");
        }
    }
    class Implement
    {
        public void callFunction(Animal cr)
        {
            cr.FoodHabits();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Demo!");
            Implement im = new Implement();
            Carnivorous cr = new Carnivorous();
            // calling an object at runtime 
            im.callFunction(cr);
            Console.ReadKey();
        }
    }

}
