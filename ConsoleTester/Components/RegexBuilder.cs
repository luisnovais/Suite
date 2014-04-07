using System;
using System.Text.RegularExpressions;

namespace ConsoleTester.Components
{
    public static class RegexBuilder
    {
        public static void TestRegex(string value)
        {
            var valueToEvaluate = value.ToLower().Replace(" ","");

            Match match = Regex.Match(valueToEvaluate, @"^[\w0-9,-.]+$");

            //Match match = Regex.Match(valueToEvaluate, @"^[\w*0-9,.-]+$/ix");
            if (match.Success)
            {
                Console.WriteLine("Foram encontradas matchs");
                Console.WriteLine("Valor Valido");
                
            }else
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}
