namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower limit of the range:");
            int lowerLimit = GetValidNumberInput();

            Console.WriteLine("Enter the upper limit of the range:");
            int upperLimit = GetValidNumberInput();

            Console.WriteLine($"\nFibonacci numbers in the range {lowerLimit} - {upperLimit}:");

            int first = 0, second = 1;
            while (first <= upperLimit)
            {
                if (first >= lowerLimit)
                {
                    Console.Write(first + " ");
                }

                int temp = first + second;
                first = second;
                second = temp;
            }
        }

        private static int GetValidNumberInput()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            return number;
        }
    }
}
