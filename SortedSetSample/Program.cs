namespace SortedSetSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10};
            
            Console.Write("A: ");
            PrintCollection(a);

            Console.Write("B: ");
            PrintCollection(b);

            Console.Write("A or B: ");
            SortedSet<int> u = new SortedSet<int>(a);
            u.UnionWith(b);
            PrintCollection(u);

            Console.Write("A and B: ");
            SortedSet<int> i = new SortedSet<int>(a);
            i.IntersectWith(b);
            PrintCollection(i);

            Console.Write("A xor B: ");
            SortedSet<int> x = new SortedSet<int>(a);
            x.ExceptWith(b);
            PrintCollection(x);

            Console.Write("B xor A: ");
            SortedSet<int> x2 = new SortedSet<int>(b);
            x2.ExceptWith(a);
            PrintCollection(x2);
            
            Console.ReadKey();
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                 Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}