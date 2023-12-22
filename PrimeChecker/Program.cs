namespace PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("素数判定プログラムへようこそ!!\n\n");
            
            while (true)
            {
                Console.WriteLine("好きな自然数を入力してね!");

                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("判定不可:入力値が空です。");
                }
                else
                {
                    try
                    {
                        ulong number = ulong.Parse(input);
                        bool result = IsPrimeNumber(number);
                        if (result)
                        {
                            Console.WriteLine($"{number} は素数です。\n");
                        }
                        else
                        {
                            Console.WriteLine($"{number} は素数ではありません。\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"エラー\n{ex.Message}\n");
                    }
                }
            }
        }

        private static bool IsPrimeNumber(ulong number)
        {
            if (number < 2) return false;

            if (number == 2) return true;

            //number が 2 から number - 1 のいずれかの自然数で割れるか 
            for (ulong i = 2; i < number; i++) 
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
