using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingISBN1
{
    [TestClass]
    public class UnitTestISBN
    {
        [TestMethod]
        public void ValidISBN()
        {
            bool ValidationISBN = false; 
            
            string ISBN = "017603440";

            int sum = 0, value; int i = 0;

            while (i < ISBN.Length - 1)
            {
                value = int.Parse(ISBN[i].ToString());
                sum += (value * (10 - 1));
                int mod = sum % 11;
                ValidationISBN = (mod == 0);

                Assert.IsTrue(ValidationISBN);
            }
        }
       
        

    }

}
