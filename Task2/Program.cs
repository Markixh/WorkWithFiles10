namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            ILogger logger = new Logger();

            logger.Event("Сумма двух чисел");

            do
            {
                logger.Event("Введите первое число: ");
            }
            while (!isCorrect(Console.ReadLine(), out a));

            do
            {
                logger.Event("Введите второе число: ");
            }
            while (!isCorrect(Console.ReadLine(), out b));

            Calculator calculator = new Calculator();

            try
            {
                logger.Event($"{a} + {b} = {calculator.Sum(a, b)}");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Проверка корректности ввода числа
        /// </summary>
        /// <param name="str"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        static bool isCorrect(string str, out int result)
        {
            ILogger logger = new Logger();
            try
            {
                result = Convert.ToInt32(str);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                result = 0;
                return false;
            }
            return true;
        }
    }
}