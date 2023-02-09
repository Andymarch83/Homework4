int[] array = new int[3];
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }

}
Console.Write("[");
void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while(position<count)
   {
    int result = col[position];
    string resultst = Convert.ToString(result);
      int a = resultst[0];
      Console.Write($" {a} ");
      position++;
   } 
}

FillArray(array);
PrintArray(array);
Console.Write("]");