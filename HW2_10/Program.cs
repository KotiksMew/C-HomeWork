// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int n=Convert.ToInt32(Console.ReadLine());
if (n>999||n<100){
Console.WriteLine("Число не трезначное");
}
else{Console.WriteLine(Convert.ToString(n)[2]);
}