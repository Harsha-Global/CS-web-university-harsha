using System;

namespace HexdecimalExample
{
    class Program
    {
        static void Main()
        {
            int dec1 = 742;
            string hex1 = Convert.ToString(dec1, 16); //decimal to hexadecimal
            Console.WriteLine(hex1);

            int dec2 = Convert.ToInt32(hex1, 16); //hexadecimal to decimal
            Console.WriteLine(dec2); //742

            //hexadecimal literals
            int dec3 = 0x64;
            Console.WriteLine(dec3);
            Console.ReadKey();
        }
    }
}
