using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

    internal class Program
    {
        class Animal
        {
            public string NameAnimal;
            public string food;
            public string location;
            public string setFood()
            {
                return food;
            }

            public Animal(string NameAnimal, string food, string location)
            {
                this.NameAnimal = NameAnimal;
                this.food = food;
                this.location = location;
            }
            public void eat()
            {
                Console.WriteLine("ест ");
            }
            public void makeNoise()
            {
                Console.WriteLine("шумит");
            }
            public void sleep()
            {

                Console.WriteLine("Животное спит");
            }
        }
        class Dog : Animal
        {
            public string NameAnimal;

            public Dog(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} гавкает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит ");
            }
        }

        class Cat : Animal
        {
            public string NameAnimal;

            public Cat(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} мяукает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит ");
            }
        }

        class Hourse : Animal
        {
            public string NameAnimal;

            public Hourse(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} цокает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит ");
            }
        }

        class Veterenar
        {

            public void treatAnimal(Animal animal)
            {
                Console.WriteLine("еда :" + animal.food);
                Console.WriteLine("Живет в: " + animal.location);
                Console.WriteLine(animal.NameAnimal + " на приеме у Ветеринара\n");
            }
        }
        static void Main(string[] args)
        {
            Veterenar veterenar = new Veterenar();

            Dog dog = new Dog("Бобик", "мясо", "будке");
            Cat cat = new Cat("Том", "мясо и молоко", "доме");
            Hourse hourse = new Hourse("Стрела", "сено и яблоки", "конюшне");

            veterenar.treatAnimal(dog);
            veterenar.treatAnimal(cat);
            veterenar.treatAnimal(hourse);

            Console.ReadLine();

      
    }
    }

