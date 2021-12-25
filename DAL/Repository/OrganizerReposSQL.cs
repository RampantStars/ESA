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
    internal class OrganizerReposSQL : IRepository<Organizer>
    {

        private ESADb ESADb;

        public OrganizerReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(Organizer item)
        {
            ESADb.Organizer.Add(item);
        }

        public void Delete(int id)
        {
            Organizer organizer = ESADb.Organizer.Find(id);
            if(organizer != null)
                ESADb.Organizer.Remove(organizer);
        }

        public Organizer GetItem(int id)
        {
            return ESADb.Organizer.Find(id);
        }

        public List<Organizer> GetList()
        {
            return ESADb.Organizer.ToList();
        }

        public void Update(Organizer item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
