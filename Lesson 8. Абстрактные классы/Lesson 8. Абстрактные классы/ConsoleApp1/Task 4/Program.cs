namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Задача 4. написать Иерархию классов фигуры
            /// </summary>

            Figure[] figures = { new Triangle(5, 6, 7), new Square(3), new Rectangle(33, 45) };
            var resultPerimetrTriangle =  figures[0].P();
            var resultPerimetrSquare = figures[1].P();
            var resultPerimetrRectangle = figures[2].P();

            Console.WriteLine($" Периметр треугольника: {resultPerimetrTriangle}\n Периметр квадрата {resultPerimetrSquare}\n Периметр прямоугольника {resultPerimetrRectangle}");

            Console.ReadKey();
        }
    }
}