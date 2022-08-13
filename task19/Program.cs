/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

string Palindrome(int num)
{
    if (num/10000==num%10 && (num-(num/10000)*10000)/1000==(num%100-num%10)/10) return "Yes";
    return "No";
}

Console.WriteLine("Enter five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

string result = Palindrome(n);
Console.WriteLine(result);


