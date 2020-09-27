using System;

namespace Science_Cal_1

{

    class Program

    {

        static void Main(string[] args)

        {

            //Ввод массива

            double[,] myArr = {

{16, 8, 9, 120},

{48, 74.67, 256, 4},

{16.5, 85.33, 0.947,2.773},

{259.2, 8.5, 2.667, 16 }

};

            //Фомирование вспомогательной матрицы для суммы по столбцам и строкам

            double[] ROW = { 0, 0, 0, 0 };

            double[] Table = { 0, 0, 0, 0 };

            //Формирование специальноых векторов для выделения первой строки и четвертого столбца

            double[] ROW4 = { 0, 0, 0, 0 };

            double[] ROW1 = { 0, 0, 0, 0 };

            double[] Table4 = { 0, 0, 0, 0 };

            double[] Table1 = { 0, 0, 0, 0 };

            double[,] myArrTwo = {

{16, 8, 9, 120},

{48, 74.67, 256, 4},

{16.5, 85.33, 0.947,2.773},

{259.2, 8.5, 2.667, 16 }

};

            double[,] myArrThree = {

{16, 8, 9, 120},

{48, 74.67, 256, 4},

{16.5, 85.33, 0.947,2.773},

{259.2, 8.5, 2.667, 16 }

};

            //Cумма элементов исходной матрицы по столбцам

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    Table[j] += myArr[i, j];

                }

            }

            //Сумма элементов исходной матрицы по строкам

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    ROW[i] += myArr[i, j];

                }

            }

            //Выделение первой строки исходной матрицы

            for (int i = 0; i < 1; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    ROW1[j] = myArr[i, j];

                }

            }

            //Выделение четвертой строки исходной матрицы

            for (int i = 3; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    ROW4[j] = myArr[i, j];

                }

            }

            //Выделение четвертого столбца исходной матрицы

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    if (j == 3)

                    {

                        Table4[i] = myArr[i, j];

                    }

                }

            }

            //Выделение первого столбца исходной матрицы

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    if (j == 0)

                    {

                        Table1[i] = myArr[i, j];

                    }

                }

            }

            //Перестановка первой и четвертой строки исходной матрицы

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    if (i == 3)

                    {

                        myArrTwo[i, j] = ROW1[j];

                    }

                    if (i == 0)

                    {

                        myArrTwo[i, j] = ROW4[j];

                    }

                }

            }

            //Перестановка первого и четвертого столбца
            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    if (j == 3)

                    {

                        myArrThree[i, j] = Table1[i];

                    }
                    if (j == 0)

                    {

                        myArrThree[i, j] = Table4[i];

                    }


                }

            }

            Console.WriteLine("Вид исходной матрицы");
            //Вид исходной матрицы
            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    Console.Write(myArr[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Вид исходной матрицы с измененными 1 и 4 строками ");
            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    Console.Write(myArrTwo[i, j] + "\t ");

                }

                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("Вид исходной матрицы с измененными 1 и 4 столбцами ");
            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    Console.Write(myArrThree[i, j] + "\t ");

                }

                Console.WriteLine();

            }
            Console.WriteLine();

            //Приведение исходной матрицы А к диагональному виду
            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    if (i == j)
                    {
                        myArr[i, j] = 1;
                    }
                    else
                    {
                        myArr[i, j] = 0;
                    }


                }

            }


            Console.WriteLine("Вид диагональной матрицы");
            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    Console.Write(myArr[i, j] + " ");

                }

                Console.WriteLine();

            }



            Console.ReadKey();
        }


    }

}