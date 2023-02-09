// Задать массив из 12 элементов заполненых от 0 до 9 . Найти
// сумму положительных и отрицательных
System.Console.WriteLine();
int num = 12;
int sumPlus = 0;
int sumNeg = 0;

int[] arr = new int[12];
    for (int i = 0; i < num; i++)
    {
       arr[i] = new Random().Next(-10, 10);
    }

for (int i = 0; i < num; i++)
System.Console.Write($" {arr[i]} |");

for (int i = 0; i < num; i++)
    {
       if (arr[i] > 0) sumPlus = sumPlus + arr[i];
       else            sumNeg = sumNeg + arr[i];
    }

System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных чисел равна:   {sumPlus}");
System.Console.WriteLine($"Сумма положительных чисел равна:   {sumNeg}");