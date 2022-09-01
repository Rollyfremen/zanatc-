// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//             Console.Write($"{matrix [i, j]} ");
//         }
//         Console.WriteLine();
//     }




// int[,] matrix = new int[3, 4];
// Console.WriteLine("Напишите позицию элемента");
// int poz = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// if (poz / 10 <= matrix.GetLength(0)-1 && poz % 10 <= matrix.GetLength(1)-1)
// {
//     Console.WriteLine(matrix[poz / 10, poz % 10]);
// }
// else
// {
//     Console.WriteLine("Такого Элемента нет");
// }




// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// double[] sredarf = GetRes(matrix);
// Console.WriteLine($"Среднее арефметическое каждого столбца= {String.Join("; ", sredarf)}");


// double[] GetRes(int[,] array)
// {
//     double[] res = new double[array.GetLength(1)-1];
//     for (int j = 0; j < array.GetLength(1)-1; j++)
//     {
//         double sum = 0;
//         for (int i = 0;i < array.GetLength(0)-1; i++)
//         {
//             sum += array[j, i];
//         }
//         res[j] = Math.Round(sum / array.GetLength(0)-1, 2);
//     }
//     return res;
// }
