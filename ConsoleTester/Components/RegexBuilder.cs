using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ConsoleTester.Components
{
    public static class RegexBuilder
    {
        private const string WhiteListRegex = @"^[\w0-9,-.%+*#:""\\\|)(&@$'\[\]!?£§\{\}«»\^~]+$";

        private const string BlackListCommonExpression = @"((\%3D)|(=))[^\n]*((\%27)|(\')|(\-\-)|(\%3B)|(;))";

        private const string BlackListSqlProcedures = @"((\%27)|(\'))(union|select|drop|update|delete|Insert)";

        private const string BlackListExecSql = @"/exec(\s|\+)+(s|x)p\w+";

        private const string BlackListOrStatement = @"/\w*((\%27)|(\'))((\%6F)|o|(\%4F))((\%72)|r|(\%52))";




        public static void TestRegex(string value)
        {
            var watch = Stopwatch.StartNew();
            // the code that you want to measure comes here

            var valueToEvaluate = value.ToLower().Replace(" ", "").Replace("--", "-");

            Match blackListMatch = Regex.Match(valueToEvaluate, BlackListCommonExpression);

            Match whiteListMatch = Regex.Match(valueToEvaluate, WhiteListRegex);

            Match blackListExecSql = Regex.Match(valueToEvaluate, BlackListExecSql);

            Match blackListSqlProceduresMatch = Regex.Match(valueToEvaluate, BlackListSqlProcedures);

            if (!(blackListMatch.Success)
                && !(blackListSqlProceduresMatch.Success)
                && !(blackListExecSql.Success)
                && whiteListMatch.Success)
            {
                Console.WriteLine("////////////////////////////////////");
                Console.WriteLine(" ---------- Valor Valido ----------");

            }
            else
            {
                Console.WriteLine("Valor invalido");
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("##################################################");
            Console.WriteLine(String.Format("Tempo de execução: {0} (milisecs)", elapsedMs));
        }
    }
}
