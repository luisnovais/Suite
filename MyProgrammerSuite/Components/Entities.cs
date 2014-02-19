using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammerSuite.Components
{
    public class Entities
    {
        private List<Entity> _entitiesList = new List<Entity>();


        public List<Entity> EntitiesList
        {
            get { return _entitiesList; }
            set { _entitiesList = value; }
        }

        public Entities()
        {
        }
    }
}
