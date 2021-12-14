using BLL.Model;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.MVVM.ViewModel
{
    internal class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            var context = new ESADbContext();
            Categories = new ObservableCollection<Category>(context.Category.AsNoTracking());

            Types = new ObservableCollection<BLL.Model.Type>(context.Type.AsNoTracking());
        }

        public ObservableCollection<Category> Categories { get; set; }

        public Category SelectedCategory { get; set; }

        public BLL.Model.Type SelectedType { get; set; }

        public ObservableCollection<BLL.Model.Type> Types { get; set; }



    }
}
