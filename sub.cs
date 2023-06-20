using System;
public class SubtractTwoNumbers
{
public static void Main(string[] args)
{
Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int difference = a - b;
Console.WriteLine("The difference of the two numbers is: " + difference);
}
}
