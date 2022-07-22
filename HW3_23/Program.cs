// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число больше 0");
double N=Convert.ToDouble(Console.ReadLine());
if (N<1){
    Console.WriteLine("Введите целое число больше 0");
}
else {for(int i=1; i<=N; i++){
    Console.Write(i*i*i+" ");
}}
