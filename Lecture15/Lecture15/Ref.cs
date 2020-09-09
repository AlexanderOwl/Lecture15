using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture15
{
    class Ref
    {
        static void AddValue(ref int value)
        {
            Console.WriteLine("A new value is assigned value =" + value);

            value = 5; // присваиваем новое значение 
        }
        public Ref()
        {
            
            int price = 7; // обязательно нужно инициализировать 
            Console.WriteLine("REF" +
                "To use REF must be initialized int price = " + price);
            AddValue(ref price);
            Console.WriteLine("Without return, using ref, you can return the value by reference.");

            Console.WriteLine("Now price =" + price);
            // на экране увидим 5 
        }
    }
}
