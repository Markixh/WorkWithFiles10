
namespace Task2
{
    public class Logger : ILogger
    {
        /// <summary>
        /// Вывод события в консоль
        /// </summary>
        /// <param name="message"></param>
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Вывод ошибки в консоль
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
