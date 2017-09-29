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

            Console.WriteLine("What is your age? numbers only please EX(1,25,6,7,76)");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());


        }
    }
}
