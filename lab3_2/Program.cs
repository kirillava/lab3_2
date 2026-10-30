Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double Q = 0;

for (int k = 1; k <= n; k++)
{
    double mas = 1;
    for (int i = 2; i <= n - k; i++)
        mas *= i;

    Q += Math.Pow(-1, k) * (k - 7) / (2 * mas);
}

Console.WriteLine("Q = " + Q);
