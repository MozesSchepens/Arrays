// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[4];  // Array met 4 elementen
        int aantalElementen = 0;   // Houdt bij hoeveel elementen momenteel zijn toegevoegd

        // Methode om het array te vullen en uit te breiden als het nodig is
        while (true)
        {
            Console.WriteLine("Voeg een nieuw getal toe (of typ 'stop' om te stoppen): ");
            string invoer = Console.ReadLine();
            if (invoer.ToLower() == "stop")
            {
                break;
            }

            if (int.TryParse(invoer, out int waarde))
            {
                // Controleer of de array vol is
                if (aantalElementen == array.Length)
                {
                    // Vergroot de array
                    array = VergrootArray(array);
                }

                // Voeg het nieuwe element toe
                array[aantalElementen] = waarde;
                aantalElementen++;

                // Toon huidige inhoud van de array
                Console.WriteLine("Huidige array: ");
                ToonArray(array, aantalElementen);
            }
            else
            {
                Console.WriteLine("Ongeldige invoer, probeer opnieuw.");
            }
        }
    }

    // Methode om de array te vergroten
    static int[] VergrootArray(int[] oudeArray)
    {
        int nieuweGrootte = oudeArray.Length + 1;
        int[] nieuweArray = new int[nieuweGrootte];
        for (int i = 0; i < oudeArray.Length; i++)
        {
            nieuweArray[i] = oudeArray[i];
        }
        Console.WriteLine("Array vergroot naar grootte: " + nieuweGrootte);
        return nieuweArray;
    }

    // Methode om de huidige array te tonen
    static void ToonArray(int[] array, int aantalElementen)
    {
        for (int i = 0; i < aantalElementen; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
