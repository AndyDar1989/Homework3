/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*string Palindrome(int num)
{
    if (num/10000==num%10 && (num-(num/10000)*10000)/1000==(num%100-num%10)/10) return "Yes";
    return "No";
}

Console.WriteLine("Enter five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(n);
Console.WriteLine(result);*/
string Palindrome (double num)
{
    int max_count = 0;
    int min_count = 0;
    while(num<10)
    {
        num=num/10;
        max_count++;
    }
    double degree1 = Math.Pow(10, max_count-1);
    double degree2 = Math.Pow(10, min_count+1);
    double num1 = num;
    while(min_count<=max_count/2)
    {
    if (num1/degree1==num1%degree2 && (num-(num/degree1)*degree1)/1000==(num%100-num%degree2)/degree2) min_count++;
    return "no";
    }
    return "yes";
}

Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(n);
Console.WriteLine(result);

