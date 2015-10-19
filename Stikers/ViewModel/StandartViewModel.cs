using LibForStikersDB;
using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Stikers.ViewModel
{
    public class StandartViewModel : ButtonsViewModel 
    {
        public ObservableCollection<StikerInfo> StikerCollection { get; set; }
        public StandartViewModel()
        {
            StikerCollection = new ObservableCollection<StikerInfo>();
            DeleteWindow = new DelegateCommand(DeleteFromDB);
            AddNewWindow = new DelegateCommand(AddWindow);
            ItemChanged = StikersChanged;
            FillData();
        }

        protected override void FillData()
        {
            using (var db = new StikerModel())
            {
                foreach (var stiker in db.StikerInfoes)
                {
                    StikerCollection.Add(stiker);
                }
            }
        }

        private void StikersChanged()
        {
            if (StikerCollection.Count == 0)
            {
                using (var db = new StikerModel())
                {
                    var newStiker = new StikerInfo()
                    {
                        StikerType = _typeStandart,
                        Text = _textBoxStandart
                    };
                    db.StikerInfoes.Add(newStiker);
                    db.SaveChanges();
                    StikerCollection.Add(newStiker);
                }                
            }
            else
            {
                for (int i = 0; i < StikerCollection.Count - 1; i++)
                {
                    using (var db = new StikerModel())
                    {
                        StikerCollection[i].StikerType = _typeStandart;
                        StikerCollection[i].Text = _textBoxStandart;
                        db.SaveChanges();
                    }
                }
            }
            
        }


        int _idStandart;
        public int IdStandart { 
            get { return _idStandart;}
            set 
            { 
                _idStandart = value;
                OnPropertyChanged("IdStandart");
            }
        }
        string _typeStandart = "standart";
        public string TypeStandart
        {
            get { return _typeStandart; }
        }
        string _textBoxStandart;
        public string TextBoxStandart
        {
            get { return _textBoxStandart; }
            set 
            { 
                _textBoxStandart = value;
                OnPropertyChanged("TextBoxStandart");         
            }
        }
        protected override void AddWindow()
        {
            WindowStandart windowFirst = new WindowStandart();
            windowFirst.Show();
        }

        protected override void DeleteFromDB()
        {
            using (var db = new StikerModel())
            {
                var findStikers = db.StikerInfoes.FirstOrDefault(stiker => stiker.Id == IdStandart);
                if (findStikers != null)
                {
                    db.StikerInfoes.Remove(findStikers);
                    db.SaveChanges();
                }
            }
            
        }

    }
}
