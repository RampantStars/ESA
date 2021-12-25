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
    internal class PlaceReposSQL : IRepository<Place>
    {
        private ESADb ESADb;

        public PlaceReposSQL(ESADb eSADb)
        {
            ESADb = eSADb;
        }

        public void Create(Place item)
        {
            ESADb.Place.Add(item);
        }

        public void Delete(int id)
        {
            Place place = ESADb.Place.Find(id);
            if(place != null)
                ESADb.Place.Remove(place);
        }

        public Place GetItem(int id)
        {
            return ESADb.Place.Find(id);
        }

        public List<Place> GetList()
        {
            return ESADb.Place.ToList();
        }

        public void Update(Place item)
        {
            ESADb.Entry(item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return ESADb.SaveChanges() > 0;
        }
    }
}
