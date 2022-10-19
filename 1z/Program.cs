// Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");
//y=k1*x+b1+k2*x+b2??
//instead x (b2-b1:k1-k2)
//x=b2-b1 :k1-k2
double x = (b2-b1)/(k1-k2);
double y = k1*((b2-b1)/(k1-k2))+b1;

Console.Write($"Прямые пересекаются в точке с координатами ({x}, {y})");