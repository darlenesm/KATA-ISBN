using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestOneISBN

{
    public static class ISBNVALIDATOR1
    {
        public static bool ISBNVA(string ISBN)
        {
            int sum = 0, value;

            if (ISBN.Length == 10)
            {

                int i = 0;
                while (i < ISBN.Length -1)
                {
                    value = int.Parse(ISBN[i].ToString());
                    sum += (value * (10 - 1));
                    i++;

                }

                int mod = sum % 11;
                return (mod == 0);


            }
            if (ISBN.Length == 13)
            {

                int i = 0;
                while (i < ISBN.Length - 1)
                {
                    value = int.Parse(ISBN[i].ToString());
                    sum += ISBN[i] * (i % 2 == 1 ? 3 : 1);
        

                }

              if (sum % 10 == 0)
                {
                    return true;
                }
              else
                {
                    return false;
                }


            }
            return true;
        }
        public static void Main()
        {
            string ISBN = "017603440";
            Console.WriteLine(ISBN);

            if (ISBNVA(ISBN))
                Console.WriteLine("ISBN Valid");
            else
                Console.WriteLine("ISBN Invalid");

        }


    }


}

