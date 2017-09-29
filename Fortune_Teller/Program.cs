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

            Console.WriteLine("What is your favorite ROYGBIV color? If need help understanding what ROYGBIV colors are please enter (help)");
            string favColor = Console.ReadLine().ToLower();

            bool red = (favColor == "red");
            bool orange = (favColor == "orange");
            bool yellow = (favColor == " yellow");
            bool green = (favColor == "green");
            bool blue = (favColor == "blue");
            bool indigo = (favColor == "indigo");
            bool violet = (favColor == "violet");
            string help = ("red, orange, yellow, green, blue, indigo, violet"  );








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

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());


            int zero = 0;
            int one = 1;
            int two = 2;
            int three = 3;
            bool four = (siblings >= 4);
            bool neg = (siblings < 0);


            //bool china = (siblings == 0);
            //bool africa  = (siblings == 1);
            //bool russia = (siblings == 2);
            //bool florida = (siblings == 3);







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




            else if (siblings == three)
            {
                Console.WriteLine("Cancoon \a");

            }
            else if (four)
            {
                Console.WriteLine("North Korea");

            }
            else if(neg){
                Console.WriteLine("North Korea");
            }
           








           

            


        }
    }
}
