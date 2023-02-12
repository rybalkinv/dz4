int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("3. Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");
programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

 
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

break;

case 2:
//2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе."
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);



int ReadInt1(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}


void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

break;

//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
case 3:
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}



int ReadInt11(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
break;

default:
begin = false;
break;
}
}
