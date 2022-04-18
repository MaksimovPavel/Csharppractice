/*
void ShowNumber ()
{
    int num = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;

    Console.Write(num + " -> ");

    if (firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}

ShowNumber();



void ReduceNumber()
{
    int num = new Random().Next(100,999);
    Console.Write(num + "->");
    int num1 = num / 100;
    int num2 = num % 10;
    int num3 = num1 * 10 + num2;

    Console.Write(num3);
}

ReduceNumber();


void IfMultiple()
{
    Console.Write("Input the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 % num1 == 0)
    {
        Console.Write(num2 + " is a multiple of " + num1);
    
    }
    else
    {
        Console.Write(num2 + " is not a multiple of " + num1);
    }
}
IfMultiple();



void Multiple(int num)
{

    if (num %7 == 0 && num %23 == 0)
    {
        Console.Write(num + " is multiple of 7 and 23");
    }
    else
    {
        Console.Write(num + "is not a multiple of 7 and 23");
        
    }
}
    Console.Write("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Multiple(num);

    */

void Sqr(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.Write ("Второе число является квадратом первого");
    }
    else
    {
        Console.Write ("Второе число не является квадратом первого");
    }
}
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Sqr(num1, num2);