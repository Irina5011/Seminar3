//  Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

double Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

double x1 = Prompt("Введите A(x) => ");
double y1 = Prompt("Введите A(y) =>");
double z1 = Prompt("Введите A(z) =>");

double x2 = Prompt("Введите B(x) => ");
double y2 = Prompt("Введите B(y) =>");
double z2 = Prompt("Введите B(z) =>");

double x3 = x1 - x2;
double y3 = y1 - y2;
double z3 = z1 - z2;

double d = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow (y3, 2) + Math.Pow (z3, 2));

Console.WriteLine($"Расстояние между точками => {d}");