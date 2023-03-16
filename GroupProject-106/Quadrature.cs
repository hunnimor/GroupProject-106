using System;
using System.Collections.Generic;
using GroupProject_106;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace GroupProject_106
{
    public class Quadrature
    {
        //Базовые определения для квадратурных формул
        double __sum = 0.0;
        int __nseg = 1;  // число отрезков разбиения
        int __ncalls = 0; // считает число вызовов интегрируемой функции
        private string funcsia;

        public Quadrature(string func)
        {
            this.funcsia = func;
        }

        public double func(double x)
        {
            PostfixNotationExpression c = new PostfixNotationExpression();
            return c.result(funcsia, x);
        }
        public double __restart(double x0, double x1, int nseg0, bool reset_calls = true)
        {
            // Обнуление всех счётчиков и аккумуляторов.
            // Возвращает интеграл методом трапеций на начальном разбиении
            if (reset_calls)
                this.__ncalls = 0;
            this.__nseg = nseg0;
            // вычисление суммы для метода трапеций с начальным разбиением на nseg0 отрезков
            this.__sum = 0.5 * (func(x0) + func(x1));
            double dx = 1.0 * (x1 - x0) / nseg0;
            for (int i = 1; i < nseg0; i++)
            {
                this.__sum += func(x0 + i * dx);
            }

            this.__ncalls += 1 + nseg0;
            return this.__sum * dx;
        }

        public double __double_nseg(double x0, double x1)
        //public double __double_nseg(double x0, double x1)
        {
            //"""Вдвое измельчает разбиение.
            //   Возвращает интеграл методом трапеций на новом разбиении"""
            int nseg = this.__nseg;
            double dx = (x1 - x0) / nseg;
            double x = x0 + 0.5 * dx;
            double AddedSum = 0.0;
            for (int i = 0; i < nseg; i++)
            {
                AddedSum += func(x + i * dx);
            }
            this.__sum += AddedSum;
            this.__nseg *= 2;
            this.__ncalls += nseg;
            return this.__sum * 0.5 * dx;
        }


        public double romberg(double x0, double x1, double rtol = 0.5, int nseg0 = 1, int maxcol = 5, bool reset_calls = true)
        {
            // Интегрирование методом Ромберга
            // nseg0 - начальное число отрезков разбиения
            // maxcol - максимальный столбец таблицы"""
            // Инициализация таблицы
            List<List<double>> Itable = new();
            Itable.Add(new List<double> { __restart(x0, x1, nseg0, reset_calls) });
            //ListPrint(Itable);
            int i = 0;
            maxcol = Math.Max(0, maxcol);
            double ans = Itable[i][i];
            double error_est = Math.Max(1, Math.Abs(ans));
            while (error_est > Math.Abs(rtol * ans))
            {
                double old_ans = ans;
                i += 1;
                double d = 4.0;
                int ans_col = Math.Min(i, maxcol);
                //------------------------------------------------------
                Itable.Add(new List<double> { });
                for (int z = 0; z < ans_col + 1; z++)
                    Itable[^1].Add(__double_nseg(x0, x1));
                //------------------------------------------------------
                for (int j = 0; j < ans_col; j++)
                {
                    double diff = Itable[i][j] - Itable[i - 1][j];
                    Itable[i][j + 1] = Itable[i][j] + diff / (d - 1.0);
                    d *= 4.0;
                }

                ans = Itable[i][ans_col];
                if (maxcol <= 1)
                {
                    // методы трапеций и парабол обрабатываются отдельно
                    error_est = Math.Abs(ans - Itable[i - 1][-1]);
                }
                else if (i > maxcol)
                {
                    error_est = Math.Abs(ans - Itable[i][Math.Min(i - maxcol - 1, maxcol - 1)]);
                }
                else
                {
                    error_est = Math.Abs(ans - Itable[i - 1][i - 1]);
                }
                Console.WriteLine(ans);
            }
            Console.WriteLine($"Total function calls: {this.__ncalls}");
            return ans;
        }
    }
}