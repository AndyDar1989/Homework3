/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double DistanceIn3D(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Sqrt((xc1 - xc2) * (xc1 - xc2) + (yc1 - yc2) * (yc1 - yc2) + (zc1 - zc2) * (zc1 - zc2));
}

Console.Write("Enter xA-coordinate: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter yA-coordinate: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter zA-coordinate: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter xB-coordinate: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter yB-coordinate: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter zB-coordinate: ");
int zb = Convert.ToInt32(Console.ReadLine());
double distance = DistanceIn3D(xa, ya, za, xb, yb, zb);
Console.WriteLine(Math.Round(distance, 2));
