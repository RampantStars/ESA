using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;

namespace BLL.Interfaces
{
   public interface IDbOperations
    {
        List<CategoryModel> GetCategories();
        List<EventModel> GetEvents();
        List<EventOrganizersModel> GetEventsOrganizers();
        List<OrganizerModel> GetOrganizers();
        List<PlaceModel> GetPlaces();
        List<RegisterAgeModel> GetRegisterAges();
        List<SessionModel> GetSessions();
        List<StatesModel> GetStates();
        List<UserModel> GetUsers();
        List<TypeModel> GetTypes();
        List<UserSessionsModel> GetUsersSessions();
    }
}
