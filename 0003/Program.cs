// Написать программу замену элементов массива на противоположные
//Console.Clear;

int num = 10;


int[] arr = new int[10];
    for (int i = 0; i < num; i++)
    {
       arr[i] = new Random().Next(-10, 10);
    }

for (int i = 0; i < num; i++)
System.Console.Write($" {arr[i]} |\t");

for (int i = 0; i < num; i++)
    {
       arr[i] = arr[i] * -1;
    }

System.Console.WriteLine();

for (int i = 0; i < num; i++)
System.Console.Write($" {arr[i]} |\t");