using System;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine(HammingDistanceNow(2, 4));
        }

        static int HammingDistanceNow(int x, int y)
        {
            //XOR
            var z = x ^ y;
            var count = 0;
            //違う桁がなくなるまでカウント
            while (z > 0)
            {
                count += z & 1;
                z >>= 1;
            }
            return count;
        }
    }
}
