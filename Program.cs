const int AMOUNT = 38;

int[] fibonaci = new int[AMOUNT + 1];
fibonaci[0] = 0;
fibonaci[1] = 1;

for (int i = 2; i < fibonaci.Length; i++)
{
    fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
}

Console.WriteLine(fibonaci[fibonaci.Length - 1]);