// Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу кубов чисел от 1 до N.

double Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

double N = Prompt("Введите Число => ");

if (N < 0) Console.WriteLine ("Число меньше нуля"); // отсекаем отрицательные числа

int A = 0;

while(A < N)
{
    A++;
    Console.WriteLine(A*A*A + " ");

}
