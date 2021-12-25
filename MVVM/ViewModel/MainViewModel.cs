using DAL.EF;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace ESA.MVVM.ViewModel
{
    internal class MainViewModel : BindableBase
    { 
        public MainViewModel()
        {
            var context = new ESADb();
            Categories = new ObservableCollection<Category>(context.Category.AsNoTracking());

            Types = new ObservableCollection<DAL.EF.Type>(context.Type.AsNoTracking());
        }

        public ObservableCollection<Category> Categories { get; set; }  

        public Category SelectedCategory { get; set; }

        public DAL.EF.Type SelectedType { get; set; }

        public ObservableCollection<DAL.EF.Type> Types { get; set; }



    }
}
