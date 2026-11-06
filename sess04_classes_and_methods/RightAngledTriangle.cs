using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Create right angled triangles with base, height and hypotenuse.
    /// </summary>
    public class RightAngledTriangle
    {
        //Private instance variables
        private byte height;
        private byte @base;
        private byte hypotenuse;

        /// <summary>
        /// Initialises a new instance of the <see cref="RightAngledTriangle"/> class with all dimensions set to 0 'zero'.
        /// </summary>
        public RightAngledTriangle()
        {
            height = 0;
            @base = 0;
            hypotenuse = 0;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="RightAngledTriangle"/> class with all dimensions set to 0 'zero'.
        /// using the specified base and height.
        /// Calculates the hypotenuse using the Pythagorean theorem.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="base"></param>
        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)(Math.Sqrt(height * height + @base * @base));
            this.hypotenuse = (byte)(Math.Sqrt(Math.Pow(height,2) + Math.Pow(@base, 2)));
        }

        /// <summary>
        /// Calculates the area of the right-angled triangle.
        /// </summary>
        /// <returns></returns>
        private int CalculateArea() { return (int)(.5*this.@base * this.height); } //not same as 1/2 * this.@base * this.height
        private int CalculatePerimeter() { return this.@base + this.height + this.hypotenuse; }

        public override string ToString()
        {
               return $"Right-Angled Triangle's Dimensions" +
                $"\n{new string('-', 50)}" +
                $"\n Height: {this.height}" +
                $"\n Base: {this.@base}" +
                $"\n Hypotenuse: {this.hypotenuse}" +
                $"\n Area: {this.CalculateArea()}" +
                $"\n Perimeter: {this.CalculatePerimeter()}"+
                $"\n{new string('-', 50)}";
        }
    }
}
