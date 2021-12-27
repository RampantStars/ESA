using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class BagModel
    {
        private List<line> lines;

        public BagModel()
        {
            lines = new List<line>();

        }

        public void AddEventBag(EventModel eventModel, int countEvent)
        {
            lines.Add(new line(eventModel, countEvent));
        }

        public void DeleteEventBag(EventModel eventModel)
        {
            lines.Remove(lines.Find(i => i.EventModel.ID == eventModel.ID));
        }

        public List<line> ReturnLines()
        {
            return lines;
        }


        public class line
        {
            public EventModel EventModel;
            public int CountEvent;

            public line(EventModel eventModel, int countEvent)
            {
                EventModel = eventModel;
                CountEvent = countEvent;
            }
        }
    }
}
