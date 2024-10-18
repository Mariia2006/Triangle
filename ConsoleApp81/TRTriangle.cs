using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    public class TRTriangle
    {
        private double a;
        private double b;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value > 0 ? value : throw new ArgumentException("The leg must be greater than 0");
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value > 0 ? value : throw new ArgumentException("The leg must be greater than 0");
            }
        }

        public TRTriangle()
        {
            a = 3;
            b = 4;
        }

        public TRTriangle(double a, double b)
        {
            A = a;
            B = b;
        }

        // конструктор копіювання
        public TRTriangle(TRTriangle other)
        {
            A = other.A;
            B = other.B;
        }

        public override string ToString()
        {
            return $"Right triangle: leg A = {A}, leg B = {B}";
        }

        public void Input()
        {
            Console.Write("Enter leg A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Enter leg B: ");
            B = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public double GetArea()
        {
            return 0.5 * A * B;
        }

        public double GetPerimeter()
        {
            double с = Math.Sqrt(A * A + B * B);
            return A + B + с;
        }

        // перевантаження оператора порівняння
        public static bool operator ==(TRTriangle t1, TRTriangle t2)
        {
            if (ReferenceEquals(t1, null) || ReferenceEquals(t2, null))
                return false;
            return (t1.A == t2.A && t1.B == t2.B) || (t1.A == t2.B && t1.B == t2.A);
        }

        // перевантаження оператора порівняння
        public static bool operator !=(TRTriangle t1, TRTriangle t2)
        {
            return !(t1 == t2);
        }

        // трикутник * число
        public static TRTriangle operator *(TRTriangle t, double multiplier)
        {
            return new TRTriangle(t.A * multiplier, t.B * multiplier);
        }

        // число * трикутник
        public static TRTriangle operator *(double multiplier, TRTriangle t)
        {
            return t * multiplier;
        }

        // перевизначення Equals та GetHashCode для коректної роботи операторів == та !=
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            TRTriangle t = (TRTriangle)obj;
            return A == t.A && B == t.B;
        }

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode();
        }
    }
}
