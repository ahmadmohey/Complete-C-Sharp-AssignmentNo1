using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0} My name is C#, How old are you?",name);
            int.TryParse(Console.ReadLine(), out int age);
            if(age==0)
                Console.WriteLine("That is not a correct input");
            else
                Console.WriteLine("{0} good, As for me I was born on 2002. Which makes me {1} years old.", age,DateTime.Now.Year-2002);
        }
    }
}

