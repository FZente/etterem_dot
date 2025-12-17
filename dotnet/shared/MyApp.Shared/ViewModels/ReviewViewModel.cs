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
    public partial class ReviewViewModel : ObservableObject
    {
        private readonly ReviewRepo _repo = new ReviewRepo();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Review? selectedReview;

        public ObservableCollection<Review> Reviews { get; }

        public ReviewViewModel() 
        {
            Reviews = new ObservableCollection<Review>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDeleteSelected))]
        private void DeleteSelected()
        {
            if (SelectedReview is null) return;

            _repo.Remove(SelectedReview);
            Reviews.Remove(SelectedReview);
            SelectedReview = null;
        }

        private bool CanDeleteSelected()
        {
            return true;
        }
    }
}
