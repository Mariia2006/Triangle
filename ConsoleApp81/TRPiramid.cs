using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    public class TRPiramid : TRTriangle
    {
        private double height;

        // властивість
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value > 0 ? value : throw new ArgumentException("Height must be greater than 0");
            }
        }

        public TRPiramid() : base()
        {
            height = 8;
        }

        public TRPiramid(double a, double b, double height) : base(a, b)
        {
            Height = height;
        }

        public TRPiramid(TRPiramid other) : base(other)
        {
            Height = other.Height;
        }

        // об'єм піраміди
        public double GetVolume()
        {
            double baseArea = GetArea();
            return (1.0 / 3) * baseArea * Height;
        }

        public override string ToString()
        {
            return base.ToString() + $", Height of piramid H = {Height}";
        }

        public new void Input()
        {
            base.Input(); // виклик методу введення катетів із батьківського класу
            Console.Write("Enter the height of the pyramid: ");
            Height = double.Parse(Console.ReadLine());
        }

        public new void Output()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"Volume of the pyramid: {GetVolume()}");
        }
        public static bool operator ==(TRPiramid p1, TRPiramid p2)
        {
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;
            return (p1.A == p2.A && p1.B == p2.B && p1.Height == p2.Height) ||
                   (p1.A == p2.B && p1.B == p2.A && p1.Height == p2.Height);
        }
        public static bool operator !=(TRPiramid p1, TRPiramid p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            TRPiramid p = (TRPiramid)obj;
            return A == p.A && B == p.B && Height == p.Height;
        }
        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ Height.GetHashCode();
        }
        public static TRPiramid operator *(TRPiramid p, double multiplier)
        {
            return new TRPiramid(p.A * multiplier, p.B * multiplier, p.Height * multiplier);
        }
        public static TRPiramid operator *(double multiplier, TRPiramid p)
        {
            return p * multiplier;
        }
        public double GetPerimeter()
        {
            double с = Math.Sqrt(A * A + B * B);
            double l1 = Math.Sqrt(A * A + Height * Height);
            double l2 = Math.Sqrt(Height * Height + B * B);
            return A + B + с + Height + l1 + l2;
        }
    }
}
