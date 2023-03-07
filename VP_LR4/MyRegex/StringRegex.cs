using System.Text;
using System.Text.RegularExpressions;

namespace MyRegex
{
    public static class StringRegex
    {
        public static int GetPostalIndex(string str)
        {
            Regex rg = new Regex(@"\b\d{6}\b");
            MatchCollection matchedGroups = rg.Matches(str);
            return matchedGroups.Count;
        }

        public static string SwapLetters(string str)
        {
            return Regex.Replace(str, @"\b([а-я])([а-я]+)([а-я])\b", "$3$2$1", RegexOptions.IgnoreCase);
        }

        public static string HidePhoneNumbers(string str)
        {
            //Regex rg = new Regex(@"[+][7][(]\d{3,5}[)]((\d{3}[-]\d{2}[-]\d{2})|(\d{3}[-]\d{3})|(\d{3}[-]\d{2}))");
            //string pattern = @"(?<tag1>[+][7][(]\d{3,5}[)]\d)\d{2}[-](((?<tag2>\d{2}[-]\d{2}))|((?<tag3>\d{3}))|((?<tag4>\d{2})))";
            //var reg = new Regex(pattern);
            //return Regex.Replace(str, pattern, "${tag1}xx-${tag2}${tag3}${tag4}");
            string pattern1 = @"([+][7][(]\d{3,5}[)]\d)\d{2}[-]\d{2}[-]\d{2}";
            string pattern2 = @"([+][7][(]\d{3,5}[)]\d)\d{2}[-]\d{3}";
            string pattern3 = @"([+][7][(]\d{3,5}[)]\d)\d{2}[-]\d{2}";
            string replacement1 = "$1xx-xx-xx";
            string replacement2 = "$1xx-xxx";
            string replacement3 = "$1xx-xx";
            str = Regex.Replace(str, pattern1, replacement1);
            str = Regex.Replace(str, pattern2, replacement2);
            return Regex.Replace(str, pattern3, replacement3);
        }

        public static string GetCarNumbers(string str)
        {
            Regex rg = new Regex(@"\b[АВЕКМНОРСТУХ]{1}\d{3}[АВЕКМНОРСТУХ]{2}((\d{3})|(\d{2}))\b");
            MatchCollection matchedGroups = rg.Matches(str);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matchedGroups.Count; i++)
            {
                sb.Append($"{matchedGroups[i].Value}, ");
            }
            return sb.ToString();
        }
        //sb
        //snils

        public static string GetIPv4(string str)
        {
            Regex rg = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
            MatchCollection matchedGroups = rg.Matches(str);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matchedGroups.Count; i++)
            {
                sb.Append($"{matchedGroups[i].Value}, ");
            }
            return sb.ToString();
        }

        public static string GetSnils(string str)
        {
            Regex rg = new Regex(@"\b(\d{3}-){2}\d{3} \d{2}\b");
            MatchCollection matchedGroups = rg.Matches(str);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matchedGroups.Count; i++)
            {
                sb.Append($"{matchedGroups[i].Value}, ");
            }
            return sb.ToString();
        }
    }
}