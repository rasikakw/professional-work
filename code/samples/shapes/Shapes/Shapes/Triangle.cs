using System;

namespace Shapes.Shapes
{
    /// <summary>
    /// Triangle.
    /// </summary>
    class Triangle : Shape
    {
        /// <summary>
        /// Point 2 X.
        /// </summary>
        internal float Point2X { get; set; }
        
        /// <summary>
        /// Point 2 Y.
        /// </summary>
        internal float Point2Y { get; set; }

        /// <summary>
        /// Point 3 X.
        /// </summary>
        internal float Point3X { get; set; }

        /// <summary>
        /// Point 3 Y.
        /// </summary>
        internal float Point3Y { get; set; }

        /// <summary>
        /// Area.
        /// </summary>
        internal override float Area
        {
            get
            {
                float baseLen = Math.Abs(Point2X - Point3X);
                float height = Math.Abs(Point2Y - Point1Y);
                return baseLen * height / 2;
            }
        }
    }
}