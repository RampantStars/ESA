using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ESA.Core;

namespace ESA.MVVM.ViewModel
{
    internal class HomeViewModel : BindableBase
    {
        IFilterService filterService;
        IDbOperations dbOperations;
        IBagService bagService;

        #region Новые события

        public void IsNewFunc()
        {
            if (Event.IsNew)
            {
                Events.Where(i => i.ID == Event.ID).FirstOrDefault().IsNew = false;
                Event.IsNew = false;
                dbOperations.Update(Event);
            }
        }
        #endregion


        public HomeViewModel(IDbOperations dbOperations, IFilterService filterService, IBagService bagService)
        {
            this.dbOperations = dbOperations;
            this.filterService = filterService;
            this.bagService = bagService;

            TypeModel typeModel = filterService.GetTyping();
            CategoryModel categoryModel = filterService.GetCategory();
            MainViewModel.CategoryChanged += (category) => { CurrentCategory = category; };
            MainViewModel.TypeChanged += (type) => { CurrentType = type; };

        }

        private void AddEventBag()
        {
            bagService.Add(Event,int.Parse(countEvent));
        }

        public ICommand BagCommand => new RelayCommand(o =>AddEventBag());

        public CategoryModel CurrentCategory { get; set; }
        public TypeModel CurrentType { get; set; }
        public List<EventModel> Events => filterService.EventFilter(CurrentCategory!=null? CurrentCategory.ID:0, CurrentType!=null?CurrentType.ID:0);

        public string NumberAge
        {
            get
            {
                if (Event != null)
                    return dbOperations.GetRegisterAges().Find(i => i.ID == Event.RegisterAgeID).Age.ToString() + '+';
                else return null;
            }
        }

        public string countEvent { get; set; }

        public string Visible
        {
            get
            {
                if (Event != null)
                    return "Visible";
                else return "Hidden";
            }
        }

        public EventModel Event { get; set; }

    }
}
