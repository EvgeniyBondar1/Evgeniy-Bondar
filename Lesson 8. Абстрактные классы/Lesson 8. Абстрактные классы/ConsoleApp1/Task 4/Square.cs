using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Square : Figure
    {
        public double Length { get; set; }
        public Square(uint length) 
        {
            this.Length = length;
        }
        public override double P() => 4 * Length;
        public override double S() => 2 * Length;

    }
}
