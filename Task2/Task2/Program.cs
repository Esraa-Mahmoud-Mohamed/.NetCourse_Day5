
using System.Numerics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            Complex c3 = new Complex();

            c1.SetReal(10);
            c1.SetImg(0);

            c2.SetReal(0);
            c2.SetImg(-4);

            Console.WriteLine(c1.Print());
            Console.WriteLine(c2.Print());

            c3 = c1.Add(c2);


            Console.WriteLine(c3.Print());
        }
    }
}



