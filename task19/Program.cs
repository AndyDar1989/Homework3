/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*string Palindrome(int num)
{
    if (num<10000 | num>99999) return "Incorrect number";
    else if (num/10000==num%10 && (num/1000)%10==(num%100)/10) return "Yes";
    return "No";
}

Console.Write("Enter five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(n);
Console.WriteLine(result);*/

string Palindrome (int num)
{
    int new_number = 0;
    int num1=num;
    int origin_num=num;
    while(num!=0)
    {
        num1=num%10;
        new_number = new_number*10+num1;
        num = num/10;
    }
    if (origin_num==new_number) return "This is palindrome";
    else return "this isn't palindrome";
    }

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(n);
Console.WriteLine(result);

