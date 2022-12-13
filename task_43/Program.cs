//43 task Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 43 task
//Console.Clear();

Console.Write("Введите k и b первой прямой: ");
string[] numberOne = Console.ReadLine().Split(" ");
double k1 = double.Parse(numberOne[0]);
double b1 = double.Parse(numberOne[1]);
Console.Write("Введите k и b второй прямой: ");
string[] numberTwo = Console.ReadLine().Split(" ");
double k2 = double.Parse(numberTwo[0]);
double b2 = double.Parse(numberTwo[1]);

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1

// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

double x = (b2 - b1) / (k1 - k2);
//double y = k1 * x + b1;


//Console.WriteLine((b2 - b1) / (k1 - k2));
Console.WriteLine ($"Х равно: "+ x);
double y = k2 * x + b1;
//Console.WriteLine(k2 * ((b2 - b1) / (k1 - k2)) + b1);
Console.WriteLine ($"Y Равен: "+ y);
