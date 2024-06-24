using System;

namespace Animals
{
    /// <summary>
    /// Program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();

            animal.Move();
            cat.Move();
            dog.Move();

            Animal animal2 = dog;
            animal2.Move();

            MoveAnimal(animal);
            MoveAnimal(cat);
            MoveAnimal(dog);

            Console.ReadLine();
        }

        private static void MoveAnimal(Animal animal)
        {
            animal.Move();
        }
    }
}
