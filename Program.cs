using System;
using System.Collections;

namespace XORarray
{
  
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray ar = new DynamicArray(8);
            XORdecorate xr = new XORdecorate(ar); 

            xr.AddValue(10);
            xr.AddValue(15);
            xr.AddValue(35);
            xr.AddValue(75);

            
            for (int i = 0; i < xr.GetLength; i++)
            {
                Console.WriteLine("После XOR: " + xr.GetValue(i));
            }

            for (int i = 0; i < xr.GetLength; i++)
            {
                Console.WriteLine("После расшифровки: " + xr.GetValueWithReXOR(i));
            }
            
        }
    }
}
