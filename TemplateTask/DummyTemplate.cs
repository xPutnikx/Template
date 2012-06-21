using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTask
{
    class DummyTemplate : ITemplate
    {
        DummyTemplate(string s)
        {
            string patternCycle=@"<%(\s*)for(\s*)\((\s*)int\si(\s*)=(\s*)\d(\s*);(\s*)i(\s*)<(\s*)\d(\s*);(\s*)i\++(\s*)\)(\s*){%>";
            string patternStar=@"%>(\s*)(\w|\W)(\s*)<%";
            string patternFigureBrace=@"<%\}%>";
            char brace='"';
            string patternOutputWriteWithCycle=@"<%(\s*)for(\s*)\((\s*)int\si(\s*)=(\s*)\d(\s*);(\s*)i(\s*)<(\s*)\d(\s*);(\s*)i\++(\s*)\)(\s*){(\s*)output.Write\("+brace+@"(\s*)(\w+|\W+)\"+brace+@"\)(\s*);(\s*)}%>";
            string patternOutputWrite=@"<%(\s*)output.Write\(\"+brace+@"(\s*)(\w+|\W+);(\s*)%>";
            string patternMathOperation=@"<%(\s*)output.Write\((\s*)(\d|\S|(\s*))+(\s*)\)(\s*);(\s*)}%>";
            string patternSimpleMath=@"<%(\s*)(\d|\S|(\s*))+(\s*)%>";
            string patternOpenCode=@"<%";
            string patternCloseCode=@"%>";
        }

        public void Render(StringBuilder output)
        {
            // do nothing.
        }
        static void Main(string[] args)
        {
        }
    }
    
}
