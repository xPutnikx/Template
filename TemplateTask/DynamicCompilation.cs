using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTask
{
    class DynamicCompilation
    {
        private string EvalCode(string typeName, string methodName, string sourceCode)
        {
            string output = ":)";
            var compiler = CodeDomProvider.CreateProvider("CSharp");
            var parameters = new CompilerParameters
            {
                CompilerOptions = "/t:library",
                GenerateInMemory = true,
                IncludeDebugInformation = true
            };
            var results = compiler.CompileAssemblyFromSource(parameters, sourceCode);

            if (!results.Errors.HasErrors)
            {
                var assembly = results.CompiledAssembly;
                var evaluatorType = assembly.GetType(typeName);
                var evaluator = Activator.CreateInstance(evaluatorType);

                output = (string)InvokeMethod(evaluatorType, methodName, evaluator, new object[] { output });
                return output;
            }

            output = "\r\nHouston, we have a problem at compile time!";
            return results.Errors.Cast<CompilerError>().Aggregate(output, (current, ce) => current + string.Format("\r\nline {0}: {1}", ce.Line, ce.ErrorText));
        }

        [FileIOPermission(SecurityAction.Deny, Unrestricted = true)]
        private object InvokeMethod(Type evaluatorType, string methodName, object evaluator, object[] methodParams)
        {
            return evaluatorType.InvokeMember(methodName, System.Reflection.BindingFlags.InvokeMethod, null, evaluator, methodParams);
        }

    }
}
