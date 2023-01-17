Console.Clear();
int[]array = {12,20,39,19,56,65,73,81,19};
int n=array.Length;
int find = 19;
int index = 0;
while (index<n)
{
  if (array[index]==find)
  {
    Console.Write("Position: ");
    Console.WriteLine(index);
    break;
  }
  index++;
}