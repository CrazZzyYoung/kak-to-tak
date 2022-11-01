using System;

namespace kak_to_tak // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклaда: ");
            double sl = Convert.ToDouble(Console.ReadLine());

            if (sl < 100)
            {
                sl = sl * 1.05;
            }
            if ((sl >= 100) && (sl < 200))
            {
                sl = sl * 1.07;
            }
            if (sl >= 200)
            {
                sl = sl * 1.1;
            }
            Console.WriteLine("Обащая сумма с начисленными процентами: {0:f2}", sl);
        }
    }
}