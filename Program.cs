//***************************************************************
//* Практическая работа № 8                                     *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: составить программу циклической структуры          *
//***************************************************************

using System;

namespace pr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №8.\nЗдравствуйте!");

            for (;;)
            {
                try
                {
                    Console.WriteLine("\nХотели бы вы увидеть таблицу значений функции? (Да/Нет):");
                    string a = Console.ReadLine();

                    if (a == "Нет") // если a = "нет", то завершаем программу
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да") // иначе, если
                    {
                        Console.WriteLine("Введите пределы отрезка.");
                        Console.Write("От:");
                        double x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("До:");
                        double end = Convert.ToInt32(Console.ReadLine());
                        double step = 0.5;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    x |      y");
                        Console.WriteLine("----------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            double y = 5 - Math.Pow(x, 2) / 2; // вычисление значения функции для текущего значения x
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($" {x,4} | {y,6}"); // вывод значения x и y на консоль
                            Console.ForegroundColor = ConsoleColor.White;
                            x += step; // увеличение значения x на шаг (step)
                        } while (x <= end); // выполнение цикла do while до тех пор, пока x не станет больше end
                    }
                    else // иначе
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! Либо Выход. (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
