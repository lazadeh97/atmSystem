using System;
using System.Collections.Generic;

namespace bank_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = false;
            string operation = null;
            float additionalAmount, amountWithdrawn = 0f;
            List<float> processes = new List<float>();

            Console.WriteLine("Hesabinizdaki pul miqdarini daxil edin: ");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Emeliyyatlar: \n 1 - Pul yatirma \n 2 - Pul cekme \n 3 - Cixis \n");

            do
            {
                Console.WriteLine("Verilmis emeliyyatlardan birini secin:");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Daxil etmek istediyiniz meblegi yazin:");
                        additionalAmount = float.Parse(Console.ReadLine());
                        salary += additionalAmount;
                        processes.Add(additionalAmount);
                        break;
                    case "2":
                        Console.WriteLine("Cixarmaq istediyiniz meblegi yazin:");
                        amountWithdrawn = float.Parse(Console.ReadLine());
                        salary -= amountWithdrawn;
                        processes.Add(-amountWithdrawn);
                        break;
                    case "3":
                        isContinue = false;
                        goto Case3;
                    default:
                        Console.WriteLine("Hec bir emeliyyat secmediniz!");
                        break;
                }
                Console.WriteLine("Davam etmek isteyirsinizmi? (h/y)");

                char question = char.Parse(Console.ReadLine());


                if (operation != "3" && (question.Equals('h') || question.Equals('H')))
                {
                    isContinue = true;
                }
                else
                {
                    isContinue = false;
                }
            } while (isContinue);

            Case3:
            Console.WriteLine("Hesab uzerinde emeliyyatlar: \n");
            Console.WriteLine("1-Cari hesab melumati:" + " " + salary);
            Console.WriteLine("2-Emeliyyatlar ardicilligi:");
            
            foreach (var item in processes)
            {
               Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Proqrami bitirmek ucun her hansisa bir duymeye klik edin!");
            Console.ReadKey();
        }
    }
}
