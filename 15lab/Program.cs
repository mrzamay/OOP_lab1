 using System;
 using lab15;


namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            double a1, b1, c1, p1;
            Console.Write("Введите значение a:\t");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b:\t");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c:\t");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение p:\t");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ на первое задание:\t" + lab.lab11(a1,b1,c1,p1));

            //Второе задание
            int a2, b2, c2;
            Console.Write("Введите значение a:\t");
            a2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите значение b:\t");
            b2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите значение c:\t");
            c2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ответ на второе задание:\t" + lab.lab12(a2, b2, c2));

            //Третье задание
            double xn, xk;
            Console.Write("Введите значение xn:\t");
            xn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение xk:\t");
            xk = Convert.ToDouble(Console.ReadLine());
            double[,] array = new double[9,1];
            array = lab.lab13(xn,xk);
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("При  x = {0}, Y(x) = {1}, S(x)={2}" , array[i,0], array[i,1], array[i,2]);
            }
        

            //Четвёртое задание
            Console.Write("Введите размерность матрицы:\t");
            int n = Convert.ToInt32(Console.ReadLine());

            int [,]a = new int[n, n];
            for (int z = 0; z < n; z++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write("Введите значение для ячейки массива a[{0},{1}]:\t", z, x);
                    a[z, x] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Ответ на четвёртое задание:\n");
            lab.writeArray(lab.lab14(a, n), n-1);
            
        }
    }
}