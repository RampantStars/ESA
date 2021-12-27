using BLL;
using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbOperations>().To<DBDataOperations>();
            Bind<IFilterService>().To<FilterService>();
            Bind<IBagService>().To<BagService>();
            Bind<IBuyEventService>().To<BuyEventService>();
        }
    }
}
