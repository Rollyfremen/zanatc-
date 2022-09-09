// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// while(M<=N)
// {
//     if(M<N)
//     {
//     Console.Write($"{M},");
//     M++;
//     }
//     else
//     {
//         Console.Write(M);
//         M++;
//     }
    
// }



//вторая задача 



// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int s = 0;
// for (int i = M; i <= N; i++)
// {
//     s += i;
// }
// Console.WriteLine(s);




// третья задача 


int n = 2;
int m = 3;
Console.Write(recursion(m, n));



int recursion(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0)
        {
            return recursion(m - 1, 1);
        } 
        else
        {
            return recursion(m - 1, recursion(m, n - 1));
        }
    }