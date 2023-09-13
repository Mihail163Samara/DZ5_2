
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositiveNumbers()
{
    int countPositiveNum = 0;
    string? NumbersRow = Console.ReadLine();
    string number = "";
    for (int i=0; i < NumbersRow.Length; i++)
    {
        string currenti = NumbersRow[i].ToString();
        if ( currenti == " " || currenti == ",")
            {   
                if (number == "")
                    number = "0";
                if (Convert.ToInt32(number)>0)
                    countPositiveNum += 1;
                number = "";
            }
        else
            {
               number += currenti;
               if(i == NumbersRow.Length-1)
                    {
                    if (Convert.ToInt32(number)>0)
                        countPositiveNum += 1;
                    }
            }
    }
    return countPositiveNum;
}
System.Console.WriteLine("Введите ряд целых чисел: ");
int countPos = CountPositiveNumbers();
System.Console.WriteLine($"Количество чисел больше нуля в данном ряду: {countPos}"); 


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");