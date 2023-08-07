Console.Clear();
Console.Writeline("Введите число N от 1: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = "";

while (n < 1)
{
    Console.Write ("nВведите число N от 1: ");
    n = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i<=n; i++)
{
    if (i % 2 == 0)
        s = s + ($"{i } ");
} 
    Console.Writeline($"{n} -> {s} ");