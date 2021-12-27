using BLL.Model;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFilterService
    {
        void SetCategory(CategoryModel category);
        void SetType(TypeModel type);

        CategoryModel GetCategory();

        TypeModel GetTyping();
        List<EventModel> EventFilter();

        List<EventModel> EventFilter(int categoryId, int typeID);
        List<EventModel> EventFilter(int categoryId, int typeID, List<EventModel> eventModels);

    }
}
