using MatrixLib;
using System;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

namespace MatrixLib
{
    public class Matrix : ICloneable
    {
        //private readonly uint _rows;
        //private readonly uint _columns;


        private double[,] elements;


        public uint Rows
        {
            get
            {
                return Convert.ToUInt32(elements.GetUpperBound(0)) + 1;
            }
        }

        public uint Columns
        {
            get
            {
                return Convert.ToUInt32(elements.GetUpperBound(1)) + 1;
            }
        }

        //public readonly uint Rows;
        //public readonly uint Columns;



        public Matrix(uint rows, uint columns)
        {
            //Rows = rows;
            //Columns = columns;
            elements = new double[rows, columns];
            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
                {
                    elements[i, j] = 0;
                }
            }

        }

        public Matrix(Matrix matrix)
        {
            //Rows = matrix.Rows;
            //Columns = matrix.Columns;
            elements = new double[matrix.Rows, matrix.Columns];
            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
                {
                    elements[i,j] = matrix.elements[i,j];
                }
            }
        }

        public double this[uint row, uint column]
        {
            get
            {
                return elements[row, column];
            }
            set
            { 
                elements[row, column] = value;
            }
        }

        public override string ToString()
        {
            return $"\n Строки: {Rows}" +
                $"\n Столбцы: {Columns}" +
                $"\n Количество элементов: {Rows * Columns}";

        }

        public string ToString(int n)
        {
            if (n > Rows*Columns)
            {
                throw new Exception("Нельзя вывести больше элементов, чем в матрице");
            }
            string str = "";
            int counter = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    str += $"{elements[i,j]} ";
                    if (counter == n)
                    {
                        return str;
                    }
                    counter++;
                }
            }
            return "Ошибка";
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
            {
                throw new Exception("Матрицы нельзя сложить");
            }
            Matrix matrix = new Matrix(left.Rows, left.Columns);
            for (uint i = 0; i < left.Rows; i++)
            {
                for (uint j = 0; j < left.Columns; j++)
                {
                    matrix[i, j] = left[i, j] + right[i, j];
                }
            }
            return matrix;
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
            {
                throw new Exception("Матрицы нельзя вычесть");
            }
            Matrix matrix = new Matrix(left.Rows, left.Columns);
            for (uint i = 0; i < left.Rows; i++)
            {
                for (uint j = 0; j < left.Columns; j++)
                {
                    matrix[i, j] = left[i, j] - right[i, j];
                }
            }
            return matrix;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Columns != right.Rows)
            {
                throw new Exception("Матрицы нельзя умножить");
            }
            Matrix matrix = new Matrix(left.Rows, left.Columns);
            for (uint i = 0; i < left.Rows; i++)
            {
                for (uint j = 0; j < right.Columns; j++)
                {
                    for (uint k = 0; k < left.Columns; k++)
                    {
                        matrix[i, j] += left[i, k] * right[k, j];
                    }
                }
            }
            return matrix;
        }

        public object Clone()
        {
            return new Matrix(this);
        }
    }
    
}

