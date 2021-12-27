using ESA.MVVM.View;
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
using BLL.Util;
using ESA.Util;
using Ninject;
using ESA.MVVM.ViewModel;

namespace ESA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDbOperations dbOperations;
        IFilterService filterService;
        IBagService bagService;
        IBuyEventService buyEventService;
        public MainWindow(IDbOperations dbOperations, IFilterService filterService, IBagService bagService,IBuyEventService buyEventService)
        {
            DataContext = new MainViewModel(dbOperations, filterService, bagService, buyEventService);
            InitializeComponent();
            this.bagService = bagService;
            this.dbOperations = dbOperations;
            this.filterService = filterService;
            this.buyEventService = buyEventService;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
           
            
        }
        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (60 * index), 0, 0);
        }

    }
}
