using System;

namespace Lekcja11
{
    /*
    Napisz aplikację, która na podstawie wprowadzonej przez użytkownika liczby, wyświetli odpowiedni komunikat. 
    Jeżeli jest to liczba parzysta – „Liczba parzysta” lub jeżeli jest to liczba nieparzysta – „Liczba nieparzysta”. 
    Wprowadź również walidację danych wprowadzanych przez użytkownika, to znaczy jeżeli użytkownik poda wartość, 
    która nie jest liczbą, to wtedy również powinien zostać wyświetlony odpowiedni komunikat.

    Podpowiedzi:
    Użyj znaku modulo (%).

    Rozwiązanie:
    Wyślij link do Twojego repozytorium na githubie z rozwiązaniem na grupę na facebook’u lub na mojego maila 
    (kazimierz.szpin@modestprogrammer.pl).
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($" Podaj liczbę CAŁKOWITĄ z zakresu {Int32.MinValue} do {Int32.MaxValue}: ");

            var clientNumber = GetIntNumber();

            // czy liczba parzysta
            if (IsEvenNumber(clientNumber))
            {
                Console.WriteLine($" Liczba {clientNumber} jest liczbą parzystą.\n");
            }
            else
            {
                Console.WriteLine($" Liczba {clientNumber} jest liczbą nieparzystą.\n");
            }
        }

        private static int GetIntNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int clientNumber))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    Console.Write("Podaj liczbę całkowitą: ");
                    continue;
                }

                return clientNumber;
            }
        }

        private static bool IsEvenNumber(int client_number)
        {
            if ((client_number % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
