using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TCC1.Commands;
using TCC1.Models;
using TCC1.Views;

namespace TCC1.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }


        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);


        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }
    }
}
