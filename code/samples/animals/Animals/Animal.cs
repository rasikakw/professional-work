using System;
using System.Drawing;

namespace Animals
{
    /// <summary>
    /// Animal class.
    /// </summary>
    public class Animal
    {
        private int _privateField;

        protected int _speed;
        protected Color _colour;

        /// <summary>
        /// Animal constructor. 
        /// </summary>
        public Animal()
        {
            Console.WriteLine("Creating animal.");
            DisplayInfo();
            _speed = 5;
            _colour = Color.White;
            DisplayInfo();
            _privateField = 1;
            PrivateMethod();
            Console.WriteLine("Finished creating animal.");
        }

        /// <summary>
        /// Private method.
        /// </summary>
        private void PrivateMethod()
        {            
            Console.WriteLine("PrivateMethod: " + _privateField);
        }

        /// <summary>
        /// Protected method.
        /// </summary>
        protected void DisplayInfo()
        {
            Console.WriteLine("Speed: " + _speed + ", Color: " + _colour);
        }

        /// <summary>
        /// Move method.
        /// </summary>
        public virtual void Move()
        {
            Console.WriteLine("Animal moving at speed " + _speed);
        }
    }
}
