//Семинар8, Задача1 Задать двумерный массив. Написать программу,
// которая упорядочит по убыванию элементы каждой строки массива.

/*void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

      Console.WriteLine();
    }
       
}

void sortRows(int[,] array)
{
    for (int i = 0;i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                if (array[i, k] < array[i, k + 1])
                {
                    int t = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = t;
                }
    }


int[,] MyArray = { {1, 2, 4},
                   {-4, 4, 2},
                   {9, 8, 0 },
                   {-13, 8, 1},
};


Show2dArray(MyArray);
Console.WriteLine("Sorted array:");
sortRows(MyArray);
Show2dArray(MyArray);
*/

//Задача2 Задать прямоугольный двумерный массив, написать программу, которая будет находить
// строку с наименьшей суммой элементов

/*void Show2dArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
void minimalSum(int[,]array)
{
    int sum, min = 1000000, row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(min > sum)
        {
            min = sum;
            row = i + 1;
        }
    }
    Console.WriteLine("The minimal sum of the elements is in the row:"+row+"");
}

int[,]MyArray = {{1,2,8},
                 {4,4,2},
                 {9,8,0},
                 {12,8,1},
                 {7,2,4}};

Show2dArray(MyArray);
minimalSum(MyArray);
*/

//Задача3 Задать две матрицы, написать программу, которая будет находить
// произведение двух матриц

/*void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

}

void MultiplyMatrix(int[,] A, int[,] B)
{
    int rA = A.GetLength(0);
    int cA = A.GetLength(1);
    int rB = B.GetLength(0);
    int cB = B.GetLength(1);

    if (cA != rB)
    {
        Console.WriteLine("Matrixes can't be multiplied!!");
    }
    else
    {
        int[,] result = new int[rA, cB];
        for (int i = 0; i < rA; i++)
            for (int j = 0; j < cB; j++)
            {
                int temp = 0;
                for (int k = 0; k < cA; k++)
                {
                    temp += A[i, k] * B[k, j];
                }
                result[i, j] = temp;
            }

        Show2dArray(result);
    }
}


int[,] x =  {{1, 2, 4},
            {3, 4, 5},
            {5, 6, 7}};

int[,] y =  {{1, 5, 2},
            {1, 5, 5},
            {5, 6, 0}};


Show2dArray(x);
Console.WriteLine("~~~~~~~~~");
Show2dArray(y);
Console.WriteLine("Multiplied array:");
MultiplyMatrix(x, y);
*/

//Задача4 Сформулируйте трехмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента
/*void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");

            Console.WriteLine();
        }
           

}

int[,,] array3D = new int[2, 2, 2]{
                { { 11, 22}, {43, 51} },
                { { 47, 48}, {10, 69} }
            };


Show3dArray(array3D);
*/

//Задача5 Написать программу, которая заполнит спирально массив 4 на 4

/*void Show2dArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

}

string ChekIfSingle(string a)
{
    if (a.Length != 2)
        return 0 + a;
    else
        return a;
}

string[,] fillHelix()
{
    string[,] helix = new string[4, 4];
    //Заполняем верхнюю строку
    for (int i = 0; i < 4; i++)
        helix[0, i] = ChekIfSingle(Convert.ToString(i+1));

    //Заполняем правую колонку
    for (int i = 1; i < 4; i++)
        helix[i, 3] = ChekIfSingle(Convert.ToString(i+4));

    //Заполняем нижнюю строку
    for (int i = 0; i < 3; i++)
        if(i == 0)
            helix[3, i] = ChekIfSingle(Convert.ToString(i + 8 + 2));
        else if(i == 1)
            helix[3, i] = ChekIfSingle(Convert.ToString(i + 8));
        else if (i == 2)
            helix[3, i] = ChekIfSingle(Convert.ToString(i + 8 - 2));

    //Заполняем левую колонку
    helix[2,0] = ChekIfSingle(Convert.ToString(11));
    helix[1, 0] = ChekIfSingle(Convert.ToString(12));
    //Заполняем верхнюю внутреннюю строчку
    helix[1, 1] = ChekIfSingle(Convert.ToString(13));
    helix[1, 2] = ChekIfSingle(Convert.ToString(14));
    //Заполняем центральную нижнюю строчку
    helix[2, 2] = ChekIfSingle(Convert.ToString(15));
    helix[2, 1] = ChekIfSingle(Convert.ToString(16));

    return helix;
}

string[,] helix = fillHelix();
Show2dArray(helix);
*/