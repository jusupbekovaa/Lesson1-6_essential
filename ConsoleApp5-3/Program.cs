using System;

namespace ConsoleApp5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, que = 1;
            Console.WriteLine("Введи размер матрицы NxM");
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            MyMatrix matrix = new MyMatrix(N, M);//Создали матрицу

            Console.WriteLine("Заполни матрицу");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            while (que != 0)
            {
                Console.WriteLine("Введите цифру для продолжения:");
                string er = Console.ReadLine();
                que = Convert.ToInt32(er);
                switch (que)
                {
                    case 1:
                        {
                            Console.WriteLine("------Матрица------");
                            matrix.Print();//Вывод матрицы
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("------Подматрица------");
                            Console.WriteLine("Введите координаты подматрицы");
                            break;
                        }
                }
            }
            Console.ReadLine();

        }
    }
}
