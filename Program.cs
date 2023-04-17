// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
 void func_cub (int number)
    {
        int result = number*number*number;
        Console.Write(result );
    }

Console.Write("Ведите число ");
int number1 = int.Parse(Console.ReadLine()!);
int count = 1; 
while (count < number1)
    {
    func_cub(count); 
    Console.Write(", ");
    count++;
    }
func_cub(number1);
