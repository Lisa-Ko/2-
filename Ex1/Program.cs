Console.WriteLine("Введите число ");
int number = int.Parse (Console.ReadLine());
string Day = "нет такого дня недели";
if (number >0 && number < 6) Day = "Рабочий день";
if (number >= 6 && number < 8) Day = "Выходной день";
Console.WriteLine(Day);