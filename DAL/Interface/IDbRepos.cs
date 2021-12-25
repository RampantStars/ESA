using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL.Interface
{
    public interface IDbRepos
    {
        IRepository<Category> _categoryRepository { get; }
        IRepository<User> _userRepository { get; }
        IRepository<Event> _eventRepository { get; }
        IRepository<EventOrganizers> _eventOrganizersRepository { get; }
        IRepository<Organizer> _organizersRepository { get; }
        IRepository<Place> _placeRepository { get; }
        IRepository<RegisterAge> _registerAgeRepository { get; }
        IRepository<Session> _sessionRepository { get; }
        IRepository<States> _statesRepository { get; }
        IRepository<EF.Type> _typeRepository { get; }
        IRepository<UserSessions> _userSessionsRepository { get; }

        int Save();
    }
}
