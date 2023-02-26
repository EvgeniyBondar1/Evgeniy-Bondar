using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Square : Rectangle
    {
        public double length { get; set; }
        public Square() : this(1) { }
        public Square(uint length) : base(length, length)
        {

        }
        public override double P() => 4 * Length;
        public override double S() => 2 * Length;

    }
}
