namespace Shapes.Shapes
{
    /// <summary>
    /// Circle.
    /// </summary>
    class Circle : Shape
    {

        /// <summary>
        /// Radius.
        /// </summary>
        internal float Radius { get; set; }

        /// <summary>
        /// Area.
        /// </summary>
        internal override float Area
        {
            get
            {
                return Constants.PI * Radius * Radius;
            }
        }
    }
}