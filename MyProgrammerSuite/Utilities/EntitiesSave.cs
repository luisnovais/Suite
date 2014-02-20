using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace MyProgrammerSuite.Utilities
{
    public class EntitiesSave
    {
        private List<String> scriptLinesListTop = new List<string>();

        private List<String> scriptLinesListBot = new List<string>();

        public EntitiesSave(List<Entity> list)
        {
            CreateScripts(list);
        }

        private void CreateScripts(List<Entity> list)
        {
            foreach (var entity in list)
            {
                scriptLinesListTop.Add("insert into MessageName ([Name]) values ('" + entity.Value + "');");

                scriptLinesListBot.Add(
                    "insert into Message ([LanguageId],[MessageNameId],[Text]) values (132,(select MessageName.Id from MessageName where MessageName.Name = '" +
                    entity.Value + "'),'" + entity.Translation + "');");
            }

        }
    }
}
