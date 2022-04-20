// принимает на вход три числа и выдаёт максимальное из этих чисел
       
 int n1, n2, n3;
 
Console.WriteLine("Введите три числа : ");

n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());
n3 = Convert.ToInt32(Console.ReadLine());
int max = n1; 
        if (n2 > n1) 
            {
                max = n2;
            }
        else
            {
                max = n1;
             }
        if (n3 > n2)
            {
               max = n3;
            }
        else
            {
                max = n2;
            }
        if (n3 > n1)
            {
                max = n3;
            }
        else
            {
                max = n1;
            }
     
Console.WriteLine($" наибольшее число {max}");

    