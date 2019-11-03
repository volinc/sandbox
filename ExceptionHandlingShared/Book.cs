namespace ExceptionHandlingShared
{
    using System;

    public class Book
    {
        public void Throw() => throw new InvalidOperationException("Very invalid op");
    }
}
