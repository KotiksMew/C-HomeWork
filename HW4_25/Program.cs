// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите  целое число ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возвести? Введите  целое число ");
int b=Convert.ToInt32(Console.ReadLine());
int c=1;
if(a==0){
        Console.WriteLine("0 в любой степени 0");
        }
else{ 
    for(int i=1;i<=b;i++){
    c*=a;
    }
    Console.WriteLine("число "+a+" В степени "+b+" равно "+c);
    }
