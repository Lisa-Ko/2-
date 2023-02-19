using System.Drawing;
void FindPoint2D (double Point)
{   Point point2D1 = new Point();
    Console.WriteLine("Введите координаты первой точки");
    point2D1.X=int.Parse(Console.ReadLine()!);
    point2D1.Y = int.Parse(Console.ReadLine()!);
    Console.WriteLine(point2D1);
    Console.WriteLine("Введите координаты второй точки");
    Point point2D2 = new Point();
    point2D2.X=int.Parse(Console.ReadLine()!);
    point2D2.Y = int.Parse(Console.ReadLine()!);
    Console.WriteLine(point2D2);
    double answer = Math.Sqrt(Math.Pow(point2D2.X - point2D1.X, 2) + Math.Pow(point2D2.Y - point2D1.Y, 2));
    Console.WriteLine(answer);
}
void FindPoint3D (int arg)
{
    Console.WriteLine("Введите координаты первой точки");
    int point3D1X = int.Parse(Console.ReadLine()!);
    int point3D1Y = int.Parse(Console.ReadLine()!);
    int point3D1Z = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"X={point3D1X},Y={point3D1Y},Z={point3D1Z}");
    Console.WriteLine("Введите координаты второй точки");
    int point3D2X = int.Parse(Console.ReadLine()!);
    int point3D2Y = int.Parse(Console.ReadLine()!);
    int point3D2Z = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"X={point3D2X},Y={point3D2Y},Z={point3D2Z}");
    double answer = Math.Sqrt(Math.Pow(point3D2X - point3D1X, 2) + Math.Pow(point3D2Y - point3D1Y, 2)+ Math.Pow(point3D2Z - point3D1Z, 2));
    Console.WriteLine(answer);
}
Console.WriteLine("Введите в каком пространстве вы хотите работать (двумерное или трехмерное)");
string plane = Console.ReadLine()!;
int answer = new int();
if (plane.ToLower() == "двумерное")
{FindPoint2D (answer);}
else if (plane.ToLower() == "трехмерное") {FindPoint3D (answer);}
else {Console.WriteLine("Вы совершили ошибку при выборе пространства");}
