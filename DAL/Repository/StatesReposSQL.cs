using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interface;
using System.Data.Entity;

namespace DAL.Repository
{
    internal class StatesReposSQL : IRepository<States>
    {
        private ESADb ESADb;

        public StatesReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(States item)
        {
            ESADb.States.Add(item);
        }

        public void Delete(int id)
        {
            States states = ESADb.States.Find(id);
            if(states != null)
                ESADb.States.Remove(states);
        }

        public States GetItem(int id)
        {
           return ESADb.States.Find(id); 
        }

        public List<States> GetList()
        {
            return ESADb.States.ToList();
        }

        public void Update(States item)
        {
           ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
