using System.ComponentModel;
using System.Text;
using System.Threading.Channels;

namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //1 - Write a program that takes a number from the user then 
            //print yes if that number can be divided by 3 and 4 otherwise print no.‎

            //sol

            //Console.WriteLine("Enter The Number");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //} 
            #endregion

            #region Q2
            //2- Write a program that allows the user to insert an integer
            //then print negative if it is negative number otherwise print positive.

            //sol

            //Console.WriteLine("Enter The Number");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number >= 0 )
            //{
            //    Console.WriteLine($"{number} is Postive");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is Negative");
            //}



            #endregion


            #region Q3

            //3- Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            //sol

            //Console.WriteLine("Enter First Number:");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.WriteLine("Enter Secound Number:");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine("Enter Thired Number:");
            //int.TryParse(Console.ReadLine(), out int num3);

            //if (num1 > num2 && num1 > num3)
            //{

            //    Console.WriteLine($"The max num is : {num1} ");

            //    if (num2 > num3)
            //    {
            //        Console.WriteLine($"The min num is : {num3} ");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"The min num is : {num2} ");
            //    }

            //}
            //else if (num1 < num2 && num2 > num3)
            //{
            //    Console.WriteLine($"The max num is : {num2} ");


            //    if (num1 > num3)
            //    {
            //        Console.WriteLine($"The min num is : {num3} ");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"The min num is : {num1} ");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine($"The max num is : {num3} ");

            //    if (num2 > num1)
            //    {
            //        Console.WriteLine($"The min num is : {num1} ");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"The min num is : {num2} ");
            //    }
            //}

            #endregion

            #region Q4

            //‎4- Write a program that allows the user to insert an integer number
            //then ‎check If a number is even or odd.‎

            //sol

            //Console.WriteLine("Enter A Number");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} is an Even Number");
            //}
            //else
            //{
            //     Console.WriteLine($"{num} is an Odd Number");
            //}

            #endregion

            #region Q5

            //5- Write a program that takes character from the user then if it is a vowel
            //chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //sol

            //Console.WriteLine("Enter a character");
            //string? Litter = Console.ReadLine();

            //string massage = Litter switch
            //{
            //    "A" or "a" or "E" or "e" or "I" or "i" 
            //    or "O" or "o" or "U" or "u" 
            //    => $"{Litter} is a Vowel Character",
            //    _ => $"{Litter} is a constant Chatacter"
            //};
            //Console.WriteLine(massage);
            #endregion

            #region Q6
            //‎6- Write a program that allows the user to insert an integer then print all
            //‎numbers between 1 to that number.‎

            //sol

            //Console.WriteLine("Enter A Number");
            //int.TryParse(Console.ReadLine(), out int num) ;
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q7
            //‎7- Write a program that allows the user to insert an integer then ‎
            //print a multiplication table up to 12.‎


            //sol

            //Console.WriteLine("Enter A Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i} x {num} = {i*num}");

            //}


            #endregion

            #region Q8
            //‎8- Write a program that allows to user to insert number
            //then print all even ‎numbers between 1 to this number

            //sol

            //Console.WriteLine("Enter Any Number");

            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} is an Even Number");
            //    }

            //}

            #endregion

            #region Q9


            //‎9- Write a program that takes two integers then prints the power.‎



            //sol-1

            //Console.WriteLine("Enter the stander Number");
            //int.TryParse(Console.ReadLine(), out int standerNum);
            //Console.WriteLine("Enter the Power Number");
            //int.TryParse(Console.ReadLine(), out int PowerNum);

            //Double result = Math.Pow(standerNum,PowerNum);
            //Console.WriteLine($"{standerNum}^{PowerNum} = {result}");

            //sol-2
            //double result = 1;
            //for (int i = 1; i <= PowerNum; i++)
            //{
            //     result *= standerNum;
            //}
            //Console.WriteLine($"{standerNum}^{PowerNum} = {result}");

            #endregion

            #region Q10

            //‎10- Write a program to enter marks of five subjects and calculate total, ‎average and percentage.‎

            //sol

            //Console.WriteLine("Enter The First Subject Degree");
            //int.TryParse(Console.ReadLine(), out int fD);
            //Console.WriteLine("Enter The Second Subject Degree");
            //int.TryParse(Console.ReadLine(), out int sD);
            //Console.WriteLine("Enter The Third Subject Degree");
            //int.TryParse(Console.ReadLine(), out int thD);
            //Console.WriteLine("Enter The fourth Subject Degree");
            //int.TryParse(Console.ReadLine(), out int fourD);
            //Console.WriteLine("Enter The fifth Subject Degree");
            //int.TryParse(Console.ReadLine(), out int fifD);

            //int totalDegree = fD + sD + thD + fourD + fifD;
            //double average = totalDegree / 5.0;
            //decimal percentage = (decimal)totalDegree / 500 * 100;
            //Console.WriteLine($"Total Marks = {totalDegree}");
            //Console.WriteLine($"Average = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");



            #endregion

            #region Q11

            //11- Write a program that takes a month number from the user then prints the number of days in that month.‎

            //sol

            //Console.WriteLine("Enter The Month Number");
            //int.TryParse(Console.ReadLine(), out int month);

            //string massage = month switch
            //{
            //    1 or 3 or 5 or 6 or 7 or 8 or 10 or 12 => "31 Days",
            //    4 or 9 or 11 => "30 Days",
            //    2 => "28 Days",
            //    _ => "Invalid Month Number"
            //};
            //Console.WriteLine($"The Month {month} Has {massage} ");

            #endregion

            #region Q12
            //‎12- Write a program to create a Simple Calculator.‎

            //sol

            //Console.Write("Enter The First Num  ");
            //double.TryParse(Console.ReadLine(), out double firstNum);
            //Console.Write("Enter The Operator (+, -, *, /)  ");
            //string? operatorInput = Console.ReadLine();
            //Console.Write("Enter The Second Num  ");
            //double.TryParse(Console.ReadLine(), out double secondNum);
            //double result = operatorInput switch
            //{
            //    "+" => firstNum + secondNum,
            //    "-" => firstNum - secondNum,
            //    "*" => firstNum * secondNum,
            //    "/" when secondNum != 0 => firstNum / secondNum , // why the condition not work
            //    _ => 0000000
            //};
            //Console.WriteLine($"{firstNum} {operatorInput} {secondNum}  =  {result}");




            //switch (operatorInput)
            //{
            //    case "+":
            //        result = firstNum + secondNum;
            //        break;
            //    case "-":
            //        result = firstNum - secondNum;
            //        break;
            //    case "*":
            //        result = firstNum * secondNum;
            //        break;
            //    case "/":
            //        if (secondNum != 0)
            //        {
            //            result = (double)firstNum / secondNum;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero.");
            //            return;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        return;
            //}
            #endregion


            #region Q13
            //‎13- Write a program to allow the user to enter a string and print the ‎REVERSE of it.‎

            //sol

            //Console.WriteLine("Enter A String");
            //string? input = Console.ReadLine();
            //StringBuilder reversedString = new StringBuilder();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString.Append(input[i]);
            //}
            //Console.WriteLine($"The Reverse String is : {reversedString}");

            //Alternative solution using LINQ
            //string reversed = new string(input.Reverse().ToArray());
            //Console.WriteLine($"The Reverse String is : {reversed}");

            //Alternative solution using Array
            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //reversedString.Append(reversedString.ToString());
            //Console.WriteLine($"The Reverse String is : {reversedString}");

            //Alternative solution using StringBuilder
            //StringBuilder reversedString = new StringBuilder();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString.Append(input[i]);
            //}
            //Console.WriteLine($"The Reverse String is : {reversedString}");




            //Console.WriteLine(v);


            #endregion

            #region Q14
            //‎ Write a program to allow the user to enter int and print the REVERSED of ‎it.‎

            //sol



            #region Q


            //sol
            //Console.WriteLine("Enter range number");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 2; i <= num; i++)
            //{
            //    if (i / 1 == i )
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Q


            //sol


            #endregion








        }
    }
}
