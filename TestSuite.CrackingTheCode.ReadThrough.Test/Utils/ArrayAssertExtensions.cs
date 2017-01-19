using System.Collections.Generic;

namespace Should
{
    public static class ArrayAssertExtensions
    {
        public static void ShouldEqual<T>(this T[] actual, params T[] expected)
        {
            ObjectAssertExtensions.ShouldEqual(actual, expected);
        }

        public static void ShouldContain<T>(this IEnumerable<T[]> actual, params T[] expected)
        {
            Should.CollectionAssertExtensions.ShouldContain(actual, expected);
        }
    }
}
