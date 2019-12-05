using System;

namespace HelloWorld
{
    class Program
    {

     /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("This is not hello world, it's a bit different than that!");
            Console.ReadKey();
            int i;
            i = 5;
            Console.WriteLine("The value of i is:");
            Console.WriteLine(i);
            bool d = false;
            var daf = 5.4;
            float da = 5.3434F;
            var adsf = 5.34m;
            DateTime current = DateTime.Now;
            NullRefEx();
            var dag = 5;
            var dog = 10;

            dog = 12;
            dog = 13;
            Console.WriteLine(dog);
            Console.WriteLine(dog);
        }

        /// <summary>
        /// This function tests the null reference exception and try/catch block.
        /// </summary>
        static void NullRefEx()
        {
            ClassTest ct = null;

            try
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ct.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "custom");
            }
            finally
            {

            }
            Console.ReadKey();
        }
    }
}
