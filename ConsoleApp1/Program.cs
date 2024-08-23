// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

decimal atmCurrentBalance = 2000m;
decimal userAccountBalance = 5000.0m;
decimal charge;
decimal withdrawalAmount;
Console.WriteLine("Input desired amount!");
withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(withdrawalAmount);

charge = (0.5m / 100) * withdrawalAmount;
withdrawalAmount = withdrawalAmount + charge;

if (withdrawalAmount > userAccountBalance)
{
    Console.WriteLine("Insufficient balance!!!!");
    return;
}

if (withdrawalAmount < 1000.00m)
{
    Console.WriteLine("Please input an amount greater than 999!!");
    return;
}


if (atmCurrentBalance < 1000.00m)
{
    Console.WriteLine("Temporarily unable to dispense cash!!");
    return;
}

if (atmCurrentBalance > 1000.00m && atmCurrentBalance < withdrawalAmount)
{
    Console.WriteLine("Dey play! Please withdrawal a lower amount!!");
    return;
}

Console.WriteLine("Cash dispensed successfully!!!");
*/

/* Assignment 
 write a asimple code to submit student score for a test.

 */

using System.ComponentModel.Design;

 int passMark = 55;

if (passMark > 70)
{
    Console.WriteLine(" Grade is A ");
    return;
}

else if (passMark > 60 && passMark < 69)
{
    Console.WriteLine("Grade is B");
    return;
}
else if (passMark > 50 && passMark < 59)
{
    Console.WriteLine("Grade is c");
    return;
}

else if (passMark > 40 && passMark < 49)
{
    Console.WriteLine("Grade is c");
    return;
}

else if(passMark > 0 && passMark < 39)
{
    Console.WriteLine("Grade is c");
    return;
}
else
{
    Console.WriteLine("invalid input");
} 

//int passMark = 100;
//int  failMark = 0;

//char studentGrade;
//Console.WriteLine("input student score");
//studentGrade = Convert.ToChar(Console.ReadLine());
//Console.WriteLine(studentGrade);
//studentGrade = (char)passMark;

//if (passMark > 70)
//{
//    Console.WriteLine(" Grade is A ");
//    return;
//}