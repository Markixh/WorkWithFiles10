namespace Task1
{
    internal class Program 
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

            Console.Write($"{a} + {b} = {calculator.Sum(a, b)}");

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
            try
            {
                result = Convert.ToInt32(str);
            }
            catch
            {               
                result = 0;
                return false;
            }

            return true;
        }
    }
}