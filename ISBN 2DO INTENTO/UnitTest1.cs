using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvalid1_RESULTDIF0()
        {
            bool ISBNVA = false;
            int ISBN10 = int.Parse("0716703440");

            int[] value = new int[10];
            int v = 0;

            for (int i = 0; i < 10; i++)
            {
                ISBN10 = ((value[v] * 10) + (value[v] * 9) + (value[v] * 8) + (value[v] * 7) + (value[v] * 6) + (value[v] * 5) + (value[v] * 4) + (value[v] * 3) + (value[v] * 2) + (value[v] * 1)) % 11;
            }


            if (ISBN10 != 0)
            {
                Assert.IsFalse(ISBNVA);
            }


        }

        [TestMethod]
        public void TestInValid_MENOSDE10DIG()
        {
            bool ISBNVA = false;
            int ISBN10 = int.Parse("0716703");

            int[] value = new int[10];
            int v = 0;

            for (int i = 0; i < 10; i++)
            {
                ISBN10 = ((value[v] * 10) + (value[v] * 9) + (value[v] * 8) + (value[v] * 7) + (value[v] * 6) + (value[v] * 5) + (value[v] * 4) + (value[v] * 3) + (value[v] * 2) + (value[v] * 1)) % 11;
            }


            if (ISBN10 < 10)
            {
                Assert.IsFalse(ISBNVA);
            }


        }

 
    }
}
