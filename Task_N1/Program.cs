using System;

namespace Task_N1
{
    class Mat
    {
        public decimal Sum(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        
        public decimal Remove(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public string Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return "The phrase does not make sense";
            }
            return Convert.ToString(num1 / num2);
        }
        public string Residual(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return "The phrase does not make sense";
            }
            return Convert.ToString(num1 % num2);
        }
    }
    class Program
    {
        public decimal Input()
        {
            bool Vaild = false;
            while (Vaild == false)
            {
                Console.Write($"Please input number - ");
                string Input = Console.ReadLine();
                if (decimal.TryParse(Input, out decimal Number))
                {
                    return Number;
                }
                else
                    Console.WriteLine("Not an integer, please try again.");
            }
            return 0;
        }
        static void Main()
        {
            decimal num1 = new Program().Input();
            decimal num2 = new Program().Input();
            decimal sum = new Mat().Sum(num1, num2);
            decimal remove = new Mat().Remove(num1, num2);
            decimal multiply = new Mat().Multiply(num1, num2);
            string divide = new Mat().Divide(num1, num2);
            string residual = new Mat().Residual(num1, num2);
            Console.WriteLine();
            Console.WriteLine($"{num1} plus {num2} is equal to {sum}");
            Console.WriteLine($"{num1} remove {num2} is equal to {remove}");
            Console.WriteLine($"{num1} multiplied by {num2} is equal to {multiply}");
            if (divide != "The phrase does not make sense")
            {
                Console.WriteLine($"{num1} divide  {num2} is equal to {divide}");
                Console.WriteLine($"{num1} divide {num2} residual equal to {residual}");
            }
            
            Console.ReadKey();


        }
    }
}
