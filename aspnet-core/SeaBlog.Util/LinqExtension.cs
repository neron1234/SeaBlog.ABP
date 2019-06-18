using System.Linq;

namespace SeaBlog.Util
{
    public static class LinqExtension
    {
        public static int PageCount<T>(this IQueryable<T> dbSet, int pageSize) where T : class
        {
            var count = dbSet.Count();
            var pageCount = count / pageSize;
            if (count % pageSize > 0)
                pageCount++;
            return pageCount;
        }
    }
}
