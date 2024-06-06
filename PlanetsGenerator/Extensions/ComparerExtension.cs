namespace PlanetsGenerator.Extensions
{
    public static class ComparerExtension
    {
        public static bool IsBetween<T>(this T item, T start, T end) where T : IComparable
        {
            return Comparer<T>.Default.Compare(item, start) >= 0
                && Comparer<T>.Default.Compare(item, end) <= 0;
        }
    }
}
