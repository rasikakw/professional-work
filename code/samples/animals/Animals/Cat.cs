using System;
using System.Drawing;

namespace Animals
{
    /// <summary>
    /// Cat class.
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Cat constructor. 
        /// </summary>
        public Cat()
        {
            Console.WriteLine("Creating cat.");
            DisplayInfo();
            _speed = 6;
            _colour = Color.Gray;
            DisplayInfo();
            //_privateField = 2;
            //PrivateMethod();
            Console.WriteLine("Finished creating cat.");
        }
    }
}
