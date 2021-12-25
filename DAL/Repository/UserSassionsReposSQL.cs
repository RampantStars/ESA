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
    internal class UserSassionsReposSQL : IRepository<UserSessions>
    {
        private ESADb ESADb;

        public UserSassionsReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(UserSessions item)
        {
            ESADb.UserSessions.Add(item);
        }

        public void Delete(int id)
        {
            UserSessions userSessions = ESADb.UserSessions.Find(id);
            if (userSessions != null)
                ESADb.UserSessions.Remove(userSessions);
        }

        public UserSessions GetItem(int id)
        {
            return ESADb.UserSessions.Find(id);
        }

        public List<UserSessions> GetList()
        {
            return ESADb.UserSessions.ToList();
        }

        public void Update(UserSessions item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
