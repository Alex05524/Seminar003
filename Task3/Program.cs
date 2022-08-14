// 3 - 1, 8, 27
// 5 - 1, 8, 27, 64, 125

Console.Write("Число: ");
int a = Convert.ToInt32(Console.ReadLine());

void table(int[] a)
{
  int count = 0;
  int Length = a.Length;

  while(count < Length)
  {
    a[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArray(int[] collections)
{
  int count = collections.Length;
  int i = 1;
  while(i < count)
  {
    Console.Write(collections[i] + " ");
    i++;
  }
}

int[] array = new int[a + 1];
table(array);
PrintArray(array);