using LibForStikersDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stikers.ViewModel
{
    public class ButtonsViewModel : INotifyPropertyChanged
    {
        public DelegateCommand DeleteWindow { get; set; }
        public DelegateCommand AddNewWindow { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged (string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
            ItemChanged.Invoke();
            IsChanged = true;
        }
        protected static Action ItemChanged;
        public bool IsChanged { get; set; }
        protected virtual void DeleteFromDB() { }
        protected virtual void AddWindow() { }
        protected virtual void FillData() { }
    }
}
