namespace LINQExtentions
{
    public static class LQExtentions
    {
        public static IEnumerable<TSource> Mix<TSource> 
            (this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            var result = new List<TSource> ();
            int maxCount;
            if (first.Count() > second.Count())
            {
                maxCount = first.Count();
            }
            else
            {
                maxCount = second.Count();
            }

            for (var i = 0; i < maxCount; i++)
            {
                if (first.ElementAt(i) != null)
                {
                    //yield return first.ElementAt(i);
                    result.Add(first.ElementAt(i));
                }
                if (second.ElementAt(i) != null)
                {
                    //yield return second.ElementAt(i);
                    result.Add(second.ElementAt(i));
                }
            }

            return result;
        }

        public static IEnumerable<TSource> Multiply<TSource>(this IEnumerable<TSource> source, int times)
        {
            var result = new List<TSource>();

            for (int i = 0; i < times; i++)
            {
                result.AddRange(source);
            }

            return result;
        }
        public static IEnumerable<TSource> TakeEvery<TSource>(this IEnumerable<TSource> source, int n)
        {
            var result = new List<TSource>();
            int i = 0;
            foreach (var item in source)
            {
                i++;
                if (i % n == 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
        {
            var random = new Random();
            var result = new List<TSource>();
            foreach (var item in source)
            {
                result.Add(item);
            }
            for (int i = 0; i < source.Count(); i++)
            {
                var rnd = random.Next() % result.Count;
                yield return result.ElementAt(rnd);
                result.RemoveAt(rnd);
            }
        }

        public static IEnumerable<TResult> DelegFunc<TSource, TResult>(
            this IEnumerable<TSource> source, Func<TSource, TResult> method)
        {
            var result = new List<TResult>();

            foreach (var item in source)
            {
                result.Add(method(item));
            }

            return result;
        }
    }
}