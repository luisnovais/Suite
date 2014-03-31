using System;
using System.Collections.Generic;
using Core.Suite;

namespace MyProgrammerSuite.Utilities
{
    public class EntitiesSave
    {
        private List<String> _scriptLinesListTop = new List<string>();

        private List<String> _scriptLinesListBot = new List<string>();

        public EntitiesSave(IEnumerable<Entity> list)
        {
            CreateScripts(list);
        }

        public List<string> ScriptLinesListTop
        {
            get { return _scriptLinesListTop; }
            set { _scriptLinesListTop = value; }
        }

        public List<string> ScriptLinesListBot
        {
            get { return _scriptLinesListBot; }
            set { _scriptLinesListBot = value; }
        }

        private void CreateScripts(IEnumerable<Entity> list)
        {
            foreach (var entity in list)
            {
                ScriptLinesListTop.Add("insert into MessageName ([Name]) values ('" + entity.Value + "');");

                ScriptLinesListBot.Add(
                    "insert into Message ([LanguageId],[MessageNameId],[Text]) values (132,(select MessageName.Id from MessageName where MessageName.Name = '" +
                    entity.Value + "'),'" + entity.Translation + "');");
            }

        }
    }
}
