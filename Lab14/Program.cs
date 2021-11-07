using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Showinfo();
            dog.Showinfo();
            Console.ReadKey();
        }

        abstract class Animal
        {
            public abstract string Name { get; set; }

            public Animal()
            {
                Name = "Животное";
            }
            

            public abstract void Say();
            public void Showinfo()
            {
                Console.Write(Name);
                Say();
            }
        }

        class Cat : Animal
        {
            string name;

            public override string Name
            {   
                get
                {
                    return name;
                }
                set
                {
                    name = "Кошка";
                }
            }

            public override void Say()
            {
                Console.WriteLine(" Мяу");
            }
        }

        class Dog : Animal
        {
            string name;

            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Собака";
                }
            }

            public override void Say()
            {
                Console.WriteLine(" Гав");
            }
        }
    }
}
