using System;

namespace ExceptionHandling
{
    class Program
    {
        // main method
        public static void Main(string[] args)
        {
            HandlingRandomException();
        }

        // given method
        static int Division(int top, int bottom) => top / bottom;

        // method - 1
        static void DivisionNoHandling()
        {
            Division(1, 0);
        }

        // method - 2
        static void DivisionWithExceptionHandling()
        {
            try {
                Division(1, 0);
            }
            catch
            {
                // no action to take
            }
        }

        // method - 3
        static void DivisionWithExceptionHandlingMoreInfo()
        {
            try
            {
                Division(1, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // method - 4
        static void DivisionWithExceptionHandlingThrow()
        {
            try
            {
                Division(1, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Handled Exception : Divide by Zero error");
            }
        }

        // method - 5
        static void GeneratingException()
        {
            throw new Exception("An exception from method : GeneratingException");
        }

        // method - 6
        static void HandlingRandomException()
        {
           try
            {
                Console.WriteLine("Trying below method : GeneratingRandomException()\n");
                GeneratingRandomException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // method - 7
        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 6;
            switch(exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }
        }
    }
}
