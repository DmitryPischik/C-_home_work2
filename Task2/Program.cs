// По двум заданным числам проверять является ли одно квадратом другого

string is_sqrt(int number1, int number2)
{
    string response = "";
    if (number1 == number2 * number2) response = "Число " + number1 + " является квадратом числа " + number2;
    else if (number2 == number1 * number1 ) response = "Число " + number2 + " является квадратом числа " + number1;
    else response = "Ни одно из чисел не является квадратом другого";
    return response;
}


Console.Write("Введите первое число: ");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int x2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(is_sqrt(x1, x2));
