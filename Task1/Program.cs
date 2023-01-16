// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

string is_weekend(int day_number)
{
    string response = "";
    if (day_number == 6 || day_number == 7) response = "День недели с этим номером - выходной";
    else if (day_number < 0 || day_number > 7 ) response = "Нет дня недели с таким номером";
    else response = "День недели с этим номером - невыходной";
    return response;
}

Console.Write("Введите номер недели: ");
int x = int.Parse(Console.ReadLine() ?? "0");
 Console.WriteLine(is_weekend(x));
