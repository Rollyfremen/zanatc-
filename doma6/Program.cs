
//Задача 41

// Console.Write("Введите числа через пробел");
// int[] gor = gop(Console.ReadLine());
// Console.WriteLine($"Ккол-во числе больше 0 {Pos}");
// Console.WriteLine();


// int [] gop(string array)
// {
//    string[] numb = array.Split('',StringSplitOptions.RemoveEmptyEntries);
//    int[] ret = new int [array.Length];
//    for (int i = 0 ; i < ret.Length; i++)
//    {
//       ret[i]= int.Parse(numb[i]);
//    }
//    return ret;
// }


// int Pos(int[] arrayS)
// {
//    int count = 0;
//    foreach( var it in arrayS )
//    {
//    if(it>0) count++;
//    }
//    return count;
// }


//Задача 43

// Console.WriteLine("Введите через пробел b1 k1 b2 k2");
// string [] q = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// double b1 = double.Parse(q[0]);
// double k1 = double.Parse(q[1]);
// double b2 = double.Parse(q[2]);
// double k2 = double.Parse(q[3]);

// Console.WriteLine(String.Join(" ",Posi(b1,k1,b2,k2)));

// double[] Posi(double geB1, double geK1, double geB2, double geK2)
// {
//    double[] rus= new double[2];
//    rus[0] = (geB2-geB1)/(geK1-geK2);
//    rus[1] = geK1 * rus[0] + geB1;
//    return rus;
// }