// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число");
int n=Convert.ToInt32(Console.ReadLine());
if(n>99999||n<10000){
    Console.WriteLine("Косяк Введи верное число");
}
else {if((Convert.ToString(n)[0])==(Convert.ToString(n)[4])&&(Convert.ToString(n)[1])==(Convert.ToString(n)[3])){
    Console.WriteLine("Это Полиндром");
}
else {Console.WriteLine("Не Полиндром");}}