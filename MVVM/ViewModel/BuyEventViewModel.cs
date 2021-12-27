using BLL.Interfaces;
using BLL.Model;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESA.MVVM.ViewModel
{
    public class BuyEventViewModel: BindableBase
    {

        IDbOperations dbOperations;
        IBagService bagService;
        IFilterService filterService;

        public BuyEventViewModel(IDbOperations dbOperations, IBagService bagService, IFilterService filterService)
        {
            this.dbOperations = dbOperations;
            this.bagService = bagService;
            this.filterService = filterService;

            TypeModel typeModel = filterService.GetTyping();
            CategoryModel categoryModel = filterService.GetCategory();
            MainViewModel.CategoryChanged += (category) => { CurrentCategory = category; };
            MainViewModel.TypeChanged += (type) => { CurrentType = type; };


        }
        public string NumberAge
        {
            get
            {
                if (Event != null)
                    return dbOperations.GetRegisterAges().Find(i => i.ID == Event.RegisterAgeID).Age.ToString() + '+';
                else return null;
            }
        }
        public string Visible
        {
            get
            {
                if (Event != null)
                    return "Visible";
                else return "Hidden";
            }
        }

        private int _countEvent;


        public int countEvent
        {
            get
            {
                var result = bagService.retr().Where(x => x.EventModel.ID == Event.ID).FirstOrDefault();
                if (result != null)
                    return result.CountEvent;
                else
                    return 0;
            }
            set { _countEvent = value; }
        }



        public CategoryModel CurrentCategory { get; set; }
        public TypeModel CurrentType { get; set; }

        public List<EventModel> Events => filterService.EventFilter(CurrentCategory != null ? CurrentCategory.ID : 0, CurrentType != null ? CurrentType.ID : 0, bagService.retr().Select(i => i.EventModel).ToList());
        public EventModel Event { get; set; }
    }

}
