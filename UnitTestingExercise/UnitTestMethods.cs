using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int a, int b, int c)
        {

            return a + b + c;


        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int minuend, int subtrahend)
        {

            return minuend - subtrahend;

        }

        // Create a Multiply method that passes 2 integers

        public int Multiply(int a, int b)
        {

            return a * b;

        }

        // Create a Divide method that passes 2 integers

        public int Divide(int a, int b)
        {
            try
            {

                return a / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine("can't divide by zero.  returning your zero.");
                return 0;
            }

        }
        
        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string conf = null;
        public void YourMethodName()
        {
            conf = "It Works v1.";
            Console.WriteLine(conf);

        }

        public void YourMethodName2()
        {
            conf = "it doesn't not work!";
            Console.WriteLine(conf);
        }
    }
}
