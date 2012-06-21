using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTask
{
    interface ITemplate
    {
        void Render(StringBuilder output);
    }
}
