namespace Erdniev4
{
    class Class1
    {
        static void Ex4_107()
        {
            Console.WriteLine("Введите номер месяца");
            int mounthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (mounthNumber)
            {
                case 1: Console.Write("Январь - 31 день"); break;
                case 2:
                    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    {
                        Console.Write("Февраль - 29 дней");
                    }
                    else
                    {
                        Console.Write("Февраль - 28 дней");
                    }
                    break;
                case 3: Console.Write("Март - 31 день"); break;
                case 4: Console.Write("Апрель - 30 дней"); break;
                case 5: Console.Write("Май - 31 день"); break;
                case 6: Console.Write("Июнь - 30 дней"); break;
                case 7: Console.Write("Июль - 31 день"); break;
                case 8: Console.Write("Август - 31 день"); break;
                case 9: Console.Write("Сентябрь - 30 дней"); break;
                case 10: Console.Write("Октябрь - 31 день"); break;
                case 11: Console.Write("Ноябрь - 30 дней"); break;
                case 12: Console.Write("Декабрь - 31 день"); break;
            }
        }
        static void Ex4_110()
        {
            Console.WriteLine("Введите номер масти карты (от 1 до 4)");
            int cardSuit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер достоинства карты (от 6 до 14");
            int cardDignity = Convert.ToInt32(Console.ReadLine());

            switch (cardDignity)
            {
                case 6: Console.Write("Шестерка"); break;
                case 7: Console.Write("Семерка"); break;
                case 8: Console.Write("Восьмерка"); break;
                case 9: Console.Write("Девятка"); break;
                case 10: Console.Write("Десятка"); break;
                case 11: Console.Write("Валет"); break;
                case 12: Console.Write("Дама"); break;
                case 13: Console.Write("Король"); break;
                case 14: Console.Write("Туз"); break;
            }
            switch (cardSuit)
            {
                case 1: Console.Write(" пик"); break;
                case 2: Console.Write(" треф"); break;
                case 3: Console.Write(" бубен"); break;
                case 4: Console.Write(" червей"); break;
            }
        }
        static void Ex4_114()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int mounth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nДата предыдущего дня: {day - 1}.{mounth}.{year}");
            Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{year}");

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("\nГод високосный");
            }
            else
            {
                Console.WriteLine("\nГод не високосный");
            }
        }
        static void Main()
        {
            Console.WriteLine("Какое задание выполнить (4.107, 4.110, 4.114)?");
            string exercise = Console.ReadLine();

            if (exercise == "4.107")
            {
                Ex4_107();
            }
            else if (exercise == "4.110")
            {
                Ex4_110();
            }
            else if (exercise == "4.114")
            {
                Ex4_114();
            }
        }
    }
}