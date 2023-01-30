namespace Extensions
{
    public static class StringExtensions
    {
        public static string Cut(this string str, int count)
        {
            if(str.Length <= count)
                return str;
            else
                return $"{str.Substring(0, count)}...";
        }

    }
}