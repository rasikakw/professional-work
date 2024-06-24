using System;
using System.Drawing;

namespace Animals
{
    /// <summary>
    /// Dog class.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Dog constructor. 
        /// </summary>
        public Dog()
        {
            Console.WriteLine("Creating dog.");
            DisplayInfo();
            _speed = 7;
            _colour = Color.Black;
            DisplayInfo();
            //_privateField = 3;
            //PrivateMethod();
            Console.WriteLine("Finished creating dog.");
        }

        /// <summary>
        /// Move method.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Dog moving at speed " + _speed);
        }
    }
}
