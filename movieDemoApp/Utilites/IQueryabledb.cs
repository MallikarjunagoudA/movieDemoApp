namespace movieDemoApp.Utilites
{
    public static class IQueryabledb
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> source, int page, int recordTake)
        {
            return source.Skip((page - 1) * recordTake).Take(recordTake);
        }
    }
}
