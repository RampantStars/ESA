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
using System.Windows;

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
            if (_event.IsNew)
            {
                Events.Where(i => i.ID == _event.ID).FirstOrDefault().IsNew = false;
                _event.IsNew = false;
                dbOperations.Update(_event);
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
            bagService.Add(_event, int.Parse(countEvent));
        }

        public ICommand ISNewCommand => new RelayCommand(o => IsNewFunc());

        public ICommand BagCommand => new RelayCommand(o => AddEventBag());

        public CategoryModel CurrentCategory { get; set; }
        public TypeModel CurrentType { get; set; }
        public List<EventModel> Events => filterService.EventFilter(CurrentCategory != null ? CurrentCategory.ID : 0, CurrentType != null ? CurrentType.ID : 0);

        public string NumberAge
        {
            get
            {
                if (_event != null)
                    return dbOperations.GetRegisterAges().Find(i => i.ID == _event.RegisterAgeID).Age.ToString() + '+';
                else return null;
            }
        }

        public string countEvent { get; set; }

        public string IsEnablEvent
        {
            get
            {

                if (_event != null && _event.QuantityAll > 0)
                    return "True";
                else
                    return "False";
            }
        }

        public bool FavoriteButton
        {
            get
            {
                if (_event != null)
                {
                    if (_event.IsFavourite != dbOperations.GetEventId(_event.ID).IsFavourite)
                    {
                        dbOperations.Update(_event);
                    }
                    return _event.IsFavourite;
                }
                else
                    return false;

            }
            set
            {
                if (_event != null)
                {

                    _event.IsFavourite = value;
                }
            }
        }

        public string Visible
        {
            get
            {
                if (_event != null)
                    return "Visible";
                else return "Hidden";
            }
        }

        private EventModel _event;
        public EventModel Event
        {
            get
            {
                if (_event != null)
                    return _event;
                else
                    return null;
            }
            set
            {
                _event = value;
                //if (_event != null
                //    && _event.IsFavourite == dbOperations.GetEventId(_event.ID).IsFavourite)
                //{

                //    _event.IsFavourite = !_event.IsFavourite;
                //    dbOperations.Update(_event);
                //}
            }
        }

    }
}
