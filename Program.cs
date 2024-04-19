using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Sorter sorter = new Sorter();

        sorter.WczytajDaneZKlawiatury(array);
        sorter.SortujPrzezWybieranie(array);
        sorter.WyswietlPosortowanaTablice(array);
        sorter.WyswietlNajwyzszaWartosc(array);
    }
}
