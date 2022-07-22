// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
int m =new Random().Next(3,10);
int count=0;
Console.WriteLine("Введите "+m+" целых числа");
for(int i=0;i<=m;i++){
    int a=Convert.ToInt32(Console.ReadLine());
    if(a>0) count++;
}
Console.WriteLine("Пользователь ввел "+count+" чисел больше нуля");
