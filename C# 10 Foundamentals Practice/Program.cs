// 1. Create a greeting

//Console.WriteLine("Type your first name");
//string name = Console.ReadLine();
//Console.WriteLine("Type your second name");
//string surname = Console.ReadLine();
//Console.WriteLine("Hello, " +  name + " " +surname + "!");

//2. int variable + converting

//Console.WriteLine("Type your age");
//string ageSting = Console.ReadLine();
//int ageOfUser = int.Parse(ageSting);    
//Console.WriteLine("You are " + ageOfUser + " years old");

//3. Sum of ints

//int a;
//Console.WriteLine("Type the first number");
//a = int.Parse(Console.ReadLine());
//int b;
//Console.WriteLine("Type the second number");
//b = int.Parse(Console.ReadLine());
//int c = a + b;
//Console.WriteLine("The sum is " + c);

//4. decimal

//decimal price = 100.0M;
//Console.WriteLine("The price is equal to " + price);

//5. constants and double

//const double profitMargin = 0.17d;
//double doublePrice = (double)price;
//double profit = doublePrice * profitMargin;
//Console.WriteLine("The profit is equal to " + profit);


//6. Compound operator

//Console.WriteLine("Type a number");
//int a = int.Parse(Console.ReadLine());
//a += 3;
//Console.WriteLine("A number after increasing by the compound operator by 3 is equal " + a);
//Console.ReadLine();

//7. char methods and IsWhiteSpace

//char aChar = 'a';
//bool isWhiteSpace = char.IsWhiteSpace(aChar);
//Console.WriteLine($"Character: {aChar}");
//Console.WriteLine($"IsWhiteSpace: {isWhiteSpace}");
//Console.ReadLine();


//8. DateTime

//DateTime startDate = new DateTime(2022, 03, 05);
//DateTime endDate = DateTime.Today;
//Console.WriteLine("startDate: " + startDate);
//Console.WriteLine("endDate: " + endDate);
//Console.ReadLine();

//9. Converting long to var

//long myLargeValue = 123456789;
//int intValue = (int)myLargeValue;
//Console.WriteLine("intValue = " + intValue);
//Console.ReadLine();

//10. Implicit typing

//var a = 10;
//Console.WriteLine("var a = 10; in the statement, a is an intager value");
//Console.ReadLine();

//11. Exercise 02 - Sum calculation

//Console.WriteLine("Enter a first number:");
//string stringValue1 = Console.ReadLine();

//Console.WriteLine("Enter a second number:");
//string stringValue2 = Console.ReadLine();

//int intValue1 = int.Parse(stringValue1);
//int intValue2 = int.Parse(stringValue2);

//var sum = intValue1 + intValue2;
//Console.WriteLine($"sum: {sum}");
//Console.ReadLine();


//12. Checkpoint 16 - Relational operators 1

//using System;

//Console.WriteLine("type your age");
//var a = Console.ReadLine();
//int age = int.Parse(a);
//bool validAge = (age >= 18);
// if (validAge == true)
//{
//    Console.WriteLine("You are adult");
//}
// else
//{
//   Console.WriteLine("Sorry, you are not adult");
//}
//Console.ReadLine();

//13. Checkpoint 20 - Conditional 2

//Console.WriteLine("type your age");
//var a = Console.ReadLine();
//int age = int.Parse(a);
//if (age > 18)
//{
//    Console.WriteLine("You are eligible");
//    Console.WriteLine("Congratulations");
//}
//else
//{
//    Console.WriteLine("You aren't eligible");
//    Console.WriteLine("Sorry");
//}
//Console.ReadLine();

//14. Exercise 03 - Conditionals


//Console.WriteLine("Enter a first number:");
//string stringValue1 = Console.ReadLine();

//Console.WriteLine("Enter a second number:");
//string stringValue2 = Console.ReadLine();

//int intValue1 = int.Parse(stringValue1);
//int intValue2 = int.Parse(stringValue2);

//if (intValue1 == intValue2)
//{
//    Console.WriteLine("The values are equal!");
//}
//else if (intValue1 < intValue2)
//{
//    Console.WriteLine("The first value is smaller!");
//}
//else
//{
//    Console.WriteLine("The second value is smaller!");
//}

//Console.ReadLine();

//15. While loop

//int i = 1;
//while (i < 11)
//{
//    Console.WriteLine(i);
//    i++;
//  }

//Console.WriteLine();

//16. Exercise 04 - Loops

//Console.WriteLine("Enter a number:");
//int sum = 0;

//string stringValue = Console.ReadLine();
//int startValue = int.Parse(stringValue);

//for (int i = startValue; i > 0; i--)
//{
//    sum += i;

//}
//Console.WriteLine("The sum is: " + sum);

//Console.ReadLine();


//17. Do while loop

//int i = 0;

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10);


//18. Checkpoint 23 - for

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//19. Methods


//Console.WriteLine("Enter a first number:");
//string stringValue1 = Console.ReadLine();

//Console.WriteLine("Enter a second number:");
//string stringValue2 = Console.ReadLine();


//int a = int.Parse(stringValue1);
//int b = int.Parse(stringValue2);

//int sum = AddNumbers(a, b);

//Console.WriteLine($"The sum is : {sum}");

//static int AddNumbers (int a, int b)
//{
//    return a + b;
//}

//Console.ReadLine();

//20. Exercise 05 - Methods


//Console.WriteLine("Enter a first number:");
//string stringValue1 = Console.ReadLine();

//Console.WriteLine("Enter a second number:");
//string stringValue2 = Console.ReadLine();


//int a = int.Parse(stringValue1);
//int b = int.Parse(stringValue2);

//int result = MultiplyTwoNumbers(a, b);


//static int MultiplyTwoNumbers(int a, int b)
//    {
//        return a * b;
//    }



//Console.WriteLine($"The result is : {result}");
//Console.ReadLine();

//21. Adding a halper file

//using C__10_Foundamentals_Practice;

//int amount = 5;

//int months = 11;

// int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

//Console.WriteLine($"Yearly wage : {yearlyWage}");

//Console.ReadLine();


// 22. Checkpoint 26 - Utility class

//using C__10_Foundamentals_Practice;


//int a = 5;
//int b = 3;

//int sum = Utilities.SubtractTwoNumbers(a, b);

//Console.WriteLine($"The result is : {sum}");

//Console.ReadLine();

// Exercise 06 - Methods and their parameters

//using C__10_Foundamentals_Practice;

//int yearlyWage;

//yearlyWage = Utilities.CalculateYearlyWage(1000);

//Console.WriteLine($"Yearly Wage = {yearlyWage}");


//Console.ReadLine();
