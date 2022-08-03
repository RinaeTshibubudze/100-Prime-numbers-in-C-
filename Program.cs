// 

Console.WriteLine("First 100 prime numbers: ");

static bool IsPrime(int input)
{
    bool output = true;

    for (int i = 2; i < input; i++)
    {
        if (input % i == 0)
        {
             output = false;
             break;
        }

    }
    if (input <= 1)
        output = false;

    return output;
}


for (int i = 0, list = 0; list < 100; i++ )
{
    if (IsPrime(i))
    {
        Console.WriteLine("{0} -> {1}", ++list, i);
    }
} 

