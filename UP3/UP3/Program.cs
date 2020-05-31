using System;

namespace UP3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool res;
            Console.WriteLine("Введите значение х");
            x = CheckUserNumber();
            Console.WriteLine("Введите значение y");
            y = CheckUserNumber();
            res = CheckDia(x, y);
            if (res == true)
                Console.WriteLine("Точка входит в заданный диапазон");
            else Console.WriteLine("Точка не входит в заданный диапазон");

        }
        public static double CheckUserNumber()
        {
            bool ok;
            double n;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out n);
                if (!ok) Console.WriteLine("Ошибка ввода. Повторите попытку");
            } while (!ok);
            return n;
        }
        public static bool CheckDia(double x, double y)
        {
            bool res;
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
            {
                res = true;
            }
            else res = false;
            return res;
        }
    }
}
