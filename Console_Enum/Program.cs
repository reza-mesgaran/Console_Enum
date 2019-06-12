using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Enum     //Enum is set of named const ; By default, the first enumerator has the value 0
{
    class Program
    {
        enum MyEnumMenu {Exit, Addition, Subtraction, Multiplication, Division }
        static void Main(string[] args)
        {

            int MyEnumMenuLen= Enum.GetNames(typeof(MyEnumMenu)).Length;  // Get Enum length


            int n =0;
            foreach (MyEnumMenu m in Enum.GetValues(typeof(MyEnumMenu)))   // Print all Enum members
            {
                Console.Write(n+".");
                Console.WriteLine(m);
                n++;
            }
            Console.WriteLine("\n");

            Console.Write("Enter from menu (between 1--{0}):",MyEnumMenuLen-1);
            int myinput=int.Parse(Console.ReadLine());
            
            
            switch (myinput)
            {
                case (int)MyEnumMenu.Exit:
                    Console.WriteLine("Good Bye ...");
                    break;

                case (int)MyEnumMenu.Addition:
                    Console.WriteLine("Sum + ");
                    break;

                case (int)MyEnumMenu.Subtraction:
                    Console.WriteLine("Subtraction - ");
                    break;

                case (int)MyEnumMenu.Multiplication:
                    Console.WriteLine("Multiplication * ");
                    break;

                case (int)MyEnumMenu.Division:
                    Console.WriteLine("Division / ");
                    break;

            }

            Console.ReadKey();
        }
        

    }    
}
