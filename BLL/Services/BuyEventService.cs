using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Model.BagModel;
using DAL.Interface;
using BLL.Interfaces;

namespace BLL.Services
{
    public class BuyEventService : IBuyEventService
    {
        IDbRepos dbRepos;

        public BuyEventService(IDbRepos dbRepos)
        {
            this.dbRepos = dbRepos;
        }

        public void BuyEvents(List<line> lines)
        {
            int summ = 0;
            foreach(var line in lines)
            {
                summ += line.CountEvent * line.EventModel.Price;
                dbRepos._eventRepository.GetItem(line.EventModel.ID).QuantityAll-=line.CountEvent;
            }
            if (summ > 2000)
                summ = (int)(summ*0.9);

            dbRepos._userRepository.GetItem(1).Money-=summ;
            dbRepos.Save();
        }
    }

    
}
