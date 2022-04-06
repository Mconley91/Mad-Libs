using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();*/

            //Arrays Begin

            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            luckyNumbers[1] = 900;
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Dwight";
            friends[3] = "Michael";
            friends[4] = "Creed";

            Console.WriteLine(friends[0]);
            Console.WriteLine(luckyNumbers[1]);

            //the following calls a method separate from the Main method
            SayHi("Mike", 24);
            SayHi("Matt", 33);
            SayHi("John", 17);
            SayHi("Tom", 23);
            SayHi("Patrick", 40);

            Console.ReadLine();
        }

        /*this method exists outside of the main method, and 
        will not be used unless called within the main method*/
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
