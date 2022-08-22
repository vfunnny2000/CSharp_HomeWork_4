/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int res = 1;

for(int count =1; count <= B; count++)
{
    res = res * A;
}
Console.WriteLine($"result -> {res}");