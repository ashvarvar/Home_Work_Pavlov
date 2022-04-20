//принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int n1;   
Console.WriteLine("Введите число : ");

n1 = Convert.ToInt32(Console.ReadLine());
    if (n1 % 2 == 0) 
        {
            Console.WriteLine("число чётное");
        }
    else 
        {
            Console.WriteLine("число нечётное");
        }    
     
