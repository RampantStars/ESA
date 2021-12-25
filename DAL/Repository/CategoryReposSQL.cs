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
    internal class CategoryReposSQL : IRepository<Category>
    {
        private ESADb ESADb;
        public CategoryReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(Category item)
        {
            ESADb.Category.Add(item);
        }

        public void Delete(int id)
        {
            Category category = ESADb.Category.Find(id);
            if (category != null)
                ESADb.Category.Remove(category);

        }

        public Category GetItem(int id)
        {
            return ESADb.Category.Find(id);
        }

        public List<Category> GetList()
        {
            return ESADb.Category.ToList();
        }

        public void Update(Category item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
