using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \"print out the quotation mark.");
            

            string firstName = "Evans";
            string lastName = "Fundira";
            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case sensiti
            Console.WriteLine(lastName.Contains("Fu"));
            //access characters using index
            Console.WriteLine(firstName[0]);
            //indexOf will tell u iff the value is there and at what posi
            Console.Write("index of a is ");
            Console.WriteLine(lastName.IndexOf('a')); //can use double quo
                                                      //substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index and length ie how many chars u wann
            Console.WriteLine(firstName.Substring(1, 2));
            Console.Read();
        }
    }
}
