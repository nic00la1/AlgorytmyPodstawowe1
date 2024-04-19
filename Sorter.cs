

public class Sorter
{
    /****************************************
 * nazwa funkcji:WczytajDaneZKlawiatury()
 * parametry wej�ciowe: int[] array - tablica liczb ca�kowitych do posortowania malej�co liczby
 * warto�� zwracana: Funkcja zwraca tablic� liczb ca�kowitych, kt�re s� wprowadzane przez u�ytkownika z klawiatury
 * 
 * autor: Nicola Kaleta - klasa 3D
 ****************************************/
    public void WczytajDaneZKlawiatury(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Podaj liczb� {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }


 /****************************************
 * nazwa funkcji: SortowaniePrzezWybieranie()
 * parametry wej�ciowe: int[] array - tablica liczb ca�kowitych do posortowania malej�co liczby
 * warto�� zwracana: 
 * Funkcja zwraca posortowan� tablic� malej�co, czyli od najwi�kszej do najmniejszej liczby,
 * za pomoca petli for, funkcja por�wnuje elementy tablicy i zamienia je miejscami
 * je�li kolejny element jest wi�kszy od aktualnego elementu, to zamienia je miejscami i przechodzi do kolejnego elementu
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
 * parametry wej�ciowe: int[] array - tablica liczb ca�kowitych do posortowania malej�co liczby
 * warto�� zwracana: Funkcja zwraca posortowan� tablic� liczb ca�kowitych w konsoli
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
 * parametry wej�ciowe: int[] array - tablica liczb ca�kowitych do posortowania malej�co liczby
 * warto�� zwracana: Funkcja zwraca najwi�ksz� warto�� z tablicy liczb ca�kowitych w konsoli
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

        Console.WriteLine($"Najwi�ksza warto�� w tablicy to: {max}");
    }
}
