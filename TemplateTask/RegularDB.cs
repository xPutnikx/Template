using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTask
{
    class RegularDB
    {
        public List<string> patternList=new List<string>();
        private string patternOutputWrite = @"<%(\s*)output.Write\(\""(\s*)(\D+)(\s*)+\""(\s*)\);(\s*)%>";
        private string patternOutputModWrite = @"<%(\s*)}(\s*)output.Write\((\s*)(\w*)(\s*)\);(\s*)}(\s*)%>";
        private string patternMathOperation = @"<%(\s*)output.Write\((\s*)(\d|\S|(\s*))+(\s*)\)(\s*);(\s*)%>";
        private string patternCycle = @"<%(\s*)for(\s*)\((\s*)int(\s)\w*(\s*)=(\s*)\d(\s*);(\s*)i(\s*)<(\s*)\d(\s*);(\s*)\w*\++(\s*)\)\{(\s*)%>";
        private string patternShortCycle=@"<%(\s*)for(\s*)\((\s*)int(\s)\w*(\s*)=(\s*)\d(\s*);(\s*)i(\s*)<(\s*)\d(\s*);(\s*)\w*\++(\s*)%>";
        private string patternOutputWriteWithCycle = @"<%(\s*)for(\s*)\((\s*)int(\s)\w*(\s*)=(\s*)\d*(\s*);(\s*)i(\s*)<(\s*)\d*(\s*);(\s*)\w*\++(\s*)\)(\s*)\{(\s*)output.Write\(""(\s*)(\D*)\""\)(\s*);(\s*)}%>";
        private string patternStar = @"%>(\s*)(\D*)(\s*)<%";
        private string patternFigureAndCircleBrace = @"<%(\s*)\)(\s*){%>";
        private string patternFigureBrace = @"<%(\s*)\}(\s*)%>";
        private string patternSimpleMath = @"<%(\s*)=(\d|\S|(\s*))+(\s*)%>";
        private string patternCycleComponent = @"<%(\s*)=(\s*)\w*(\s*)%>";
        private string patternNamespace = @"<%(\s*)System.Func(\s*)<(\s*)int(\s*)\,(\s*)int(\s*)>(\s*)\w*(\s*)=(\s*)\((\s*)int(\s)\w*(\s*)\)(\s*)=>(\s*)\w*(\s*)\D(\s*)(\d*)(\s*);(\s*)output.Write\((\s*)\w*\((\s*)\d*(\s*)\)(\s*)\)(\s*);(\s*)%>";
        private static RegularDB uniqueInstance;
        private RegularDB(){
            createArray();
        }
        public static RegularDB getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new RegularDB();
            }
                return uniqueInstance;
        }
        private List<string> createArray()
        {
            patternList.Add(patternOutputWrite);
            patternList.Add(patternOutputModWrite);
            patternList.Add(patternMathOperation);
            patternList.Add(patternCycle);
            patternList.Add(patternShortCycle);
            patternList.Add(patternOutputWriteWithCycle);
            patternList.Add(patternStar);
            patternList.Add(patternFigureAndCircleBrace);
            patternList.Add(patternFigureBrace);
            patternList.Add(patternSimpleMath);
            patternList.Add(patternCycleComponent);
            patternList.Add(patternNamespace);
            return patternList;
        }
    }
}
