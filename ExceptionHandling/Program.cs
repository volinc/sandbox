namespace ExceptionHandling
{
    using ExceptionHandlingShared;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;

    internal class Program
    {
        private static void Main()
        {
            try
            {
                new Book().Throw();
                new TypeConverter().ConvertTo(0, typeof(Guid));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Source);
                Debug.WriteLine(exception);
            }

            Console.ReadLine();
        }
    }
}
