namespace Task1
{
    internal class Program : ILogger
    {
        static void Main(string[] args)
        {
            int a, b;
            
            Console.WriteLine("Сумма двух чисел");
            do
            {
                Console.Write("Введите первое число: ");
            }
            while (!isCorrect(Console.ReadLine(), out a));

            do
            {
                Console.Write("Введите второе число: ");
            }
            while (!isCorrect(Console.ReadLine(), out b));

            Calculator calculator = new Calculator();

            Console.Write($"{a} + {b} = : {calculator.Sum(a, b)}");
        }

        /// <summary>
        /// Проверка корректности ввода числа
        /// </summary>
        /// <param name="str"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        static bool isCorrect(string str, out int result)
        {
            try
            {
                result = Convert.ToInt32(str);
            }
            catch (Exception ex)
            {
                ILogger logger = new Logger();
                Console.ForegroundColor = ConsoleColor.Red;
                logger.Write(ex.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                logger.Write(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                result = 0;
                return false;
            }

            return true;
        }
    }
}