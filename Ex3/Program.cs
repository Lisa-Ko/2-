Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("Точка в первой четверти");
else if (x < 0 && y > 0) Console.WriteLine("Точка во второй четверти");
else if (x > 0 && y < 0) Console.WriteLine("Точка в третьей четверти");
else Console.WriteLine("Точка в четвертой четверти");