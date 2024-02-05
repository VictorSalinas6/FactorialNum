namespace FactorialNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number do you wish to know the factorial of? (Only positive numbers)");
            var answer = Console.ReadLine();
            bool check = false;
            int number = 0;

            do
            {
                try
                {
                    var factorial = int.Parse(answer);

                    if (factorial < 0)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                        number = factorial;
                    }
                }
                catch (Exception e)
                {
                    check = false;
                }
                finally
                {
                    if (!check)
                    {
                        Console.WriteLine($"{answer} is not a correct number, please try again but now using a positive number.");
                        answer = Console.ReadLine();
                    }

                }
            } while (!check);

            double factorialNum = Factorial(number);

            Console.WriteLine();
            Console.WriteLine($"The factorial of {number} is {factorialNum}");
        }

        public static double Factorial(int num)
        {
            double answer = 1;
            for (var i = num; i > 0; i--)
            {
                answer *= i;
            }

            return answer;
        }
    }

}
