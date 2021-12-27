using BLL.Interfaces;
using ESA.MVVM.ViewModel;
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

namespace ESA.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для BuyEventView.xaml
    /// </summary>
    public partial class BuyEventView : Page
    {
        public BuyEventView(IDbOperations dbOperations, IBagService bagService, IFilterService filterService)
        {
            InitializeComponent();
            DataContext = new BuyEventViewModel(dbOperations, bagService, filterService);

        }
       
    }
}
