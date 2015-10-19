using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibForStikersDB;
using System.Windows;
using System.ComponentModel;
using Microsoft.Practices.Prism.Commands;

namespace Stikers.ViewModel
{
    public class StikerViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected static Action ItemChanged;
        protected void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            } 
        }
        private int _id;
        private string _type;
        private string _text;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                if (_type != null)
                {
                    OnPropertyChanged("Type");
                }
            }
        }
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                if (_text != null)
                {
                    OnPropertyChanged("Text");
                }
            }
        }
        public DelegateCommand<StikerViewModel> CloseWindow { get; set; }
        public DelegateCommand<StikerViewModel> AddNewWindow { get; set; }
        public DelegateCommand<StikerViewModel> ClickCloud { get; set; }
        public DelegateCommand<StikerViewModel> ClickHeart { get; set; }
        public DelegateCommand<StikerViewModel> ClickStandart { get; set; }
    }
}
