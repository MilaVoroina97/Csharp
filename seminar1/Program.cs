
//Console.WriteLine("Введите число:");
//int x = int.Parse(Console.ReadLine()); // Convert.ToInt32(Console.Readline())
//Console.WriteLine("Квадрат числа равен: "+ x * x);

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//Console.WriteLine("Введите первое число:");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int y = Convert.ToInt32(Console.ReadLine());
//if (x*x == y )
//{
    //Console.WriteLine("Yes");
//}
//else
//{
    //Console.WriteLine("No");
//}

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

//Console.Write ("Введите целое число ");
//int x = Convert.ToInt32( Console.ReadLine()  );
//for (int i = -x; i<=x; i++) // i = -x : стартовая позиция счетчика,  i<=x -  конечная точка, i++ - изменение счетчика на каждом шаге
//Console.Write(i+", ");


//Console.Write ("Введите целое число ");
//int x = Convert.ToInt32( Console.ReadLine()); 
//int y = -x; 
//while (y <= x) 
//{
    //Console.Write(y + ",");
    //y = y + 1;
//}

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

//Console.Write("Введите целое трёхзначное число ");
//int x = Convert.ToInt32(Console.ReadLine());
//if (x >=10) and (x < 100)
//{
   // Console.WriteLine(x%10);
//}
//else 
//{
    //Console.WriteLine("Enter another number");
//}

///Console.Write ("Введите целое трёхзначное число ");
//string x = Console.ReadLine()  ;
//Console.Write(x[2]);

//Console.Write("Введите целое трёхзначное число ");
//int x = Convert.ToInt32(Console.ReadLine());
//if ( x>= 10 && x < 1000)
//{
   //Console.WriteLine( x%10 );
//}
//else 
//{
    //Console.WriteLine("Enter another number");
//}

// Вводится любое число. После ввода должно вывестись второе число слева направа, например : 4123 - 1, 583 - 8
//Console.WriteLine("Введите целое  число: ");
//string x = Console.ReadLine();
//int n = x.Length;
//for (int i = 0 ; i < n; i++)

Console.WriteLine("Введите целое  число: ");
string x = Console.ReadLine();

var result = x.Skip(1).Take(1).FirstOrDefault();
Console.Write(result); // => 1



//Console.WriteLine("Введите целое  число: ");
//string x = Console.ReadLine(); 534644
//int sr = int.Parse(x);
//string n = x.Substring(1,1); # диапозон обрезки индекс начала обрезки и длину вырезаемой части строки.
//if (sr > 9) Console.WriteLine(n);
//else Console.WriteLine("enter another number");