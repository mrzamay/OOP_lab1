using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab15
{
    public class lab
    {
        static public double lab11(double a, double b, double c, double p)
        {
            double answer = Math.Exp((p * (p - a) * (p - b) * (p - c)) / (a));
            return Math.Round(answer, 2);
        }

        static public void writeArray(int[,] array, int n)
        {
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write("{0}\t", array[a, b]);
                }
                Console.WriteLine();
            }
        }

        static public string lab12(int a, int b, int c)
        {
            int d;
            d = ((a + b + c) / 3);
            string grade = "";
            if (d >= 90) { grade = "Е+"; }
            else if (d >= 80 || d < 90) { grade = "Е"; }
            else if (d >= 70 || d < 80) { grade = "A+"; }
            else if (d >= 60 || d < 70) { grade = "A"; }
            else if (d >= 50 || d < 60) { grade = "B+"; }
            else if (d < 50) { grade = "FAIL"; }
            return grade;
        }

        static public double[,] lab13(double xn, double xk)
        {
            double[,] z = new double[11, 3];
            double h, x, sum = 0;
            int n, counter = 0 ,N = 10;

            h = (xk - xn) / 10;

            for (x = xn; x <= xk; x += h)
            {
                double doubleX = 1;
                double x2 = 2 * x;
                 sum = 1;
                int f = 1;
                for (n = 1; n <= N; n++)
                {
                    f *= n;
                    doubleX *= x2;
                    sum += doubleX / f;
                }
               z[counter,0] = Math.Round(x, 2);
               z[counter,1] = Math.Round(Math.Exp(2 * x), 4);
               z[counter,2] = Math.Round(sum, 4);
               counter++;
            }
            return z;
        }

        static public int[,] lab14(int[,] a, int n)
        {
            int[,] b = new int[n - 1, n - 1];

            int globalMax = a[0, 0];
            int zCord = 0, xCord = 0;

            for (int z = 0; z < n; z++)
            {
                  for (int x = 0; x < n; x++)
                  {
                    if (globalMax < a[z, x])
                        {
                            globalMax = a[z, x];
                            zCord = z;
                            xCord = x;
                        }
                    }
                }

                for (int z = 0; z < n - 1; z++)
                {
                    for (int x = 0; x < n - 1; x++)
                    {
                        if (xCord <= x)
                        {
                            b[z, x] = a[z, x + 1];
                        }
                        else if (zCord <= z)
                        {
                            b[z, x] = a[z + 1, x];
                        }
                        else if (zCord <= z && xCord <= x)
                        {
                            b[z, x] = a[z + 1, x + 1];
                        }
                        else if (zCord > z && xCord > x)
                        {
                            b[z, x] = a[z, x];
                        }
                    }

                }
            return b;
            }
    }
}