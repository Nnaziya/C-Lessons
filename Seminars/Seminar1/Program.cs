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
// int quad = b * b;
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

// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n%10);




// 4. На вход принимает два числа и выдает какое число больше, а какое меньше
// a = 5, b = 7, max = 7;
// a = 12, b = 4, max = 12

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
//  {
//    Console.WriteLine($"max -> {a}"); 
//  }
// else
//  {
//    Console.WriteLine($"max -> {b}"); 
//  }



// 5. На вход принимает три числа и выдает макс из этих чисел
// 2, 3, 7, max = 7
// 45, 1, 12, max = 45

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
//  int max = 0;
// if(a > max)
// {
//   max = a;
// }
// if(b > max)
// {
//   max = b;
// }
// if(c > max)
// {
//   max = c;
// }
// Console.WriteLine($"Максимальное число -> {max}"); 




// 6. На вход принимает число и выдает является ли число четным (делится на два)
// 4 = да
// -3 = нет

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//   Console.WriteLine($"{number} - Четное число"); 
// }
// else
// {
//   Console.WriteLine($"{number} - Нечетное число"); 
// }




// 7. На вход число (N), на выходе показывает все четные числа от 1 до N
// 5 -> 2,4
// 12 -> 2, 4, 6, 8, 10


// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = 2;
// if(x > 1)
// {
//   while (y <= x)
//     {
//         Console.Write(y + " ");
//         y = y + 2;
//     }
// }



