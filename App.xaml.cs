using BLL.Interfaces;
using BLL.Util;
using ESA.Util;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ESA
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("ESADb"));

            IDbOperations dbOperations  = kernel.Get<IDbOperations>();
            IFilterService filterService = kernel.Get<IFilterService>();
            IBagService bagService = kernel.Get<IBagService>();
            IBuyEventService buyEventService = kernel.Get<IBuyEventService>();
            
            MainWindow mainWindow = new MainWindow(dbOperations, filterService, bagService, buyEventService);

            mainWindow.Show();
        }
    }
}
