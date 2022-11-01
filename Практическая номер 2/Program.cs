namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = " ";
            while (a != "Выход")
            {
                Console.WriteLine("Меню");
                Console.WriteLine(" 1. Угадай число");
                Console.WriteLine(" 2. Таблица умножения");
                Console.WriteLine(" 3. Вывод делителей числа");
                Console.WriteLine("Напишите 'Выход' чтобы закончить  ");
                Console.Write("Выберите действие : ");
                a = Console.ReadLine();
                if (a == "1")
                {
                    Random();
                }
                else if (a == "2")
                {
                    TY();
                }
                else if (a == "3")
                {
                    delitel();
                }
                else if (a == "Выход")
                {
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
            Random rand = new Random();

            Console.Write("Угадайте число от 0 до 100 !!! : ");
            int i = Convert.ToInt32(Console.ReadLine());

            int a = rand.Next(0, 100);

            while (i != a)
            {
                Console.Write("Ой вы не угадали попройте еще раз ");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Поздарвляю вы угадали !!!!!!");
            Console.WriteLine(" ");
        }
        static void TY()
        {
            Console.WriteLine(" ");
            var arr = new int[10, 8];

            int N = 1;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        N++;
                        arr[i, j] = N;
                    }
                    else
                    {
                        arr[i, j] = (i + 1) * arr[0, j];
                    }
                    Console.Write(arr[i, j] + "\t");
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
