using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Rectangle : Figure
    {
        public uint Length { get; set; }
        public uint Width { get; set; }
        public Rectangle(uint lentgh, uint width)
        {
            this.Length = lentgh;
            this.Width = width;
        }
        public override double P() => 2 * (Length + Width);
        public override double S() => Length * Width;
    }
}
