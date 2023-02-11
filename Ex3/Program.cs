Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string answer = "нет четверти соответствующей данному числу";
if (number == 1) answer = "x > 0; y > 0";
if (number == 2) answer = "x < 0; y > 0";
if (number == 3) answer = "x > 0; y < 0";
if (number == 4) answer ="x < 0; y < 0";
Console.WriteLine(answer);