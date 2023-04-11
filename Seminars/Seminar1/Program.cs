// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = x * x;
// Console.WriteLine($"Квадрат {x} -> {y}"); // Знак $ для правильного писания

// 1. Напишите программу кот.на вход принимает два числа и прверяет, является ли первое число квадратом второго
// a=25; b=5;
// a=2; b=10;
// a=9; b=3; 
// a=3; b=-9;

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int quad = b*b;
// if (quad == a)
// {
//   Console.WriteLine($"{a} является квадратом {b}"); 
// }
// else
// {
//   Console.WriteLine($"{a} не является квадратом {b}"); 
// }


//2. На вход принимает одно число (n), а на выходе показывает все целые числа в промежутке от -n до n.
// 4 < -4, -3, -2, -1, 0, 1, 2, 3, 4

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = -n; i <= n; i ++)
// {
//     Console.WriteLine(i); 
// }


//3. На вход трехзначное число и на выходе показывает последнюю циру этого числа
// 456 -> 6
// 782 -> 2

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n%10);




