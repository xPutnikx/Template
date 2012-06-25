using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TemplateTask
{
    class ProcessRequest
    {
        RegularDB regularExpression = RegularDB.getInstance();
        private static string pattern;
        public List<Match> responseList = new List<Match>();
        public void request(string s)
        {
            pattern = s;
            equals();
        }
        public List<Match> response()
        {
            return responseList;
        }
        private void equals()
        {
            for(int i=0;i<regularExpression.patternList.Count;i++)
          if(Regex.IsMatch(pattern,regularExpression.patternList[i]))
            {
                responseList.Add(Regex.Match(pattern,regularExpression.patternList[i]));
            }
        }
    }
}
