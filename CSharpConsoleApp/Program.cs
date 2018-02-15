using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleApp {
    class Program {
        static void Main(string[] args) {
            greeting();
        }
        public static void greeting() {
            greetingText();
            while (!InpurHandler(ReadInput<int>())) ;
        }

        private static void greetingText() {
            Console.Clear();
            Console.WriteLine("Hi and welcome to this random console application. Please type a number for the function you wanna run ^^");
            Console.WriteLine("1 - exit");
            Console.WriteLine("2 - Note generator");
            Console.WriteLine("3 - Calculator *WIP*");
        }

        private static bool InpurHandler(int input) {
            switch (input) {
                case 1:
                    Environment.Exit(0);
                    return true;
                case 2:
                    new NoteGenerator();
                    greetingText();
                    return false;
                /*case 3:
                    new Calculator();
                    greetingText();
                    return false;*/
                default:
                    Console.WriteLine("Sorry, that program does not exist, try again ^^");
                    return false;
            }
        }

        private static int ReadInput<int32>() {
            
            string userInput = Console.ReadLine();
            int userInputInt;
            try {
                userInputInt = int.Parse(userInput);
                return userInputInt;
            }catch(Exception) {
                return 0;
            }
        }

        private static String ReadInput() {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
