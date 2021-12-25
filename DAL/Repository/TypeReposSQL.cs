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
    internal class TypeReposSQL : IRepository<EF.Type>
    {
        private ESADb ESADb;

        public TypeReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(EF.Type item)
        {
            ESADb.Type.Add(item);
        }

        public void Delete(int id)
        {
            EF.Type type = ESADb.Type.Find(id);
            if (type != null)
                ESADb.Type.Remove(type);
        }

        public EF.Type GetItem(int id)
        {
            return ESADb.Type.Find(id);
        }

        public List<EF.Type> GetList()
        {
            return ESADb.Type.ToList();
        }

        public void Update(EF.Type item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
