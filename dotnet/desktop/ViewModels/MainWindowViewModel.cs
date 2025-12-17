using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Shared.ViewModels;

namespace MyApp.Desktop.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly ControlPanelViewModel _controlPanelViewModel = new ControlPanelViewModel();
        private readonly RestaurantViewModel _restaurantViewModel = new RestaurantViewModel();
        private readonly UserViewModel _userViewModel = new UserViewModel();
        private readonly ReviewViewModel _reviewViewModel = new ReviewViewModel();

        [ObservableProperty]
        public object _currentView = new object();

        public MainWindowViewModel()
        {
            _currentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowControlPanalView()
        {
            CurrentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowRestaurantView()
        {
            CurrentView = _restaurantViewModel;
        }

        [RelayCommand]
        private void ShowReviewView()
        {
            CurrentView = _reviewViewModel;
        }

        [RelayCommand]
        private void ShowUserView()
        {
            CurrentView = _userViewModel;
        }
    }
}
