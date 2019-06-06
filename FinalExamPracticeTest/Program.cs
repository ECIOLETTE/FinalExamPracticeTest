using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implement a method that prompts the user to input three integer values and find the greatest value of the three values.*/

            //double n1, n2, n3;
            //bool result;
            //string tmp;

            //Console.WriteLine("--------------------");
            //Console.WriteLine(" The greatest value ");
            //Console.WriteLine("--------------------");

            //Console.WriteLine("Enter the first number:");
            //tmp = Console.ReadLine();
            //n1 = double.Parse(tmp);
            //Console.WriteLine("Enter the second number:");
            //tmp = Console.ReadLine();
            //n2 = double.Parse(tmp);
            //Console.WriteLine("Enter the third number:");
            //tmp = Console.ReadLine();
            //n3 = double.Parse(tmp);

            //result = (n1 != n2 && n1 != n3);
            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("The greatest value of the three values is: Number 1 --> " + n1);
            //}
            //else if (n1 < n2 && n2 > n3)
            //{
            //    Console.WriteLine("The greatest value of the three values is: Number 2 --> " + n2);
            //}
            //else if (n1 < n3 && n2 < n3)
            //{
            //    Console.WriteLine("The greatest value of the three values is: Number 3 --> " + n3);
            //}

            //Console.ReadKey();

            // -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-


            /*Write a method that determines a student’s grade. The method will read three types of scores(quiz score, mid-term score, and final score) and determine the grade based on the following rules:
            -if the average score = 90 % =>grade = A
            -if the average score >= 70 % and < 90 % => grade = B
            -if the average score>= 50 % and < 70 % =>grade = C
            -if the average score<50 % =>grade = F*/

            //int quiz, mid, final;
            //int result;
            //string tmp;

            //Console.WriteLine("---------------");
            //Console.WriteLine("   S C O R E   ");
            //Console.WriteLine("---------------");

            //Console.Write("Quiz Score (0-100): ");
            //tmp = Console.ReadLine();
            //quiz = int.Parse(tmp);
            //Console.Write("Mid-term Score (0-100): ");
            //tmp = Console.ReadLine();
            //mid = int.Parse(tmp);
            //Console.Write("Final score (0-100): ");
            //tmp = Console.ReadLine();
            //final = int.Parse(tmp);

            //Console.WriteLine("---------------");
            //result = (quiz + mid + final) / 3;
            //Console.WriteLine(" SCORE: " + result);
            //Console.WriteLine("---------------");
            //    if (result >= 90)
            //{
            //    Console.WriteLine(" GRADE A");
            //}
            //    if (result >= 70 && result < 90)
            //{
            //    Console.WriteLine(" GRADE B");
            //}
            //    if (result >= 50 && result <70)
            //{
            //    Console.WriteLine(" GRADE C");
            //}
            //    if (result < 50)
            //{
            //    Console.WriteLine(" GRADE F");
            //}
            //Console.WriteLine("---------------");

            //Console.ReadKey();

            // -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-


            /* Write a method that counts the number of digits in an integer number.For example; 23498 has five digits.*/

            //int number;
            //String tmp;

            //Console.WriteLine("----------------------");
            //Console.WriteLine(" The Number of Digits ");
            //Console.WriteLine("----------------------");

            //Console.Write("Number: ");
            //tmp = Console.ReadLine();
            //number = tmp.Length;
            //Console.WriteLine("");
            //Console.WriteLine("The Number {0} contains {1} digits.", tmp, number);

            //Console.ReadKey();

            // -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-


            /*Write a method to print the table of characters that are equivalent to the ASCII codes from 1 to 122.
              The program will print the 10 characters per line.*/

            //{
            //    int i = 1;
            //    do
            //    {
            //        Console.Write((char)i + "\t");
            //        if (i % 10 == 0)
            //            Console.Write("\n");
            //
            //        i++;
            //    }
            //    while (i <= 122);
            //
            //    Console.ReadLine();
            //}

            /*Write a method that accepts a string as an input and counts the number of spaces in the string.*/

        //    string texto;

        //    Console.WriteLine("Enter a Phrase: ");
        //    texto = Console.ReadLine();

        //    Console.WriteLine("============================");
        //    Console.WriteLine(qtdLetras(texto).ToString() + " - Letters");
        //    Console.WriteLine("");
        //    Console.WriteLine(qtdEspacos(texto).ToString() + " - White Spaces");
        //    Console.WriteLine("============================");
        //    Console.ReadLine();
        }

        //static int qtdLetras(string texto)
        //{
        //    int qtd = 0;
        //    foreach (char letra in texto)
        //    {
        //        if (char.IsLetterOrDigit(letra))
        //        {
        //            qtd++;
        //        }
        //    }
        //    return qtd;
        //}

        //static int qtdEspacos(string texto)
        //{
        //    int qtd = 0;
        //    foreach (char letra in texto)
        //    {
        //        if (char.IsWhiteSpace(letra))
        //        {
        //            qtd++;
        //        }
        //    }
        //    return qtd;
        //}
    }
}

