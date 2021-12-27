using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Model.BagModel;

namespace BLL.Interfaces
{
    public interface IBuyEventService
    {
        void BuyEvents(List<line> lines);
    }
}
