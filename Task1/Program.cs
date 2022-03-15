//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число =>");  // вывод пргилашения для ввода
string strvalue = Console.ReadLine();   // ввод строки

int value = int.Parse(strvalue);        // преобразуем строку в целое число

if (value > 99999 || value < 10000) Console.WriteLine("не корректное число"); // проверка на 5 значность

int A = value % 10; // возьмем 12321 = 1
int B = value / 10; // 1232
int C = B % 10; // 2
int D = B / 100; // 12
int E = D % 10; // 2
int F = value / 10000; //1

if (F == A & E == C) Console.WriteLine("- Это палиндром ");
else Console.WriteLine("Это не палиндром");
