using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// (FINISH SUMMARRY WHEN POSSIBLE)
    /// Represents a rectangle.
    /// Provides methds to...
    /// calculate its area, perimiter,length and width
    /// </summary>
    /// <returns>The perimeter, calculated as twice the sum of the length and width.</returns>
    public class Rect
    {
        private uint length;
        private uint width;

        //Constructors
        public Rect()
        {
            length = 0;
            width = 0;
        }
        public Rect(uint length, uint width)
        {
            this.length = length;
            this.width = width;
        }

        public void SetLength(uint length)
        {
            this.length = length;
        }
        public uint GetLength()
        {
            return this.length;
        }
        public void SetWidth (uint width)
        {
            this.width = width;
        }
        public uint GetWidth()
        {
            return this.width;
        }
        public ulong CalcArea()
        {
            return this.length * this.width;
        }
        /// <summary>
        /// Returns a formatted string containing the rectangle's dimensions,
        /// area and perimeter.
        /// </summary>
        /// <returns>The perimeter, calculated as twice the sum of the length and width.</returns>
        public ulong CalcPerimeter()
        {
            return 2 * (this.length + this.width);
        }

        /// <summary>
        /// Returns a formatted string containing the rectangle's dimensions,
        /// area and perimeter.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Rectangle's Dimensions" +
                "\n" + new string('-', 50) +
                $"Length: {this.GetLength()}" +
                $"Width: {this.GetWidth()}" +
                $"Area: {this.CalcArea()}" +
                $"Perimeter: {this.CalcPerimeter()}" +
                $"\n" + new string('-', 50);
            ;

        }
    }
}
