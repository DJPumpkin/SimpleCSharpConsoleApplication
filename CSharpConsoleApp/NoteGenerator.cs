using System;

namespace CSharpConsoleApp {
    internal class NoteGenerator {
        public NoteGenerator() {
            Console.Clear();
            Console.WriteLine("Welcome to the note generator :D");
            Console.WriteLine("To generate a note, type in the frequency and then the length in ms");
            Console.WriteLine("The frequency has to be between 37 and 32767");
            Console.WriteLine("<freq> <length>");
            Console.WriteLine("Example: 6000 100");
            Console.WriteLine("Return to the main menu by typing 'exit'");
            while (NoteInput());
        }

        private bool NoteInput() {
            String stringInput = Console.ReadLine();
            if (stringInput.ToLower().Equals("exit")) {
                return false;
            }
            String[] inputArray = stringInput.Split(' ');
            try {
                int freq = int.Parse(inputArray[0]);
                int length = int.Parse(inputArray[1]);
                consoleBeep(freq, length);
            } catch (Exception) {
                Console.WriteLine("Please enter a valid input");
            }
            return true;
        }

        private void consoleBeep(int freq, int length) {
            try {
                Console.Beep(freq, length);
            } catch (ArgumentOutOfRangeException) {
                Console.WriteLine("frequency out of range");
            }
        }
    }
}