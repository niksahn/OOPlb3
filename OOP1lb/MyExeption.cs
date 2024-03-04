namespace OOP1lb
{
    public class MyException : Exception
    {
        public MyException() : base() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception innerException) : base(message, innerException) { }
    }
}
