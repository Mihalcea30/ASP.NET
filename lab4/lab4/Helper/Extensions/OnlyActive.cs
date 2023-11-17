using lab4.Models;

namespace lab4.Helper.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<Car> GetActiveCar(this IQueryable<Car> query)
        {
            return query.Where(x => !x.IsDeleted);
        }
    }
}
