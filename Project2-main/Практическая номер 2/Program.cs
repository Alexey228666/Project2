namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("Меню");
                Console.WriteLine(" 1. Угадай число");
                Console.WriteLine(" 2. Таблица умножения");
                Console.WriteLine(" 3. Вывод делителей числа");
                Console.WriteLine("Напишите 'Выход' чтобы закончить  ");
                Console.Write("Выберите действие : ");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    Random();
                }
                else if (a == "2")
                {
                    table();
                }
                else if (a == "3")
                {
                    delitel();
                }
                else if (a == "Выход")
                {
                    start = false;
                    Console.WriteLine("Досвидания");
                }
                else
                {
                    Console.WriteLine("Такого действия в списке нету попробуйте еще раз");
                }
            }
        }

        static void Random()
        {
            Console.WriteLine(" ");
            Random random = new Random();

            Console.Write("Угадайте число от 0 до 100 !!! : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int a = random.Next(0, 100);

            while (number != a)
            {
                Console.Write("Ой вы не угадали попройте еще раз ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Поздарвляю вы угадали !!!!!!");
            Console.WriteLine(" ");
        }
        static void table()
        {
            Console.WriteLine(" ");
            var massiv = new int[10, 8];

            int support = 1;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        support++;
                        massiv[i, j] = support;
                    }
                    else
                    {
                        massiv[i, j] = (i + 1) * massiv[0, j];
                    }
                    Console.Write(massiv[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
        static void delitel()
        {
            Console.WriteLine(" ");
            Console.Write("Введите число : ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < a + 1; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(" ");
        }
    }
}
