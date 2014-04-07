using System;
using ConsoleTester.Components;

namespace ConsoleTester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string valor = "àÁca-nçãod_ASSDASDASD [ASDsdasdsdsd.,,-asfasfsdf";
            RegexBuilder.TestRegex(valor);
            Console.ReadKey();
        }
    }
}
