using BLL.Interfaces;
using BLL.Model;
using DevExpress.Mvvm;
using ESA.Core;
using ESA.MVVM.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ESA.MVVM.ViewModel
{

    internal class MainViewModel : ObservableObject
    {
        IDbOperations dbOperations;
        IFilterService filterService;
        IBagService bagService;
        IBuyEventService buyEventService;
        private TypeModel _selectedType;

        public ObservableCollection<TypeModel> Types { get; set; }


        private HomePage HomePage;
        private AccountView AccountPage;
        private BagView BagView;
        private BuyEventView BuyEventView;


        public Page CurrentPage { get; set; }


        public static event Action<CategoryModel> CategoryChanged;
        public static event Action<TypeModel> TypeChanged;
        public MainViewModel(IDbOperations dbOperations, IFilterService filterService, IBagService bagService, IBuyEventService buyEventService)
        {

            Categories = new ObservableCollection<CategoryModel>(dbOperations.GetCategories());

            Types = new ObservableCollection<TypeModel>(dbOperations.GetTypes());

            this.filterService = filterService;
            SelectedCategory = Categories.FirstOrDefault(x => x.ID == 6);
            SelectedType = Types.FirstOrDefault(x => x.ID == 6);



            HomePage = new HomePage(dbOperations, filterService, bagService);
            AccountPage = new AccountView(dbOperations);
            BagView = new BagView(dbOperations, bagService, filterService, buyEventService);
            BuyEventView = new BuyEventView(dbOperations, bagService, filterService);
            CurrentPage = HomePage;


        }
        public ICommand HomeViewCommand => new RelayCommand(o =>
        {
            CurrentPage = HomePage;
        });

        public ICommand AccountViewCommand => new RelayCommand(o =>
        {
            CurrentPage = AccountPage;
        });

        public ICommand BagCommand => new RelayCommand(o =>
          {
              CurrentPage = BagView;
          });
        public ICommand BuyCommand => new RelayCommand(o =>
          {
              CurrentPage = BuyEventView;
          });


        public ObservableCollection<CategoryModel> Categories { get; set; }

        public CategoryModel SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                filterService.SetCategory(value);
                CategoryChanged?.Invoke(value);
            }
        }
        private CategoryModel _selectedCategory;

        public TypeModel SelectedType
        {
            get { return _selectedType; }
            set
            {
                _selectedType = value;
                filterService.SetType(value);
                TypeChanged?.Invoke(value);
            }
        }


    }
}
