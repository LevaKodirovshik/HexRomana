using System;
using System.Collections.Generic;
using System.Linq;

namespace HexRomana.Engine
{
    public static class Extensions
    {
        public static T[] EmptyIfNull<T>(this T[] source) => source ?? Array.Empty<T>();
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source) => source ?? Array.Empty<T>();
        public static T[] ToArrayEmptyIfNull<T>(this IEnumerable<T> source) => source?.ToArray() ?? Array.Empty<T>();
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is null || !source.Any();
    }
}
