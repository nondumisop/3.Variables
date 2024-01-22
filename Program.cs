using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name = "Nondumiso";
            int age;

            // initialisation 
            name = "Nondumiso";
            age = 12;


            //what will be seen on console
            Console.WriteLine("There once was a girl called" + name);
            Console.WriteLine(name +"was" +age +  "of age");
            Console.WriteLine(name + "really  never  liked  her  name");

            //change variable values
            age =  16;
            name =  "Zamisa";

            Console.WriteLine("At  age" +  age +   "she changes her name to" +  name);

            //to freeze the console 
            Console.ReadLine();

            /*Note : you can also declare and initialise on the same line 
             * eg
             * string name "Zamisa"
             */
        }
    }
}
