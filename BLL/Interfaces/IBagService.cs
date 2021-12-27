using BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Model.BagModel;

namespace BLL.Interfaces
{
    public interface IBagService
    {
        void Add(EventModel eventModel, int countEvent);
        void Del(EventModel eventModel);
        List<line> retr();
    }
}
