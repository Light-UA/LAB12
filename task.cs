using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;
        while (continueCalculating)
        {
            Console.WriteLine("Введіть перше ціле число (границя діапазону):");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге ціле число (границя діапазону):");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = PowRange(a, b);
            Console.WriteLine($"Добуток цілих чисел у заданому діапазоні: {result}");

            Console.WriteLine("Бажаєте продовжити обчислення? (так/ні)");
            string userInput = Console.ReadLine();
            continueCalculating = userInput.ToLower() == "так";
        }
    }

    static int PowRange(int a, int b)
    {
        int product = 1;
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);

        for (int i = start; i <= end; i++)
        {
            product *= i;
        }

        return product;
    }
}
