using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Singleton
{
    internal class Animal
    {
        static protected Animal instance=null;

        protected  Animal()
        {
            Console.WriteLine("Animal ctor");

        }

        public static Animal GetInstance()
        {
            return instance;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog:Animal 
    {
        protected Dog()
        {
            Console.WriteLine( "Dog ctor");
        }
        public static Animal GetInstance()
        {
            if( instance == null)
            {
                instance = new Dog();
            }
            return instance;
        }
        public sealed override void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class SpecialDog:Dog
    {
        // cannot override inherited member 'Dog.Eat()' because it is sealed 
        //public override void Eat()
        //{
        //    Console.WriteLine("Animal is eating");
        //}
    }


    class Cat : Animal
    {
        protected Cat()
        {
            Console.WriteLine("Cat ctor");
        }
        public static Animal GetInstance()
        {
            if (instance == null)
            {
                instance = new Cat();
            }
            return instance;
        }
    }
}
