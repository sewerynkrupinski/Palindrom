using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        public void isPalindrome(string str)
        {
            List<char> wyrazenie = new List<char>();
            List<char> wyrazenie2 = new List<char>();

            //utworzenie listy dozwolonych znaków
            IList<int> Allowed = new List<int>
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                '1', '2', '3', '4', '5', '6', '7', '8', '9',
                '0'
            };

            //wprowadzony tekst
           // string str = "Noel sees leon.";


            //wszyzstkie litery tekstu stają się małe
            str = str.ToLower();

            // pobrana długość ciągu znaków
            int dlugoscStringa = str.Length;

            // wyświetlenie tekstu po zmniejszeniu znaków
            Console.WriteLine("Wprowadzono: " + str);


            // pętla odczytuje ciag znaków, jeśli znak jest na liście dozwolonych dodaje go do nowej listy
            for (int i = 0; i < dlugoscStringa; i++)
            {
                if (Allowed.Contains(str[i]))
                    wyrazenie.Add(str[i]);
                else
                    continue;
            }


            // pętla odczytuje ciąg znaków od końca, jeśli znak jest na liście dozwolonych dodaje go do nowej listy
            for (int i = dlugoscStringa - 1; i >= 0; i--)
            {
                if (Allowed.Contains(str[i]))
                    wyrazenie2.Add(str[i]);
                else
                    continue;
            }

            // pętle wypisują oba wyrażenia
            Console.Write("Wyrażenie 1: ");
            foreach (char tmp2 in wyrazenie)
            {
                Console.Write(tmp2);
            }
            Console.WriteLine();

            Console.Write("Wyrażenie 2: ");
            foreach (char tmp3 in wyrazenie2)
            {
                Console.Write(tmp3);
            }
            Console.WriteLine();

            //metoda sprawdza czy sekwenscje znaków są takie same
            bool czyZawiera = (wyrazenie.SequenceEqual(wyrazenie2));

            Console.WriteLine("Czy są jednakowe:" + czyZawiera);
        }


        static void Main(string[] args)
        {

            Program program = new Program();

            Console.WriteLine("Program umożliwia sprawdzenie czy dane wyrażenie jest palindromem");
            Console.WriteLine("Podaj wyrażenie do sprawdzenia");
            string reading = Console.ReadLine();
            program.isPalindrome(reading);

            


            Console.ReadKey();


        }
    }
}
