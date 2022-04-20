//вход трёхзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трёхзначное число : ");


int number = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");