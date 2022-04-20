//принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число:   ");


int N = Convert.ToInt32(Console.ReadLine());
int n = 0;
Console.WriteLine($"Чётные числа из диапазона от 1 до {N}:");
        while (n < N)
            {
                n++;
        if  
                (n % 2 == 0) 
        Console.Write($"{n} ");
            }