
// 41 task Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for (int i = 0; i < n; i++)

{
    Console.Write("Введите число:");
    if (Convert.ToInt32(Console.ReadLine()) > 0) counter=counter+1;
}
Console.WriteLine($"Чисел больше нуля: " +counter);
