namespace Shapes.Shapes
{
    /// <summary>
    /// Shape.
    /// </summary>
    abstract class Shape
    {
        /// <summary>
        /// Point 1 X.
        /// </summary>
        internal float Point1X { get; set; }

        /// <summary>
        /// Point 1 Y.
        /// </summary>
        internal float Point1Y { get; set; }

        /// <summary>
        /// Area.
        /// </summary>
        internal abstract float Area { get; }
    }
}