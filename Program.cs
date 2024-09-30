internal class Program
{
    static void Main(string[] args)
    {
        
        // Tworzymy instancję Random
        Random random = new Random();

        // Losowanie liczby z zakresu 1 do 20
        int losowaLiczba = random.Next(1, 21);

        // Pytamy użytkownika o wybranie liczby
        Console.WriteLine("Wprowadź liczbę od 1 do 20: ");
        int wybranaLiczba;

        // Pętla, która zapewnia, że użytkownik poda poprawną liczbę
        while (!int.TryParse(Console.ReadLine(), out wybranaLiczba) || wybranaLiczba < 1 || wybranaLiczba > 20)
        {
            Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie: ");
          
        }

        // Sprawdzamy, czy liczba losowa jest równa wybranej przez użytkownika
        bool isGood = (losowaLiczba == wybranaLiczba);

        // Wyświetlenie wyniku
        if (isGood)
        {
            Console.WriteLine("To dobra liczba! Wylosowana liczba to: " + losowaLiczba);
        }
        else
        {
            Console.WriteLine("To nie jest dobra liczba. Wylosowana liczba to: " + losowaLiczba);
          
        }
        Console.ReadKey();
    }
    

}
