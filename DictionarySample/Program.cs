namespace DictionarySample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "limonada";
            cookies["email"] = "limonada@gmail.com";
            cookies["phone"] = "911345678910";

            foreach (KeyValuePair<string, string> item in cookies)
                Console.WriteLine($"{item.Key}: {item.Value}");

            if (cookies.Remove("email"))
                Console.WriteLine("\nEmail key removed");

            foreach (KeyValuePair<string, string> item in cookies)
                Console.WriteLine($"{item.Key}: {item.Value}");

            Console.ReadKey();
        }
    }
}