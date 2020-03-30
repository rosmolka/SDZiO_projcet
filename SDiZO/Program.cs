using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
namespace Interface_cszark
{

    class Program
    {
        static void printInterface(string[] options, int select)
        {

            int max_length = 0;
            int swt = 2;
            char LG = '\u2554';
            char PG = '\u2557';
            char LD = '\u255A';
            char PD = '\u255D';
            char LK = '\u2560';
            char PK = '\u2563';
            char poz = '\u2550';
            char pion = '\u2551';
            foreach (string s in options)
            {

                if (s.Length > max_length) max_length = s.Length;
            }
            if (max_length < 4)
            {
                Console.Write("2. Nadluższa z opcji musi mieć przynajmniej 4 znaki");
                return;
            }
            if (max_length % 2 == 0) swt = 1;
            Console.Write(LG);
            for (int i = 0; i < max_length + 2; i++) Console.Write(poz);
            Console.Write(PG + "\n" + pion);
            for (int i = 0; i < (max_length - 4) / 2 + 1; i++) Console.Write(" ");
            Console.Write("OPCJE"); 
            for (int i = 0; i < (max_length - 4) / 2 + swt; i++) Console.Write(" ");
            Console.Write(pion + "\n" + LK);
            for (int i = 0; i < max_length + 2; i++) Console.Write(poz);
            Console.WriteLine(PK);
            int x = 0;
            foreach (string s in options)
            {
                Console.Write(pion);
                for (int i = 0; i < (max_length - s.Length) / 2 + 1; i++) Console.Write(" ");
                if (x == select) Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.White;
                if (s.Length % 2 == 0)
                {
                    for (int i = 0; i < (max_length - s.Length) / 2 + swt; i++) Console.Write(" ");
                }
                else
                {
                    for (int i = 0; i < (max_length - s.Length) / 2 + Math.Abs(swt - 3); i++) Console.Write(" ");
                }
                Console.WriteLine(pion);
                x++;
            }
            Console.Write(LD);
            for (int i = 0; i < max_length + 2; i++) Console.Write(poz);
            Console.Write(PD);
        }
            public class WgrajPlik
            {

            }

        static void Main(string[] args)
        {
            int select = 0;
            char pick;
            string[] options = { "Wgraj plik wejściowy w formiacie .csv",
                "Sortowanie algorytmem bąbelkowym",
                "Sortowanie algorytmem szybkim",
                "Sortowanie przez zliczanie",
                "Sortowanie BST",
                "Sortowanie kopcowe",
                "Otrzymaj wyniki sortowania wybranego algorytmu",
                "Zamknij program"};
            while (true)
            {
                Console.Clear();
                printInterface(options, select);
                pick = Console.ReadKey(true).KeyChar;
                if (pick == 'w')
                {
                    if (select > 0) select--;
                    else select = options.Length - 1;
                }
                else if (pick == 's')
                {
                    if (select < options.Length - 1) select++;
                    else select = 0;
                }
                else if (pick == 'e')
                {
                    Console.Clear();
                    Console.WriteLine("Wybrano: " + options[select]);
                    string[] lines = System.IO.File.ReadAllLines(@"C:/Users/rosmo/source/repos/SDiZO/SDiZO");
                    
                    
                   // CSVWriter.WriteLine(line);
                    
                   // CSVWriter.Close();
                    Console.ReadKey(true);

                    


                }
            }
        }
    }
}
