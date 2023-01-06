using System.Text;

namespace Solutions
{
    public class BreakCamelCase
    {
        public static string Solution(string entry)
        {
            return string.Concat(entry.ToString().Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }
    }
}