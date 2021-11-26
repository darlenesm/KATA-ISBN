using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest2
{
    class ISBNVA
    {
        public static bool ISBN (Int64 ISBN10)

        {
            int[] value = new int[10];
            int v = 0;

            for (int i = 0; i < 10; i++)
            {
                ISBN10 = ((value[v] * 10) + (value[v] * 9) + (value[v] * 8) + (value[v] * 7) + (value[v] * 6) + (value[v] * 5) + (value[v] * 4) + (value[v] * 3) + (value[v] * 2) + (value[v] * 1)) % 11;
            }

            if (ISBN10 != 0)
            {
                Console.WriteLine("Invalid");
            }
            else if (ISBN10 == 0)
            {
                Console.WriteLine("Valid");
            }
            return true; 
        }

        public static void ISBN2 (Int64 ISBN13)
        {
            int[] value = new int[13];
            int v = 0;

            for (int i = 0; i < 13; i++)
            {
                ISBN13= ((value[v] * 1) + (value[v] * 3) + (value[v] * 1) + (value[v] * 3) + (value[v] * 1) + (value[v] * 3) + (value[v] * 1) + (value[v] * 3) + (value[v] * 1) + (value[v] * 3)) % 10;
            }

            if (ISBN13 == 0)
            {
                Console.WriteLine("Invalid");
            }
            else if (ISBN13 != 0)
            {
                Console.WriteLine("Valid");
            }

        }

        public static void Main ()
        {
            int val;
            Console.WriteLine("AGREGUE ISBN: ");
            val = (int)long.Parse(Console.ReadLine());

            ISBNVA.ISBN(val);
            ISBNVA.ISBN2(val);


        }
    }
}
