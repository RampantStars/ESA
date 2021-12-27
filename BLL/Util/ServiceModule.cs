using DAL.Repository;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using BLL.Model;

namespace BLL.Util
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IDbRepos>().To<DbReposSQL>().InSingletonScope().WithConstructorArgument(connectionString);
            Bind<CategoryModel>().ToSelf();
            Bind<TypeModel>().ToSelf();
            Bind<BagModel>().ToSelf();
           
        }
    }
}
