// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

// 1) Write a C# program that takes two numbers as input from the user and performs the following arithmetic operations:
//Addition
//Subtraction
//Multiplication
//Division
//Modulus (Remainder)


//Console.WriteLine("Enter first number");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter second number");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Addition

//double addition = num1 + num2;
//Console.WriteLine($"The addition is : {num1} + {num2} = {addition}");

// Subraction 

//double Subtraction  = num1 - num2;
//Console.WriteLine($"The addition is : {num1} - {num2} = {Subtraction}");

// Multipliation 

//double Multiplication  = num1 * num2;
//Console.WriteLine($"The addition is : {num1} * {num2} = {Multiplication}");


//Division

//double  Division = num1 / num2;
//Console.WriteLine($"The addition is : {num1} / {num2} = {Division}");

//Modulus (Remainder)


//double  Modulus = num1 % num2;
//Console.WriteLine($"The addition is : {num1} % {num2} = {Modulus}");


// 2) Write a C# program to compare two numbers entered by the user and print whether the first number is greater than, less than, or equal to the second number.


//Console.WriteLine("Enter first number");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter second number");
//double num2 = Convert.ToDouble(Console.ReadLine());

// greater than

//if(num1 > num2)
//{
//    Console.WriteLine($"The {num1} is greater than {num2}");

//}

// less than

//if (num1 < num2)
//{
//    Console.WriteLine($"The {num1} is less than {num2}");

//}


// equals to 

//if (num1 == num2)
//{
//    Console.WriteLine($"The {num1} is  equals to  {num2}");

//}

// 
// 3) Write a C# program to print the multiplication table of a number entered by the user using a loop (for, while, or do-while)

// while loop 


//Console.WriteLine("Enter any number");
//int num1 = Convert.ToInt32(Console.ReadLine());

//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine($"{num1} * {i} = {num1 * i}");
//    i++;
//}

// do while loop 

//int i = 1;
//do
//{
//    Console.WriteLine($"{num1} * {i} = {num1 * i}");
//    i++;
//} while (i <= 10);

// for loop 

//for( int i = 0; i <= 10; i++)
//{
//  Console.WriteLine($"{num1} * {i} = {num1 * i}");

//}

// 4) Write a C# program to print a pattern of asterisks (*) in the following format using nested loops:

//int rows = 5;

//for(int i = 1; i <= rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();

//}

// 5) Write a C# program to find the sum of all even numbers between 1 and 100 using loop control statements (break and continue).

//int sum = 0;
//for (int i = 0; i <= 100; i++)
//{
//    if(i % 2 != 0)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//    sum  += i; 
//}
//Console.WriteLine("i" + sum);


// 7) Write a C# program to print all the prime numbers between 1 and 100 using a loop and conditional statements.

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//    sum += i;
//}
//Console.WriteLine("i" + sum);