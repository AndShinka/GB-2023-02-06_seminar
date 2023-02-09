// Задать массив из 8 элементов и вывести их на экран
int num = 8;
int[] arr = new int[8];
    for (int i = 0; i < num; i++)
    {
       arr[i] = new Random().Next(1, 100);
    }

    for (int i = 0; i < num; i++)
        System.Console.Write($" {arr[i]} |");


