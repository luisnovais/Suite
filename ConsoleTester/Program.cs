using System;
using System.Collections.Generic;
using ConsoleTester.Components;

namespace ConsoleTester
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var listToTest = new Queue<string>();

            listToTest.Enqueue("#3093:Campanha");
            listToTest.Enqueue("Innohep_verde");
            listToTest.Enqueue("5' or 1=1;update [User] set Description='teste' where Id=20;--");
            listToTest.Enqueue("L'oreal");
            listToTest.Enqueue("''");
            listToTest.Enqueue("--");
            listToTest.Enqueue("5' or 2>1; DrOP database"); //update [User] set Description='totooooo' where Id=20;--
            listToTest.Enqueue("teste \"ola\"");
            listToTest.Enqueue("Ampersand & e @");
            listToTest.Enqueue("teste () brackets and other special chars \\ | ");
            listToTest.Enqueue("5' or 2>1;");

            foreach (var valueFromList in listToTest)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("regex validation: " + valueFromList);
                RegexBuilder.TestRegex(valueFromList);
            }
            
            Console.ReadKey();
        }
    }
}
