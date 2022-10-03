using PumpsTests.Models;
using PumpsTests.Services;
using PumpsTests.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PumpsTests.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private RelayCommand? _minimizeWindow { get; set; }
        private RelayCommand? _topmostWindow { get; set; }
        public RelayCommand? _closeWindow { get; set; }
        public RelayCommand MinimizeWindow
        {
            get
            {
                return _minimizeWindow ?? (_minimizeWindow = new RelayCommand(obj =>
                {
                    CurrentWindowState = WindowState.Minimized;
                }));
            }
        }
        public RelayCommand TopmostWindow 
        {
            get
            {
                return _topmostWindow ?? (_topmostWindow = new RelayCommand(obj =>
                {
                    TopMostState = !TopMostState;
                }));
            }
        }

        private WindowState _windowState;
        public WindowState CurrentWindowState
        {
            get { return _windowState; }

            set
            {
                _windowState = value;
                OnPropertyChanged(nameof(CurrentWindowState));
            }
        }

        private bool _topMostState;
        public bool TopMostState 
        {
            get
            {
                return _topMostState;
            }
            set
            {
                _topMostState = value;
                OnPropertyChanged(nameof(TopMostState));
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<DataModel> DataModels { get; set; } = new ObservableCollection<DataModel>();
        public ObservableCollection<string> Ports { get; set; } = new ObservableCollection<string>();

        private Comhandler ComHandler = new Comhandler();

        public ApplicationViewModel()
        {
            for (int i = 0; i < 25; i++)
            {
                DataModels.Add(new DataModel()
                {
                    MyProperty = i.ToString(),
                    MyProperty1 = i.ToString(),
                    MyProperty2 = i.ToString(),
                    MyProperty3 = i.ToString(),
                    MyProperty4 = i.ToString(),
                    MyProperty5 = i.ToString()
                }); ;
            }

            GetPorts();
        }

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private async void GetPorts()
        {
            var result = await ComHandler.GetPorts();

            foreach (var item in result)
            {
                Ports.Add(item);
            }
        }
    }
}
