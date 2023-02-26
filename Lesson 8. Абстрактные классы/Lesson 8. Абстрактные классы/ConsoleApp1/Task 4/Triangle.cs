using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Triangle : Figure
    {
        public uint LengthSideA { get; set; }
        public uint LengthSideB { get; set; }
        public uint LengthSideC { get; set; }
        public Triangle(uint lengthSideA, uint lengthSideB, uint lengthSideC)
        {
            this.LengthSideA = lengthSideA;
            this.LengthSideB = lengthSideB;
            this.LengthSideC = lengthSideC;
        }

        public override double S()
        {
            double p = P() / 2;
            return Math.Sqrt(p * (p - LengthSideA) * (p - LengthSideB) * (p - LengthSideC));
        }

        public override double P() 
        { 
            return LengthSideA + LengthSideB + LengthSideC;
        } 
    }
}
