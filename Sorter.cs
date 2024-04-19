

public class Sorter
{
    /****************************************
 * nazwa funkcji:WczytajDaneZKlawiatury()
 * parametry wejœciowe: int[] array - tablica liczb ca³kowitych do posortowania malej¹co liczby
 * wartoœæ zwracana: Funkcja zwraca tablicê liczb ca³kowitych, które s¹ wprowadzane przez u¿ytkownika z klawiatury
 * 
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/
    public void WczytajDaneZKlawiatury(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Podaj liczbê {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }


 /****************************************
 * nazwa funkcji: SortowaniePrzezWybieranie()
 * parametry wejœciowe: int[] array - tablica liczb ca³kowitych do posortowania malej¹co liczby
 * wartoœæ zwracana: 
 * Funkcja zwraca posortowan¹ tablicê malej¹co, czyli od najwiêkszej do najmniejszej liczby,
 * za pomoca petli for, funkcja porównuje elementy tablicy i zamienia je miejscami
 * jeœli kolejny element jest wiêkszy od aktualnego elementu, to zamienia je miejscami i przechodzi do kolejnego elementu
 * 
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/
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

    /****************************************
 * nazwa funkcji: WyswietlPosortowanaTablice()
 * parametry wejœciowe: int[] array - tablica liczb ca³kowitych do posortowania malej¹co liczby
 * wartoœæ zwracana: Funkcja zwraca posortowan¹ tablicê liczb ca³kowitych w konsoli
 * 
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/
    public void WyswietlPosortowanaTablice(int[] array)
    {
        Console.WriteLine("Posortowana tablica:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }

    /****************************************
 * nazwa funkcji:WyswietlNajwyzszaWartosc()
 * parametry wejœciowe: int[] array - tablica liczb ca³kowitych do posortowania malej¹co liczby
 * wartoœæ zwracana: Funkcja zwraca najwiêksz¹ wartoœæ z tablicy liczb ca³kowitych w konsoli
 * 
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/
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
