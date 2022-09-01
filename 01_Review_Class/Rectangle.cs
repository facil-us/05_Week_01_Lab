using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Review_Class
{
    public class Rectangle
    {
        // create properties (without fields)
        public decimal Length { get; set; }
        public decimal Width { get; set; }

        // create contruction
        public Rectangle(decimal _Length, decimal _Width)
        {
            Length = _Length;
            Width = _Width;
        }

        // create a perim method
        public decimal Perim()
        {
            return 2 * (Length + Width);
        }

        // create a area method
        public decimal Area()
        {
            return Length * Width;
        }

        // create a override string method
        public override string ToString()
        {
            return $"Rectangle: Length {Length}, Width {Width}";
        }
    }
}
