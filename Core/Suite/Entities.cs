using System.Collections.Generic;

namespace Core.Suite
{
    public class Entities
    {
        private List<Entity> _entitiesList = new List<Entity>();

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
