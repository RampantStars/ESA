using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interface;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private ESADb ESADb;
        private CategoryReposSQL CategoryReposSQL;
        private EventOrganizerReposSQL EventOrganizerReposSQL;
        private EventReposSQL EventReposSQL;
        private OrganizerReposSQL OrganizerReposSQL;
        private PlaceReposSQL PlaceReposSQL;
        private RegisterAgeReposSQL RegisterAgeReposSQL;
        private SessionReposSQL SessionReposSQL;
        private StatesReposSQL StatesReposSQL;
        private TypeReposSQL TypeReposSQL;
        private UserReposSQL UserReposSQL;
        private UserSassionsReposSQL UserSassionsReposSQL;

        public DbReposSQL()
        {
            ESADb = new ESADb();
        }

        public IRepository<Category> _categoryRepository
        {
            get
            {
                if (CategoryReposSQL == null)
                    CategoryReposSQL = new CategoryReposSQL(ESADb);
                return CategoryReposSQL;
            }
        }

        public IRepository<User> _userRepository
        {
            get
            {
                if (UserReposSQL == null)
                    UserReposSQL = new UserReposSQL(ESADb);
                return UserReposSQL;
            }
        }

        public IRepository<Event> _eventRepository
        {
            get
            {
                if (EventReposSQL == null)
                    EventReposSQL = new EventReposSQL(ESADb);
                return EventReposSQL;
            }
        }

        public IRepository<EventOrganizers> _eventOrganizersRepository
        {
            get
            {
                if (EventOrganizerReposSQL == null)
                    EventOrganizerReposSQL = new EventOrganizerReposSQL(ESADb);
                return _eventOrganizersRepository;
            }
        }

        public IRepository<Organizer> _organizersRepository
        {
            get
            {
                if (OrganizerReposSQL == null)
                    OrganizerReposSQL = new OrganizerReposSQL(ESADb);
                return OrganizerReposSQL;
            }
        }

        public IRepository<Place> _placeRepository
        {
            get
            {
                if (PlaceReposSQL == null)
                    PlaceReposSQL = new PlaceReposSQL(ESADb);
                return _placeRepository;
            }
        }

        public IRepository<RegisterAge> _registerAgeRepository
        {
            get
            {
                if (RegisterAgeReposSQL == null)
                    RegisterAgeReposSQL = new RegisterAgeReposSQL(ESADb);
                return _registerAgeRepository;
            }
        }

        public IRepository<Session> _sessionRepository
        {
            get
            {
                if (SessionReposSQL == null)
                    SessionReposSQL = new SessionReposSQL(ESADb);
                return _sessionRepository;
            }
        }

        public IRepository<States> _statesRepository
        {
            get
            {
                if (StatesReposSQL == null)
                    StatesReposSQL = new StatesReposSQL(ESADb);
                return _statesRepository;
            }
        }

        public IRepository<EF.Type> _typeRepository
        {
            get
            {
                if (TypeReposSQL == null)
                    TypeReposSQL = new TypeReposSQL(ESADb);
                return _typeRepository;
            }
        }

        public IRepository<UserSessions> _userSessionsRepository
        {
            get
            {
                if (UserSassionsReposSQL == null)
                    UserSassionsReposSQL = new UserSassionsReposSQL(ESADb);
                return _userSessionsRepository;
            }
        }

        public int Save()
        {
            return ESADb.SaveChanges();
        }
    }
}
