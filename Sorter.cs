/****************************************
 * nazwa funkcji: SortowaniePrzezWybieranie()
 * parametry wejœciowe: int[] array - tablica liczb ca³kowitych do posortowania malej¹co liczby
 * wartoœæ zwracana: funkcja zwraca posortowan¹ tablicê malej¹co
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/

public class Sorter
{
    public void WczytajDaneZKlawiatury(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Podaj liczbê {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public void SortujPrzezWybieranie(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }

    public void WyswietlPosortowanaTablice(int[] array)
    {
        Console.WriteLine("Posortowana tablica:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }

    public void WyswietlNajwyzszaWartosc(int[] array)
    {
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine($"Najwiêksza wartoœæ w tablicy to: {max}");
    }
}
