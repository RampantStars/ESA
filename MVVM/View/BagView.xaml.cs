using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL.Interfaces;
using ESA.MVVM.ViewModel;

namespace ESA.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для BagView.xaml
    /// </summary>
    public partial class BagView : Page
    {
        public BagView(IDbOperations dbOperations, IBagService bagService, IFilterService filterService,IBuyEventService buyEventService)
        {
            InitializeComponent();
            DataContext = new BagViewModel(dbOperations, bagService, filterService, buyEventService);

        }
    }
}
