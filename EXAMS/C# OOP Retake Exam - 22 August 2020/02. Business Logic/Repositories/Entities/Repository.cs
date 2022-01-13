using System.Collections.Generic;
using System.Linq;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class Repository<T> : IRepository<T>
    {
        private ICollection<T> models;

        protected Repository()
        {
            models = new List<T>();
        }


        public void Add(T model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return models.ToList().AsReadOnly();
        }

        public T GetByName(string name)
        {
            T entity = models.FirstOrDefault(x => x.GetType().Name == name);
            return entity;
        }

        public bool Remove(T model)
        {
            return models.Remove(model);
        }
    }
}
