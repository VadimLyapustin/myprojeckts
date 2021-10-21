using System;

namespace convertor_variant_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t КОНВЕРТОР ВАЛЮТ\n\n");
            Console.WriteLine("введите сумму в рублях");
            string sum = Console.ReadLine();
            int summ = int.Parse(sum);
            double a = 72.8;
            double b = 81.2;
            double c = 97.8;
            double d = 77.6;
            Console.WriteLine("выбирите валюту:\n");
            Console.WriteLine("\ta - dollars" );
            Console.WriteLine("\tb - euro");
            Console.WriteLine("\tc - pounds");
            Console.WriteLine("\td - sw.frank" );
            string letter = Console.ReadLine();
            
              if (letter == "a") 
            {
                Console.WriteLine("cумма = " + Math.Round((summ / a),2) + "долларов(а)");
            }
            if (letter == "b")
            {
                Console.WriteLine("cумма = " + Math.Round((summ / b), 2) + "евро");
            }
            if (letter == "c")
            {
                Console.WriteLine("cумма = " + Math.Round((summ / c), 2) + "фунтов");
            }
            if (letter == "d")
            {
                Console.WriteLine("cумма = " + Math.Round((summ / d), 2) + "франков(а)");
            }
            else Console.WriteLine("иди в задницу");
            Console.ReadLine();
        }
    }
}
