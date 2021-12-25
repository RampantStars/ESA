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
    internal class EventOrganizerReposSQL : IRepository<EventOrganizers>
    {
        private ESADb ESADb;

        public EventOrganizerReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(EventOrganizers item)
        {
            ESADb.EventOrganizers.Add(item);
        }

        public void Delete(int id)
        {
            EventOrganizers eventOrganizers = ESADb.EventOrganizers.Find(id);
            if(eventOrganizers != null)
                ESADb.EventOrganizers.Remove(eventOrganizers);
        }

        public EventOrganizers GetItem(int id)
        {
            return ESADb.EventOrganizers.Find(id);
        }

        public List<EventOrganizers> GetList()
        {
            return ESADb.EventOrganizers.ToList();
        }

        public void Update(EventOrganizers item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges()>0;
        }
    }
}
