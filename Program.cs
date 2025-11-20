using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lub6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // текстова інформація
            Console.WriteLine("Лабораторна робота №6\nТема роботи: Обробка винятків в C#\n");
            Console.WriteLine("Варіант №32\nНеобхідно реалізувати програму, яка намагається перетворити введене користувачем значення в тип int. Якщо введене значення не є числом (наприклад, текст або символи), програма повинна вивести повідомлення про помилку через блок catch. Вивести помилку в консоль за допомогою методу Console.WriteLine()..");
            Console.WriteLine("\nВиконав студент БІП1-25\nФризько Денис\n");
            Console.WriteLine("------------ -------------- --------------\n");

            while (true) // цикл while (true) виконується весь час до команди break
            {
                // перевірка пустого рядка
                Console.Write("Введіть число: ");
                string text = Console.ReadLine();

                if (string.IsNullOrEmpty(text)) // перевірка чи введене значення не є пустим рядком
                {
                    Console.WriteLine("[Помилка] Ви нічого не ввели, введіть число.\n");
                }
                else
                {
                    try
                    {
                        int chyslo = Convert.ToInt32(text); // перетворюємо наш текст у число для перевірки формату чи інших помилок
                        Console.WriteLine("Ви ввели число: " + chyslo + "\n");
                    }
                    catch (FormatException pomylka) // перевірка чи є помилка за форматом
                    {
                        Console.WriteLine($"[Помилка формату] Введене значення не є числом, введіть число.\nСистемне повідомлення: {pomylka.Message}\n"); // Обробка помилки перетворення
                    }
                    catch (Exception pomylka) // перевірка всіх інших помилок
                    {
                        Console.WriteLine($"[Помилка значення] Потрібно ввести число яке буде в діапазоні від -2147483648 до 2147483647.\nСистемне повідомлення: {pomylka.Message}\n");
                    }
                }

                continue; // запускаємо цикл знову для нової перевірки
            }

        }
    }
}
