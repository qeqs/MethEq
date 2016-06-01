using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethEq
{
    /// <summary>
    /// Методы для первого задания
    /// </summary>
    class Linear
    {
        /// <summary>
        /// Парсинг для матрицы
        /// </summary>
        /// <param name="s">из многострочного текстбокса</param>
        /// <returns></returns>
        public static double[,] GetMatrix(string[] s)
        {
            double[,] a = new double[s.Length, s.Length];

            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        string[] temp =s[i].Split(' ', '_');
                        a[i, j] = double.Parse(temp[j]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return a;
        }
        /// <summary>
        /// Парсинг для вектора
        /// </summary>
        /// <param name="s">однострочный текстбокс</param>
        /// <returns></returns>
        public static double[] GetMatrix(string s)
        {
            double[] b = new double[s.Length];

            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                        string[] temp = s.Split(' ', '_');
                        b[i] = double.Parse(temp[i]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return b;
        }
        /// <summary>
        /// Метод Гауса.
        /// </summary>
        /// <param name="a">Массив коэф. матрицы А.</param>
        /// <param name="b">Массив коэф. вектора В.</param>
        /// <param name="n">Порядок системы.</param>
        /// <returns></returns>
        public static double[] GaussSystem(double[,] a, double[] b, int n)
        {
            if (a.Length < 4 || b.Length < 1|| n<1)
                return null;
            double[] x = new double[n],c = new double[n];
            // прямой ход метода Гаусса (т.е. приведение системы к треугольному виду)
            for (int k = 0; k < n - 1; k++)
                for (int i = k + 1; i < n; i++)
                {
                    c[i - 1] = a[i, k] / a[k, k];
                    b[i] = b[i] - c[i - 1] * b[k];

                    for (int j = k; j < n; j++)
                        a[i, j] = a[i, j] - c[i - 1] * a[k, j];
                }
            // обратный ход метода Гаусса
            x[n-1]= b[n-1] / a[n-1, n-1];
            for (int i = n - 2; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                    sum = sum + a[i, j] * x[j];
                x[i] = (b[i] - sum) / a[i, i];
            }
            return x;
        }
        /// <summary>
        /// Метод Гауса-Зейделя.
        /// </summary>
        /// <param name="a">Матрица коэф.</param>
        /// <param name="b">Вектор коэф.</param>
        /// <param name="x">Произвольное начальное приближение к решению системы.</param>
        /// <param name="n">Порядок системы.</param>
        /// <param name="eps">Точность.</param>
        /// <returns></returns>
        public static double[] Zeidel(double[,] a, double[] b, double[] x, int n, double eps)
        {
            double[] x1 = new double[n];// — последующее приближение к точному решению системы
            double[] x0 = new double[n];//— предыдущее приближение к точному решению системы
            bool f;

            // поиск первого и второго приближения к решению системы линейных уравнений
            for (int i = 0; i < n; i++)
            {
                x0[i] = 0; x1[i] = 0;
                for (int j = 0; j < n; j++)
                    if ((i < j) && (i != j))
                        x0[i] = x0[i] - a[i, j] * x[j];
                    else if ((i > j) && (i <> j))
                        x0[i] = x0[i] - a[i, j] * x1[j];

                x1[i] = 1 / a[i, i] * (b[i] + x0[i]);
            }
            f = false;
            for (int i = 0; i < n; i++)
                // проверка условия выхода
                f = (Math.Abs(x1[i] - x[i]) > eps);
            for (int k = 0; f; k++)//f == true
            {
                for (int j = 0; j < n; j++)
                    x[j] = x1[j];
                for (int i = 0; i < n; i++)
                {
                    x0[i] = 0; x1[i] = 0;
                    for (int j = 0; j < n; j++)
                        if ((i < j) && (i != j)) x0[i] = x0[i] - a[i, j] * x[j];
                        else if ((i > j) && (i != j)) x0[i] = x0[i] - a[i, j] * x1[j];
                    x1[i] = 1 / a[i, i] * (b[i] + x0[i]);
                }
                f = false;
                for (int z = 0; z < n; z++)
                    f = (Math.Abs(x1[z] - x[z]) > eps);
            }


            return x1;
        }
    }
}
