using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Model;
using DAL.Interface;

namespace BLL
{
    internal class DBDataOperations : IDbOperations
    {
        private IDbRepos db;

        public DBDataOperations(IDbRepos dbRepos)
        {
            db = dbRepos;
        }

        public List<CategoryModel> GetCategories()
        {
            return db._categoryRepository.GetList().Select(c => new CategoryModel(c)).ToList();
        }

        public List<EventModel> GetEvents()
        {
            return db._eventRepository.GetList().Select(c => new EventModel(c)).ToList();
        }

        public List<EventOrganizersModel> GetEventsOrganizers()
        {
            return db._eventOrganizersRepository.GetList().Select(c => new EventOrganizersModel(c)).ToList();
        }

        public List<OrganizerModel> GetOrganizers()
        {
            return db._organizersRepository.GetList().Select(c => new OrganizerModel(c)).ToList();
        }

        public List<PlaceModel> GetPlaces()
        {
            return db._placeRepository.GetList().Select(c => new PlaceModel(c)).ToList();
        }

        public List<RegisterAgeModel> GetRegisterAges()
        {
            return db._registerAgeRepository.GetList().Select(c => new RegisterAgeModel(c)).ToList();
        }

        public List<SessionModel> GetSessions()
        {
            return db._sessionRepository.GetList().Select(c => new SessionModel(c)).ToList();
        }

        public List<StatesModel> GetStates()
        {
            return db._statesRepository.GetList().Select(c => new StatesModel(c)).ToList();
        }

        public List<TypeModel> GetTypes()
        {
            return db._typeRepository.GetList().Select(c => new TypeModel(c)).ToList();
        }

        public List<UserModel> GetUsers()
        {
            return db._userRepository.GetList().Select(c => new UserModel(c)).ToList();
        }

        public List<UserSessionsModel> GetUsersSessions()
        {
            return db._userSessionsRepository.GetList().Select(c => new UserSessionsModel(c)).ToList();
        }
        public void Save()
        {
            db.Save();
        }
    }
}
