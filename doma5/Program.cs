int[] array = new int[10];
int count= 0;
for(int i = 0 ; i <  array.Length; i++)
{
  array[i]= new Random().Next(100,1000);
  Console.WriteLine(array[i]);
  if(array[i] % 2 == 0)
  {
      count = count+ 1;
  }
}
Console.WriteLine("Колличество четных чисел "+count);