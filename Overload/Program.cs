using System;

namespace Overload
{
    public class MathHelper
    {
            public int PrintValue(int x, int y) 
            {
                return x + y;
            }
            public int PrintValue(bool value)
            {
            return value ? 1:0;
            }
            public void PrintValue(string a, string b)
            {
                string word = a + b;
                Console.WriteLine(word);
            }
            public int PrintValue(int x, int y, int z)
            {
                return (x * y * z);
            }
     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper math = new MathHelper();

            int sum = math.PrintValue(3, 13);
            Console.WriteLine(sum);
            int trueorfalse = math.PrintValue(true);
            Console.WriteLine(trueorfalse);
            math.PrintValue("Ali", "Salmanov");
            int multiplication = math.PrintValue(3, 13, 33);
            Console.WriteLine(multiplication);
        }
    }
}
