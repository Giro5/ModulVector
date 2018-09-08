using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            Vector v2 = new Vector();
            Console.Write("Введите координату х первого вектора: ");
            v1.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y первого вектора: ");
            v1.y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату х второго вектора: ");
            v2.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y второго вектора: ");
            v2.y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент для умножения: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Введенные векторы: \n{v1.Print(v1)}\n{v2.Print(v2)}");
            Console.WriteLine($"Сложение двух векторов равно: {v1.Print(v1.Sum(v1, v2))}");
            Console.WriteLine($"Вычитание двух векторов равно: {v1.Print(v1.Subtract(v1, v2))}");
            Console.WriteLine($"Скалярное умножение двух векторов равно: {v1.ScalarMultipication(v1, v2)}");
            Console.WriteLine($"Умножение векторов на число равно: {v1.Print(v1.MultipicationByAFactor(v1, k))}, {v2.Print(v2.MultipicationByAFactor(v2, k))}");
            Console.WriteLine($"Длины векторов равны: {v1.Abs(v1)}, {v2.Abs(v2)}");
            Console.ReadKey();
        }
    }
    class Vector
    {
        public double x, y;
        public Vector Sum(Vector a, Vector b) => new Vector { x = a.x + b.x, y = a.y + b.y };
        public Vector Subtract(Vector a, Vector b) => new Vector { x = a.x - b.x, y = a.y - b.y };
        public Double ScalarMultipication(Vector a, Vector b) => a.x * b.x + a.y * b.y;
        public Vector MultipicationByAFactor(Vector a, double k) => new Vector { x = k * a.x, y = k * a.y };
        public Double Abs(Vector a) => Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2));
        public String Print(Vector a) => $"({a.x}; {a.y})";
    }
}
