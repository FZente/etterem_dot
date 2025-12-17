using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Shared.Models;
using MyApp.Shared.Repos;
using System.Collections.ObjectModel;

namespace MyApp.Shared.ViewModels
{
    public partial class UserViewModel : ObservableObject
    {
        private readonly UserRepo _repo = new UserRepo();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private User? selectedUser;

        public ObservableCollection<User> Users { get; }

        public UserViewModel() 
        {
            Users = new ObservableCollection<User>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDeleteSelected))]
        private void DeleteSelected()
        {
            if (SelectedUser is null) return;

            _repo.Remove(SelectedUser);
            Users.Remove(SelectedUser);
            SelectedUser = null;
        }

        private bool CanDeleteSelected()
        {
            return true;
        }
    }
}
