using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;
using static BLL.Model.BagModel;
using BLL.Interfaces;

namespace BLL.Services
{
    public class BagService: IBagService
    {
        private BagModel BagModel;

        public BagService(BagModel bagModel)
        {
            BagModel = bagModel;
        }

        public void Add(EventModel eventModel, int countEvent) => BagModel.AddEventBag(eventModel, countEvent);
        public void Del(EventModel eventModel) => BagModel.DeleteEventBag(eventModel);
        public List<line> retr() => BagModel.ReturnLines();
    }
}
