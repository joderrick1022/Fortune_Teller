using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("what is your Last name? + \a");
            string lastName = Console.ReadLine().ToLower();



            Console.WriteLine("What is your age? numbers only please EX(1,25,6,7,76)");
            int userAge = int.Parse(Console.ReadLine());

            int retireYears = (userAge - 66);
            bool odd = (userAge % 2 != 0); // these two bools are to check to see if user age is even olr odd.
            bool even = (userAge % 2 == 0);
            string fullName = firstName + lastName;

            if (odd)
            {

                Console.WriteLine("you will retire in " + retireYears + " years" + "!");
            }
            else if (even)
            {
                Console.WriteLine("you will retire in " + retireYears + " years" + "!");
            }

            Console.WriteLine("What month were you born?");
            int birthMonth = int.Parse(Console.ReadLine());

            int jan = 01;
            int feb = 02;
            int mar = 03;
            int apr = 04;
            int may = 05;
            int jun = 06;
            int jul = 07;
            int aug = 08;
            int sep = 09;
            int oct = 10;
            int nov = 11;
            int dec = 12;

            if (birthMonth == jan)
            {
                Console.WriteLine("$300.000.00");
            }
            if (birthMonth == feb)
            {
                Console.WriteLine("$300.000.00");
            }
            if (birthMonth == mar)
            {
                Console.WriteLine("$300.000.00");
            }
            if (birthMonth == apr)
            {
                Console.WriteLine("$300.000.00");
            }
            if (birthMonth == may)
            {
                Console.WriteLine("$750, 000.00");
            }
            if (birthMonth == jun)
            {
                Console.WriteLine("$750, 000.00");
            }
            if (birthMonth == jul)
            {
                Console.WriteLine("$750, 000.00");
            }
            if (birthMonth == aug)
            {
                Console.WriteLine("$750, 000.00");
            }
            if (birthMonth == sep)
            {
                Console.WriteLine("$1, 000, 000.00");
            }
            if (birthMonth == oct)
            {
                Console.WriteLine("$1, 000, 000.00");
            }
            if (birthMonth == nov)
            {
                Console.WriteLine("$1, 000, 000.00");
            }
            if (birthMonth == dec)
            {
                Console.WriteLine("$1, 000, 000.00");
            }
            if (birthMonth != jan && birthMonth != feb && birthMonth != mar && birthMonth != apr && birthMonth != may && birthMonth != jun &&


                birthMonth != jul && birthMonth != aug && birthMonth != sep && birthMonth != oct && birthMonth != nov && birthMonth != dec)
            {
                Console.WriteLine("$0.00");
            }

            //Console.WriteLine("What is your favorite ROYGBIV color? If need help understanding what ROYGBIV colors are please enter (help)");
            //string favColor = Console.ReadLine().ToLower();
            //bool red = (favColor == "red");
            //bool orange = (favColor == "orange");
            //bool yellow = (favColor == " yellow");
            //bool green = (favColor == "green");
            //bool blue = (favColor == "blue");
            //bool indigo = (favColor == "indigo");
            //bool violet = (favColor == "violet");

            //string help = ("red, orange, yellow, green, blue, indigo, violet");
            //bool helper = (favColor == "help");

            //for (int x = 0; x == helper.IndexOf; x++)
            //{
            //    Console.WriteLine(help);
            //}

            //if (helper)



            //{
            //    Console.WriteLine(help);

            //    {

            //    }

                Console.WriteLine("How many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());


                int zero = 0;
                int one = 1;
                int two = 2;
                int three = 3;
                bool four = (siblings >= 4);
                bool neg = (siblings < 0);


                bool china = (siblings == 0);
                bool africa = (siblings == 1);
                bool russia = (siblings == 2);
                bool florida = (siblings == 3);







                if (siblings == zero)
                {
                    Console.WriteLine("Africa");

                }

                else if (siblings == one)
                {
                    Console.WriteLine("Russia");

                }

                else if (siblings == two)
                {
                    Console.WriteLine("North Pole \a");

                }

                

            }
        }
}
