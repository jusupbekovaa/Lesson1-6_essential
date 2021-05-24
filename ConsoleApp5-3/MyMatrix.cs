using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5_3
{
    public class MyMatrix
    {
        int[,] matrix;
        int row, column;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Column
        {
            get { return column; }
            set { column = value; }
        }
        public MyMatrix()
        {

        }
        public MyMatrix(int row, int column)
        {
            this.row = row;
            this.column = column;
            matrix = new int[row, column];
        }
        public int this[int x, int y]
        {

            set
            {
                if (Row >= x && Column >= y && x >= 0 && y >= 0)
                {
                    matrix[x, y] = value;
                }
                else
                {
                    Console.WriteLine("Неверно задан номер ячейки");
                    matrix[x, y] = 0;
                }

            }
            get
            {
                if (Row >= x && Column >= y && x >= 0 && y >= 0)
                {
                    return matrix[x, y];
                }
                else
                {
                    Console.WriteLine("Неверно задан номер ячейки");
                    return 0;
                }
            }

        }
        public void Print()
        {
            for (int i = 0; i < Row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }
            }
        }
       
        
    }
}
