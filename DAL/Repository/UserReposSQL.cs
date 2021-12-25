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
    internal class UserReposSQL : IRepository<User>
    {
        private ESADb ESADb;

        public UserReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(User item)
        {
            ESADb.User.Add(item);
        }

        public void Delete(int id)
        {
            User user = ESADb.User.Find(id);
            if (user != null)
                ESADb.User.Remove(user);
        }

        public User GetItem(int id)
        {
            return ESADb.User.Find(id);
        }

        public List<User> GetList()
        {
            return new List<User>();
        }

        public void Update(User item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
