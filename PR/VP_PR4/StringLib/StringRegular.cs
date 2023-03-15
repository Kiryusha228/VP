namespace StringLib
{
    public static class StringRegular
    {
        public static string RemoveAll(string strFull, string strForDelete)
        {
            return strFull.Replace(strForDelete, "");
        }

        public static string RemoveSpace(string str)
        {
            return String.Join(" ", str.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }
        
        public static string SortWords(string str) 
        {
            var arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(arr);
            return String.Join(" ", arr);
        }
    }
}