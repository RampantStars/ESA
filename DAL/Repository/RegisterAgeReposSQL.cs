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
    internal class RegisterAgeReposSQL : IRepository<RegisterAge>
    {
        private ESADb ESADb;

        public RegisterAgeReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(RegisterAge item)
        {
            ESADb.RegisterAge.Add(item);
        }

        public void Delete(int id)
        {
            RegisterAge registerAge = ESADb.RegisterAge.Find(id);
            if(registerAge != null)
                ESADb.RegisterAge.Remove(registerAge);
        }

        public RegisterAge GetItem(int id)
        {
            return ESADb.RegisterAge.Find(id);
        }

        public List<RegisterAge> GetList()
        {
            return ESADb.RegisterAge.ToList();
        }

        public void Update(RegisterAge item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
           return ESADb.SaveChanges()>0;
        }
    }
}
