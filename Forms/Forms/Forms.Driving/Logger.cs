using System;
using Forms.Driving.Infrastructure;

namespace Forms.Driving
{
    public class Logger : ILogger
    {
        public void Trace(string message)
        {
            Console.WriteLine(message);
        }

        public void Trace(string message, object data)
        {
            Console.WriteLine(message);
        }

        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Debug(string message, object data)
        {
            Console.WriteLine(message);
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Info(string message, object data)
        {
            Console.WriteLine(message);
        }

        public void Warning(string message)
        {
            Console.WriteLine(message);
        }

        public void Warning(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public void Warning(string message, object data)
        {
            Console.WriteLine(message);
        }

        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public void Error(string message, object data)
        {
            Console.WriteLine(message);
        }

        public void Fatal(string message)
        {
            Console.WriteLine(message);
        }

        public void Fatal(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public void Fatal(string message, object data)
        {
            Console.WriteLine(message);
        }
    }
}
