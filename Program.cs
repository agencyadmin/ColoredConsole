using System;
using System.Linq;

namespace SkillFactory.ColoringNumbers
{ 
    class Program
    { 
        static readonly Random random = new Random();   

        public static void Main()
        {
            const string HelloWorldRus = "ПриветМир!!!";
            const string HelloWorldEn = "ПриветМир!!!";
            const string HelloWorldEs = "ПриветМир!!!";

            var str = new[] {HelloWorldRus, HelloWorldEn, HelloWorldEs};
            var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>.ToArray();

            do
            {
                foreach (var strs in str)
                {
                    foreach (var word in strs)
                    {
                        var rnd = random.Next(list.Count());
                        var color = list[rnd];

                        if (color==ConsoleColor.Black)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Diagnostics.Debug.WriteLine("Черный цвет сейчас был бы...");
                        }
                        else
                        {
                            Console.ForegroundColor = color;
                            System.Diagnostics.Debug.WriteLine($"Сейчас цвет { color }");
                        }
                        Console.Write(word);
                        System.Threading.Thread.Sleep(100);
                    }
                    Console.WriteLine();
                }
                
            } while (true) ;

        }
    }
}