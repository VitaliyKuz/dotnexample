using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public int first(int a) //це типу як клас в С
        {
            int c = a / 100;             //створюємо змінну, ділимо без остачі на 100, отримуємо першу цифру заданого числа
            Console.WriteLine(c.ToString()); //тут виводимо на консоль, те що в дужках це функція яка переводить щось у строку
            return c;
        }
        static public int last(int a)
        {
            int b = a % 10;           //остача від ділення на 10 дає останню цифру
            Console.WriteLine(b.ToString());
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число");
            string S1 = Console.ReadLine();            //створюємо змінну, яку і читаємо
            int a = int.Parse(S1);                     //коли щось читається з консолі то воно подається у вигляді строкі, а нам треба саме число, тому в цьому рядку перетворюємо string в int
            first(a);
            last(a);
            Console.ReadLine();

        }
    }
}