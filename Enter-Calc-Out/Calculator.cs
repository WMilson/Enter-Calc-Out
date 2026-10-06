using System;
using System.Text;

namespace Enter_Calc_Out
{
    public static class Calculator
    {
        public static double Sum(double a, double b) => a + b;

        public static double Product(double a, double b) => a * b;

        // Наибольший общий делитель (алгоритм Евклида)
        public static long Gcd(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Формирует итоговое сообщение по выбранным режимам
        public static string Calculate(double a, double b,
                                       bool needSum, bool needGcd, bool needProduct)
        {
            var sb = new StringBuilder();

            if (needSum) sb.AppendLine($"Сумма: {Sum(a, b)}");
            if (needGcd) sb.AppendLine($"НОД: {Gcd((long)a, (long)b)}");
            if (needProduct) sb.AppendLine($"Произведение: {Product(a, b)}");

            if (sb.Length == 0)
                sb.AppendLine("Не выбрано ни одного режима вычислений.");

            return sb.ToString();
        }
    }
}