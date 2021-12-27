using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;
using BLL.Interfaces;
using DAL.Interface;

namespace BLL.Services
{
    public class FilterService : IFilterService
    {
        IDbRepos dbRepos;

        public FilterService(IDbRepos dbRepos)
        {
            this.dbRepos = dbRepos;
            _category = new CategoryModel() { ID = 6 };
            _type = new TypeModel() { ID = 6 };
        }


        private CategoryModel _category;
        private TypeModel _type;

        public void SetCategory(CategoryModel category) => _category = category;
        public void SetType(TypeModel type) => _type = type;

        public CategoryModel GetCategory() => _category;

        public TypeModel GetTyping() => _type;

        public List<EventModel> EventFilter()
        {
            if (_type.ID == 6 && _category.ID == 6)
                return dbRepos._eventRepository.GetList().Select(i => new EventModel(i)).ToList();
            return dbRepos._eventRepository.GetList().Where(c => c.CategoryID == _category.ID && c.TypeID == _type.ID).ToList().Select(C => new EventModel(C)).ToList();
        }
        public List<EventModel> EventFilter(int categoryId, int typeID)
        {
            List<EventModel> result = dbRepos._eventRepository.GetList().Select(i => new EventModel(i)).ToList();
            if (_type.ID != 6)
            {
                result = result.Where(x => x.TypeID == typeID).ToList();
            }
            if (_category.ID != 6)
            {
                result = result.Where(x => x.CategoryID == categoryId).ToList();
            }
            return result;
        }
        public List<EventModel> EventFilter(int categoryId, int typeID, List<EventModel> eventModels)
        {
            List<EventModel> result = eventModels;
            if (_type.ID != 6)
            {
                result = result.Where(x => x.TypeID == typeID).ToList();
            }
            if (_category.ID != 6)
            {
                result = result.Where(x => x.CategoryID == categoryId).ToList();
            }
            return result;
        }

    }
}
