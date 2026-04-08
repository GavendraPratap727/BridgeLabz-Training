using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
     class Matrix
  
    {
        static void Main()
        {
            double[,] a = makeMatrix(2, 2);
            double[,] b = makeMatrix(2, 2);

            Console.WriteLine("Matrix A");
            show(a);
            Console.WriteLine("Matrix B");
            show(b);

            Console.WriteLine("Addition");
            show(add(a, b));

            Console.WriteLine("Subtraction");
            show(sub(a, b));

            Console.WriteLine("Multiplication");
            show(mul(a, b));

            Console.WriteLine("Transpose of A");
            show(trans(a));

            Console.WriteLine("Determinant of A");
            Console.WriteLine(det2(a));

            Console.WriteLine("Inverse of A");
            double[,] inv2 = inv2x2(a);
            if (inv2 != null) show(inv2);

            double[,] c = makeMatrix(3, 3);
            Console.WriteLine("Matrix 3x3");
            show(c);

            Console.WriteLine("Determinant of 3x3");
            Console.WriteLine(det3(c));

            Console.WriteLine("Inverse of 3x3");
            double[,] inv3 = inv3x3(c);
            if (inv3 != null) show(inv3);
        }

        static double[,] makeMatrix(int r, int c)
        {
            double[,] m = new double[r, c];
            Random rd = new Random();
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    m[i, j] = rd.Next(1, 10);
            return m;
        }

        static double[,] add(double[,] a, double[,] b)
        {
            double[,] r = new double[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    r[i, j] = a[i, j] + b[i, j];
            return r;
        }

        static double[,] sub(double[,] a, double[,] b)
        {
            double[,] r = new double[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    r[i, j] = a[i, j] - b[i, j];
            return r;
        }

        static double[,] mul(double[,] a, double[,] b)
        {
            double[,] r = new double[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        r[i, j] += a[i, k] * b[k, j];
            return r;
        }

        static double[,] trans(double[,] m)
        {
            double[,] t = new double[m.GetLength(1), m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    t[j, i] = m[i, j];
            return t;
        }

        static double det2(double[,] m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }

        static double det3(double[,] m)
        {
            return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
                 - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
                 + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        static double[,] inv2x2(double[,] m)
        {
            double d = det2(m);
            if (d == 0) return null;
            double[,] r = new double[2, 2];
            r[0, 0] = m[1, 1] / d;
            r[0, 1] = -m[0, 1] / d;
            r[1, 0] = -m[1, 0] / d;
            r[1, 1] = m[0, 0] / d;
            return r;
        }

        static double[,] inv3x3(double[,] m)
        {
            double d = det3(m);
            if (d == 0) return null;
            double[,] r = new double[3, 3];
            r[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / d;
            r[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / d;
            r[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / d;
            r[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / d;
            r[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / d;
            r[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / d;
            r[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / d;
            r[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / d;
            r[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / d;
            return r;
        }

        static void show(double[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}
