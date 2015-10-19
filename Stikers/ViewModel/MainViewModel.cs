using LibForStikersDB;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Stikers.ViewModel
{
    public class MainViewModel
    {
        public DelegateCommand<StikerViewModel> AddNewWindow{ get; set; }
        public DelegateCommand<StikerViewModel> CloseWindow { get; set; }
        public DelegateCommand<StikerViewModel> ClickStandart { get; set; }
        public DelegateCommand<StikerViewModel> ClickCloud { get; set; }
        public DelegateCommand<StikerViewModel> ClickHeart { get; set; }
        public List<StikerModel> StikerList { get; set; }
        public List<Window> WindowList { get; set; }
        StikerContext _context = new StikerContext();
        public MainViewModel()
        {
            StikerList = new List<StikerModel>();
            WindowList = new List<Window>();
            AddNewWindow = new DelegateCommand<StikerViewModel>(AddWindow);
            CloseWindow = new DelegateCommand<StikerViewModel>(DeleteFromDB);
            ClickStandart = new DelegateCommand<StikerViewModel>(ToStandart);
            ClickCloud = new DelegateCommand<StikerViewModel>(ToCloud);
            ClickHeart = new DelegateCommand<StikerViewModel>(ToHeart);             
            LoadStikers();
        }
        private void LoadStikers()
        {
            foreach (var stiker in _context.StikerModels)
            {
                if (stiker.Text!= null)
                {
                    StikerList.Add(stiker);
                }                    
            }           
            if (StikerList.Count() == 0)
            {
                CreateWindow(new WindowStandart(),0, SetWindowType(WindowType.Standart), null);
            }
            else
            {
                foreach (var stiker in StikerList)
                {
                    if (stiker.Type == SetWindowType(WindowType.Standart))
                    {
                        CreateWindow(new WindowStandart(), stiker.Id, stiker.Type, stiker.Text);
                    }
                    else if (stiker.Type == SetWindowType(WindowType.Cloud))
                    {
                        CreateWindow(new WindowCloud(), stiker.Id, stiker.Type, stiker.Text);
                    }
                    else if (stiker.Type == SetWindowType(WindowType.Heart))
                    {
                        CreateWindow(new WindowHeart(), stiker.Id, stiker.Type, stiker.Text);
                    }
                }
            }
        }
        private void CreateWindow(Window window, int id, string type, string text)
        {
            var _viewModel = new StikerViewModel { Id = id, Type = type, Text = text };
            if (_viewModel.Id == 0)
            {
                _viewModel = Save(_viewModel);
            }
            _viewModel.PropertyChanged += window_PropertyChanged;
            _viewModel.CloseWindow = this.CloseWindow;
            _viewModel.AddNewWindow = this.AddNewWindow;
            _viewModel.ClickStandart = this.ClickStandart;
            _viewModel.ClickCloud = this.ClickCloud;
            _viewModel.ClickHeart = this.ClickHeart;            
            window.DataContext = _viewModel;
            window.Show();
            WindowList.Add(window);
                
        }
        private StikerViewModel Save(StikerViewModel _viewModel)
        {
            var newStiker = new StikerModel() { Id = _viewModel.Id, Type = _viewModel.Type, Text = _viewModel.Text };
            _context.StikerModels.Add(newStiker);
            _context.SaveChanges();
            return _viewModel = new StikerViewModel { Id = newStiker.Id, Type= newStiker.Type, Text=newStiker.Text };
        }
        private void window_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Type")
            {
                ChangeType((StikerViewModel)sender);
            }
            else if (e.PropertyName =="Text")
            {
                ChangeText((StikerViewModel)sender);
            }
        }
        private void ChangeType(StikerViewModel _viewModel)
        {
            if (_viewModel.Type != null)
            {
                var findStiker = _context.StikerModels.FirstOrDefault(stiker => stiker.Id == _viewModel.Id);
                if (findStiker != null)
                {
                    findStiker.Type = _viewModel.Type;
                    _context.SaveChanges();
                }
                else
                {
                    var newStiker = new StikerModel() { Type = _viewModel.Type, Text = _viewModel.Text };
                    _context.StikerModels.Add(newStiker);
                    _context.SaveChanges();
                }
            }            
        }
        private void ChangeText(StikerViewModel _viewModel)
        {
            if (_viewModel.Type != null && _viewModel.Text != null)
            {
                var findStiker = _context.StikerModels.FirstOrDefault(stiker => stiker.Id == _viewModel.Id);
                if (findStiker != null)
                {
                    findStiker.Text = _viewModel.Text;
                    _context.SaveChanges();
                }
                else
                {
                    var newStiker = new StikerModel() { Type = _viewModel.Type, Text = _viewModel.Text };
                    _context.StikerModels.Add(newStiker);
                    _context.SaveChanges();
                }
            }
        }
        private string SetWindowType(WindowType windowType)
        {
            string type = null;
            if (windowType == WindowType.Standart)
            {
                type = "standart";
            }
            else if (windowType == WindowType.Cloud)
            {
                type = "cloud";
            }
            else if (windowType == WindowType.Heart)
            {
                type = "heart";
            }
            return type;
        }
        private enum WindowType
        {
            Standart,
            Cloud,
            Heart
        };       
        private void AddWindow(StikerViewModel _viewModel)
        {
            if (_viewModel.Type == SetWindowType(WindowType.Standart))
            {
                CreateWindow(new WindowStandart(), 0, _viewModel.Type, null);
            }
            else if (_viewModel.Type == SetWindowType(WindowType.Cloud))
            {
                CreateWindow(new WindowCloud(), 0, _viewModel.Type, null);
            }
            else if (_viewModel.Type == SetWindowType(WindowType.Heart))
            {
                CreateWindow(new WindowHeart(), 0, _viewModel.Type, null);
            }
        }
        private void DeleteFromDB(StikerViewModel _viewModel)
        {
            var findStiker = _context.StikerModels.FirstOrDefault(stiker => stiker.Id == _viewModel.Id);
            if (findStiker != null)
            {
                _context.StikerModels.Remove(findStiker);
                _context.SaveChanges();
            }
            Close(_viewModel);
        }
        private void Close(StikerViewModel _viewModel)
        {
            foreach (var window in WindowList)
            {
                if (_viewModel.Id == ((StikerViewModel)(window.DataContext)).Id)
                {
                    _viewModel.PropertyChanged -= window_PropertyChanged;
                    window.Close();
                }
            }
        }
        private void ToStandart(StikerViewModel _viewModel)
        {
            CreateWindow(new WindowStandart(), 0, SetWindowType(WindowType.Standart), _viewModel.Text);
            DeleteFromDB(_viewModel);
        }
        private void ToCloud(StikerViewModel _viewModel)
        {
            CreateWindow(new WindowCloud(), 0, SetWindowType(WindowType.Cloud), _viewModel.Text);
            DeleteFromDB(_viewModel);
        }
        private void ToHeart(StikerViewModel _viewModel)
        {
            CreateWindow(new WindowHeart(), 0, SetWindowType(WindowType.Heart), _viewModel.Text);
            DeleteFromDB(_viewModel);
        }
    }
}