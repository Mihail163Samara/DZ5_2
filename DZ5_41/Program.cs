
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void FillArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(-1000, 1000);

    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}
void PositiveNumbers(int[] array)

{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result += 1;

    }
    System.Console.WriteLine($" Количество положительныых чисел из введённого запроса пользователем = {result} ");

}

System.Console.WriteLine("Введите количество чисел для вашего решения: ");
int num = Convert.ToInt32(System.Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
PositiveNumbers(array);