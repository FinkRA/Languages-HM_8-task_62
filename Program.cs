// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введитче число рядов: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int colCount = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[rowCount, colCount];

int iMin = 0;
int iMax = rowCount - 1;
int jMin = 0;
int jMax = colCount - 1;
int num = 1;
int value = 1;
int decimalLength = value.ToString("D").Length + 2;
for (int c = 0; c < colCount / 2 + 1; c++)
{
    // Первая проходка
    for (int j = jMin; j <= jMax; j++, num++)
    {
        table[iMin, j] = num;
    }
    iMin = iMin + 1;

    // Вторая проходка
    for (int i = iMin; i <= iMax; i++, num++)
    {
        table[i, jMax] = num;
    }
    jMax = jMax - 1;

    // Третья проходка
    for (int j = jMax; j >= jMin; j--, num++)
    {
            table[iMax, j] = num;
    }
    iMax = iMax - 1;

    // Четвертая проходка
    for (int i = iMax; i >= iMin; i--, num++)
    {
        table[i, jMin] = num;
    }
    jMin = jMin + 1;
}

// Печать матрицы
for (int a = 0; a < rowCount; a++)
{
    for (int b = 0; b < colCount; b++)
    {
        Console.Write(table[a, b].ToString("D" + decimalLength.ToString()) + " ");
    }
    Console.WriteLine();
}