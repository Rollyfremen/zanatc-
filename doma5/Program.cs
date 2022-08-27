// int[] array = new int[10];
// int count= 0;
// for(int i = 0 ; i <  array.Length; i++)
// {
//   array[i]= new Random().Next(100,1000);
//   Console.WriteLine(array[i]);
//   if(array[i] % 2 == 0)
//   {
//       count = count+ 1;
//   }
// }
// Console.WriteLine("Колличество четных чисел "+count);





// int[] array = new int[10];
// int sum = 0;
// for(int i = 0 ; i <  array.Length; i++)
// {
//   array[i]= new Random().Next(10,100);
//   Console.WriteLine(array[i]);
// }
// int index = 0;
// while(index < array.Length)
// {
//   if(index % 2 == 0 )
//   {
//      sum = sum + array[index];
//      index++;
//   }
//   else 
//   {
//    Console.WriteLine(array[index]+"Стоит на четной позиции");
//     index++;
//   }
// }
// Console.WriteLine("Сумма чисел стоящих на нечетных позициях равна "+sum);







int[] array = new int[10];
int? max = null;
int? min = null;
for(int i = 0 ; i <  array.Length; i++)
{
   array[i]= new Random().Next(1,100);
   Console.WriteLine(array[i]);
   if(max==null&&min==null)
   {
      max=array[i];
      min=max;
   }
   
  if(array[i]> max) 
  {
     max = array[i];
  }
  if( array[i] < min )
  {
    min = array[i];
  }
}
int? raz = max - min;
Console.WriteLine($"минимальное значение {min} максимальное значение {max} разница между эллементами {raz}");
