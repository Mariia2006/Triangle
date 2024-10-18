using System;

namespace ConsoleApp81
{
    class Program
    {
        public static void PrAreEqual()
        {
            Console.WriteLine("Сhecking the equality of piramides: ");
            TRPiramid piramid_1 = new TRPiramid();
            piramid_1.Input();
            piramid_1.Output();
            TRPiramid piramid_2 = new TRPiramid();
            piramid_2.Input();
            piramid_2.Output();
            Console.WriteLine(piramid_1 == piramid_2 ? "The piramides are equal" : "The piramides are not equal");
        }
        public static void AreaAndVolume(TRPiramid piramid)
        {
            Console.WriteLine($"Area of base: {piramid.GetArea()}");
            Console.WriteLine($"Volume: {piramid.GetVolume()}");
            Console.WriteLine($"Perimeter: {piramid.GetPerimeter()}");
        }
        public static void TestPiramidConstructor()
        {
            TRPiramid piramid = new TRPiramid();
            piramid.Output();
            AreaAndVolume(piramid);
        }
        public static void TestPiramidConstructorWithParams()
        {
            TRPiramid piramid = new TRPiramid();
            piramid.Input();
            piramid.Output();
            AreaAndVolume(piramid);
        }
        public static void TestCopyConstructor(TRPiramid piramidToCopy)
        {
            TRPiramid piramid = new TRPiramid(piramidToCopy);
            piramid.Output();
        }
        public static void TestMultiplication(double multiplier)
        {
            TRTriangle triangle = new TRTriangle();
            triangle.Input();
            triangle.Output();
            TRTriangle scaledTriangle = triangle * multiplier;
            Console.WriteLine($"Triangle multiplication test by {multiplier}: ");
            scaledTriangle.Output();
        }
        public static void TrAreEqual()
        {
            Console.WriteLine("Сhecking the equality of triangles: ");
            TRTriangle triangle_1 = new TRTriangle();
            triangle_1.Input();
            triangle_1.Output();
            TRTriangle triangle_2 = new TRTriangle();
            triangle_2.Input();
            triangle_2.Output();
            Console.WriteLine(triangle_1 == triangle_2 ? "The triangles are equal" : "The triangles are not equal");
        }
        public static void AreaAndPerim(TRTriangle triangle)
        {
            Console.WriteLine($"Area: {triangle.GetArea()}");
            Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
        }
        public static void TestDefaultConstructor()
        {
            TRTriangle triangle = new TRTriangle();
            triangle.Output();
            AreaAndPerim(triangle);
        }
        public static void TestParameterizedConstructor()
        {
            TRTriangle triangle = new TRTriangle();
            triangle.Input();
            triangle.Output();
            AreaAndPerim(triangle);
        }
        public static void TestCopyConstructor(TRTriangle triangleToCopy)
        {
            TRTriangle triangle = new TRTriangle(triangleToCopy);
            triangle.Output();
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Testing the TRTriangle class: ");
                Console.WriteLine("What kind of constructor do you want to use?\n1 - without parameters\n2 - with parameters");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                {
                    TestDefaultConstructor();
                }
                else if (ans == 2)
                {
                    TestParameterizedConstructor();
                }
                else
                {
                    throw new ArgumentException("Enter the correct answer!");
                }
                TrAreEqual();
                Console.WriteLine("Enter the multiplier: ");
                double multiplier = double.Parse(Console.ReadLine());
                if (multiplier > 0)
                    TestMultiplication(multiplier);
                Console.WriteLine("Testing the TRPiramid class: ");
                Console.WriteLine("What kind of constructor do you want to use?\n1 - without parameters\n2 - with parameters");
                int ans_2 = int.Parse(Console.ReadLine());
                if (ans_2 == 1)
                {
                    TestPiramidConstructor();
                }
                else if (ans_2 == 2)
                {
                    TestPiramidConstructorWithParams();
                }
                else
                {
                    throw new ArgumentException("Enter the correct answer!");
                }
                PrAreEqual();
                Console.WriteLine("Enter the multiplier: ");
                double multiplier_ = double.Parse(Console.ReadLine());
                if (multiplier_ > 0)
                    TestMultiplication(multiplier_);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
