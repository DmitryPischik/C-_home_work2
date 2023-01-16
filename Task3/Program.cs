// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine() ?? "0");

string response = "";
switch (quarter)
{
    case 1:
        response = "X - множество всех отрицательных чисел; Y - множество всех положительных чисел";
        break;
    case 2:
        response = "X - множество всех положительных чисел; Y - множество всех положительных чисел";
        break;
    case 3:
        response = "X - множество всех положительных чисел; Y - множество всех отрицательных чисел";
        break;
    case 4:
        response = "X - множество всех отрицательных чисел; Y - множество всех отрицательных чисел";
        break;
    default:
        response = "Такой четверти не существует";
        break;
}

Console.WriteLine(response);
