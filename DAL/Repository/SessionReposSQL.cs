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
    internal class SessionReposSQL : IRepository<Session>
    {
        private ESADb ESADb;

        public SessionReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(Session item)
        {
            ESADb.Session.Add(item);
        }

        public void Delete(int id)
        {
            Session session = ESADb.Session.Find(id);
            if (session != null)
                ESADb.Session.Remove(session);
        }

        public Session GetItem(int id)
        {
            return ESADb.Session.Find(id);
        }

        public List<Session> GetList()
        {
            return ESADb.Session.ToList();
        }

        public void Update(Session item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges()>0;
        }
    }
}
