/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetSumElements(int a, int b)
{
    int sum = 0;
    if (a <= b)
    {
        sum = a + GetSumElements(a + 1, b);
    }
    return sum;
}

Console.WriteLine("Введите первое число:");
int userA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int userB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов в промежутке от {userA} до {userB} равна: {GetSumElements(userA, userB)}");