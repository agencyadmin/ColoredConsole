using System;
using System.Linq;

namespace SkillFactory.ColoringNumbers
{ 
    class Program
    { 
        static readonly Random random = new Random();   
        public enum HelthFriq
            { 
            //174 Гц, Уменьшение физической и энергетической боли 		
            KillPain = 174,
            //285 Гц, Ремонт поврежденных тканей
            SkinRepair = 285,
	        //396 Гц, Превращение печали в радость, освобождение вины и страха 
            BeFanny = 396,
	        //417 Гц, Отмена ситуаций и содействие изменению, отпусти прошлое 
            CloseFrame = 417,
	        Helth1 = 432,
            //528 Гц, Регенерация ДНК и исцеление всего тела 	
            DnaRegen = 528,
	        //639 Гц, Привлечение любви во всех ее формах, гармонизация отношений в семье 
            LoveCome = 639,
	        //741 Гц, Решение проблем, самовыражение, расширение сознания 
            SolveAll = 741,
	        //852 Гц, Пробуждение интуиции, возвращение Духовной Упорядоченности 
            Intuition = 852,
	        //963 Гц, Пробуждение совершенства, активация третьего глаза и очищение шишковидной железы
            GoldCrise = 888,
            ThirdEye =  963,
            Helth2 = 999,
            GotsLight = 1111,
            Helth3 = 1122
       
            }
        public static void Main()
        {
            /* const string HelloWorldRus = "ПриветМир!!!";
               const string HelloWorldEn = "ПриветМир!!!";
               const string HelloWorldEs = "ПриветМир!!!";

               var str = new[] {HelloWorldRus, HelloWorldEn, HelloWorldEs};
               var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();

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

               } while (true) ;*/
            var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
            var HelthFrik1 = new HelthFriq();
            
            
            do

            {
                foreach (var i in list)
                {
                    int freq = random.Next(200,1000);
                    int bcolor = random.Next(14);
                    Console.ForegroundColor = i;
                    Console.BackgroundColor = list[bcolor];
                    if (Console.ForegroundColor == Console.BackgroundColor)
                    {
                       
                        Console.ForegroundColor = list[1];
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Было совпадение!!! Фон совпадения: {0}, Цвет текста совпадения: {1}.", Console.BackgroundColor.ToString(), i);
                        Console.Beep(432, 3000);
                     


                    }
                    Console.WriteLine("Фон: {0}, Цвет текста: {1}.", Console.BackgroundColor.ToString(), i.ToString()) ;
                    Console.WriteLine("Доброго дня Ванечка!!!! Процветаний и наслаждений!!!");
                    //System.Threading.Thread.Sleep(100);
                    //var rnd = random;
                   
                    Console.WriteLine($"Частота равна: {freq}");
                    Console.WriteLine($"i.ToString() =  {(i.ToString())}");
                    Console.WriteLine($"(int)i =  {(int)i}");
                    Console.WriteLine($"i =  {i}");
                    Console.WriteLine($"Фон: {0}, Цвет текста: {1}.", Console.BackgroundColor.ToString(), i.ToString());
                    Console.WriteLine(list.ToString());
                    //Console.WriteLine("Enter frequency:");
                    Console.Beep(freq,5000);
                    //freq++;
                    //Console.ForegroundColor = i-1;

                }
            }
            while (true);

        }
    }
}