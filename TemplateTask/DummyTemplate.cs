using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TemplateTask
{
    class DummyTemplate : ITemplate
    {
        private static List<Match> operationList = new List<Match>();
        StringBuilder output = new StringBuilder();
        public DummyTemplate(string s)
        {
            var processRequest = new ProcessRequest();
            processRequest.request(s);
            operationList=processRequest.response();
            Render(output);
        }

        public DummyTemplate()
        {
            // TODO: Complete member initialization
        }
        public void Render(StringBuilder output)
        {
            for (int i = 0; i < operationList.Count; i++)
            {
                output.Append(operationList[i]);
                Console.WriteLine(output);
            }
        }
        static void Main(string[] args)
        {
            var template = new DummyTemplate(@"<%for(int i=0; i < 5; i++){%>*<%}%>");
        }
    }
    
}
