namespace NumberRenderer
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            bool carryOn = false;
            do
            {
                Console.Clear();
                Console.Write("Enter a number: ");
                int value = Convert.ToInt32(Console.ReadLine());

                var numberRenderer = NumberRendererFactory.Create(value);
                string word = numberRenderer.ConvertNumberToWords(value);

                Console.WriteLine(word);

                Console.Write("Try again? (y/n): ");
                string response = Console.ReadLine();
                carryOn = response == "y";
            } while (carryOn);
        }
    }
}
