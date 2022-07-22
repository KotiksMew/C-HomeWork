// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива ");
int a=Convert.ToInt32(Console.ReadLine());
double[] array= new double [a];
for(int i =0; i<array.Length; i++){
    array[i]=new Random().NextDouble()*100;}
Console.WriteLine("["+string.Join(", ",array)+"]");
double max= array[0];
double min= array[0];
for(int i =0; i<array.Length; i++){
    if(max<array[i])max=array[i];
    if(min>array[i])min=array[i];
}
Console.WriteLine("Разница максимальным и минимальным элементов массива = "+(max-min));