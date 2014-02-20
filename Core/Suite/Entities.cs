using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Entities
    {
        private List<Entity> _entitiesList = new List<Entity>();

        public Entities()
        {
        }

        public List<Entity> EntitiesList
        {
            get { return _entitiesList; }
            set { _entitiesList = value; }
        }

        public void AddNewEntity(Entity entity)
        {
            if (entity != null)
            {
                this.EntitiesList.Add(entity);
            }
        }
    }
}
