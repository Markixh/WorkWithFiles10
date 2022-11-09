namespace Task1
{
    public interface ILogger
    {
        void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
