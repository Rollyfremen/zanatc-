// первая задача 
// int[,] matrix = new int[3,4];
// Zapolnenie(matrix);
// PrintArray(matrix);
// SortMatrix(matrix);
// PrintArray(matrix);

// void SortMatrix (int[,]array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = j+1 ; t < array.GetLength(1); t++)
//             {
//                 if(array[i,t]>array[i,j])
//                 {
//                 int temp = array[i,j];
//                 array[i,j]= array[i,t];
//                 array[i,t] = temp;
//                 }
//             }
//         }
//     }
// }
// void PrintArray(int[,]attay)
// {
// for (int i = 0; i < attay.GetLength(0); i++)
// {
//     for (int j = 0; j < attay.GetLength(1); j++)
//     {
//         Console.Write($"{attay[i, j]} ");  
//     }
//     Console.WriteLine();
// }
// }
// void Zapolnenie(int[,]array)
// {
//  for (int i = 0; i < matrix.GetLength(0); i++)
//  {
//      for (int j = 0; j < matrix.GetLength(1); j++)
//      {
//          matrix[i, j] = new Random().Next(1, 10);
//      }
// }
// }



// вторая задача 

// int[,] matrix = new int[3,4];
// Zapolnenie(matrix);
// PrintArray(matrix);

// Console.WriteLine($"Строга с наименьшей суммой - {NahoSumMin(matrix)}");





// int NahoSumMin(int[,]array)
// {
//     int ter = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum+ array[0,i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum +array[i,j];
//         }
//         if(minsum>sum)
//         {
//             minsum = sum;
//             ter = i;
//         }
//     }
//     return ter;
// }




// void PrintArray(int[,]attay)
// {
// for (int i = 0; i < attay.GetLength(0); i++)
// {
//     for (int j = 0; j < attay.GetLength(1); j++)
//     {
//         Console.Write($"{attay[i, j]} ");  
//     }
//     Console.WriteLine();
// }
// }



// void Zapolnenie(int[,]array)
// {
//  for (int i = 0; i < matrix.GetLength(0); i++)
//  {
//      for (int j = 0; j < matrix.GetLength(1); j++)
//      {
//          matrix[i, j] = new Random().Next(1, 10);
//      }
// }
// }




//третья задача


// int[,] matrix= new int [2,2];
// int [,]array = new int [2,2];
// Zapolnenie(matrix);
// Zapolnenie(array);
// PrintArray(matrix);
// Console.WriteLine();
// PrintArray(array);
// Console.WriteLine();
// PrintArray(Ymnomassi(matrix,array));



// int[,] Ymnomassi(int[,]arrayA,int[,]arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0),arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//          for (int j = 0; j < arrayB.GetLength(1); j++)
//          {
//               for (int l = 0; l < array.GetLength(1); l++)
//              {
//                  arrayC[i,j]+=arrayA[i,l]+arrayB[l,j];
//              }

//          }

//     }
//     return arrayC;

// }
// void PrintArray(int[,]attay)
// {
// for (int i = 0; i < attay.GetLength(0); i++)
// {
//     for (int j = 0; j < attay.GetLength(1); j++)
//     {
//         Console.Write($"{attay[i, j]} ");  
//     }
//     Console.WriteLine();
// }
// }


// void Zapolnenie(int[,]array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//      for (int j = 0; j < array.GetLength(1); j++)
//      {
//          array[i, j] = new Random().Next(1, 10);
//      }
// }
// }





//четвертая задача


// int[,,]matrix=new int[2,2,2];
// Zapolnenie(matrix);
// PrintArray(matrix);
// void Zapolnenie(int[,,]array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//      for (int j = 0; j < array.GetLength(1); j++)
//      {
//         int k=0;
//          while (k<array.GetLength(2))
//          {
//              int element = new Random().Next(10, 99);
//              if(FindElement(array,element))continue;
//              array[i,j,k]=element;
//              k++;
//          }
//      }
// }
// }
// bool FindElement(int[,,]array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//                   for (int k = 0; k < array.GetLength(2); k++)
//                   {
//                   if(array[i,j,k]==el)return true;
//                   }
//         }
        
//     }
//     return false;
// }

// void PrintArray(int[,,]attay)
// {
// for (int i = 0; i < attay.GetLength(0); i++)
// {
//     for (int j = 0; j < attay.GetLength(1); j++)
//     {
//         for (int k = 0; k < attay.GetLength(2); k++)
//         {
//         Console.Write($"{attay[i, j,k]} ({i},{j},{k}) "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// }





// пятая задача 

Console.Write("Введите размер матрицы  ");
int s = int.Parse(Console.ReadLine());
int[,] matrix = Zapolnenie(s);
PrintArray(matrix);





int[,] Zapolnenie (int size)
{
    int [,] res = new int [size,size];
    int i = 0;
    int j = 0;
    int rowE = size - 1 ;
    int columE = size -1 ;
    int rowS = 0;
    int columS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while(count<size*size)
    {
       count++;
       res[i,j]=count;
       if(left&&top)
       {
        if(j==columE)
        {
            rowS++;
            top=true;
            left=false;
            i++;
            continue;

        }
        else 
        {
            j++;
            continue;
        }
       }
       if(!left&&top)
       {
        if(j==rowE)
        {
            columE--;
            top=false;
            left=false;
            j--;
            continue;

        }
        else 
        {
            i++;
            continue;
        }
       }
       if(!left&&!top)
       {
        if(j==rowE)
        {
            columE--;
            top = false;
            left=true;
            i--;
            continue;
        }
        else
        {
            j--;
            continue;
        }
       }
       if(left&&!top)
       {
        if(j==rowS)
        {
            columS++;
            top=true;
            left=true;
            j++;
            continue;

        }
        else 
        {
            i--;
            continue;
        }
    }
}
return res;
}

void PrintArray(int[,]attay)
{
for (int i = 0; i < attay.GetLength(0); i++)
{
    for (int j = 0; j < attay.GetLength(1); j++)
    {
        Console.Write($"{attay[i, j]} ");  
    }
    Console.WriteLine();
}
}