using System.Text;

namespace Solutions
{
    public class BreakCamelCase : BaseSolution<String>
    {
        public override string Handle(object obj)
        {
            return string.Concat(obj.ToString().Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }
    }
}