
class asd
{
    public static List<T> Diff<T>(List<T> a, List<T> b, List<T> c, bool symmetric = false)
    {
        if (symmetric)
        {
            var ab = a.Except(b).Union(b.Except(a)); // A или B
            return ab.Except(c).Union(c.Except(ab)).ToList(); // (A или B) или C
        }
        else
        {
            return a.Except(b).Except(c).ToList();
        }
    }
}

class Program
{
    public static void Main ()
    {
        // Примеры списков
        List<int> setA = new List<int> { 1, 2, 3, 4, 5 };
        List<int> setB = new List<int> { 3, 4, 5, 6, 7 };
        List<int> setC = new List<int> { 5, 7, 8, 9 };

        // Вычисление и вывод простой разности
        List<int> simpleDifference = asd.Diff(setA, setB, setC);
        Console.WriteLine("Простая разность: " + string.Join(", ", simpleDifference));

        // Вычисление и вывод симметрической разности
        List<int> symmetricDifference = asd.Diff(setA, setB, setC, true);
        Console.WriteLine("Симметричная разность: " + string.Join(", ", symmetricDifference));
    }
}

