// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты  точки A в 3D пространстве");
double ax=Convert.ToDouble(Console.ReadLine());
double ay=Convert.ToDouble(Console.ReadLine());
double az=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты  точки B в 3D пространстве");
double bx=Convert.ToDouble(Console.ReadLine());
double by=Convert.ToDouble(Console.ReadLine());
double bz=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками будет равно  "+(Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az))));
//d = sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)

