/****************************************
 * nazwa funkcji: SortowaniePrzezWybieranie()
 * parametry wej�ciowe: int[] array - tablica liczb ca�kowitych do posortowania malej�co liczby
 * warto�� zwracana: funkcja zwraca posortowan� tablic� malej�co
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/

public class Sorter
{
    public void WczytajDaneZKlawiatury(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Podaj liczb� {i + 1}: ");
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

        Console.WriteLine($"Najwi�ksza warto�� w tablicy to: {max}");
    }
}
