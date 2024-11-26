
public class Massiv
{ 
    public static int[] massiv = { 9, 15, 50, 45, 35, 20 };
    public static int[] massiv2 = { 1, 5, 50, 5, 15, 20 };
    public static int[] SumArrays(int[] arr1, int[] arr2)
    {
        //Объединение 2 массивов
        int[] result = new int[massiv.Length];
        for (int i = 0; i < massiv.Length; i++)
        {
            result[i] = massiv[i] + massiv2[i];
        }
        return result;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("массив: " + string.Join(", ", massiv));
        Console.WriteLine("массив: " + string.Join(", ", massiv2));
        int[] sumArray = SumArrays(massiv, massiv2);
        Console.WriteLine("Сумма массивов: [" + string.Join(", ", sumArray) + "]");
        Sort(massiv);
        Revers(massiv);
        int n;
        Console.Write("Введите целое число n: ");
        n = Convert.ToInt32(Console.ReadLine());
        int result = Calculate(n);
        Console.WriteLine($"Результат: {result}");
    }
    static int Calculate(int n)
    {
        int absi = Math.Abs(n - 123);

        if (n > 123)
        {
            return absi * 3; // Тройная абсолютная разность
        }

        return absi;
    }
    // Сортировка по возрастанию
    public static void Sort(int[] sortmassiv)
    {
        Array.Sort(sortmassiv);
        Console.WriteLine("Отсортированный по возрастанию массив: " + string.Join(", ", sortmassiv));
    }

    // Сортировка по убыванию
    public static void Revers(int[] reversmassiv)
    {
        Array.Sort(reversmassiv);
        Array.Reverse(reversmassiv);
        Console.WriteLine("Отсортированный по убыванию массив: " + string.Join(", ", reversmassiv));

    }
}
