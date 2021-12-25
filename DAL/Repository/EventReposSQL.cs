using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interface;

namespace DAL.Repository
{
    internal class EventReposSQL : IRepository<Event>
    {
        private ESADb ESADb;

        public EventReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(Event item)
        {
            ESADb.Event.Add(item);
        }

        public void Delete(int id)
        {
            Event @event = ESADb.Event.Find(id);
            if (@event != null)
                ESADb.Event.Remove(@event);
        }

        public Event GetItem(int id)
        {
            return ESADb.Event.Find(id);
        }

        public List<Event> GetList()
        {
            return ESADb.Event.ToList();
        }

        public void Update(Event item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
