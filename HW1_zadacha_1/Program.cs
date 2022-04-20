// принимает два числа и выдаёт, какое число большее, а какое меньшее.
       
int a, b;
 
Console.WriteLine("Введите два числа : ");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
 
    if (a > b)
        {
            Console.WriteLine($"наибольшее число {a}");
            Console.WriteLine($"наименьшее число {b}");
        }
    else
        {
            Console.WriteLine($"наибольшее число {b}");
            Console.WriteLine($"наименьшее число {a}");
        }
 
        
