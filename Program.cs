using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];

        // Wczytanie danych z klawiatury
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Podaj liczbę {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Sortowanie malejąco przez wybieranie
        Sorter sorter = new Sorter();
        sorter.SortowaniePrzezWybieranie(array);

        // Wyświetlenie posortowanej tablicy
        Console.WriteLine("Posortowana tablica:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }

        // Wyświetlenie największej wartości w tablicy

        sorter.WyswietlNajwyzszaWartosc(array);
    }
}
