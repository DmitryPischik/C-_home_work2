// Найти расстояние между точками в пространстве 2D/3D

double distance_2D(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return distance;
}

double distance_3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return distance;
}


Console.WriteLine("Хотите найти растояние между двух точек в пространстве 2D или 3D?");
Console.Write("Если в 2D, то введите 1, если в 3D, то введите 2: ");
int choose = int.Parse(Console.ReadLine() ?? "0");
// while (choose != 1 || choose != 2)
// {
//     Console.Write("Если в 2D, то введите 1, если в 3D, то введите 2: ");
//     choose = int.Parse(Console.ReadLine() ?? "0");
// }

if (choose == 1)
{
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());    
    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(distance_2D(x1, y1, x2, y2));
}
else
{
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());    
    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());    
    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());    
    Console.Write("Введите координаты z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(distance_3D(x1, y1, z1, x2, y2, z2));
}
