string[] CreatArray(int size)
{
    string[] array = new string[size];
    Console.WriteLine("Enter an array of strings: ");
    for(int i = 0; i < size; i++)
        array[i] = Console.ReadLine(); //выдает ошибку "Возможно, назначение-ссылка, допускающее значение NULL" - как это исправить не нашла ответа. 
    return array;
}

string[] FilteredArray(string[] array)
{
    int j = 0;
    string[] MyArray = new string[array.Length];
    
    for(int i = 0; i < array.Length; i++)
       if(array[i].Length <= 3)
        {
            MyArray[j] = array[i];
            j++;
        }
    Array.Resize(ref MyArray, j);
    return MyArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    } 
    Console.WriteLine("]");
}

Console.Write("Enter the number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = CreatArray(n);
PrintArray(array);
string[] MyArray = FilteredArray(array);
PrintArray(MyArray);
