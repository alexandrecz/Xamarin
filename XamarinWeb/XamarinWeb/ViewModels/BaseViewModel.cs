using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinWeb.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public ICommand GetReposCommand { get; set; }

        private bool isLoading = false;
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                isLoading = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoading)));
            }
        }

        private ObservableCollection<Model.Repo> repos;
        public ObservableCollection<Model.Repo> Repos
        {
            get { return repos; }
            set
            {
                repos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Repos)));
            }
        }

        public BaseViewModel()
        {
            
            GetReposCommand = new Xamarin.Forms.Command(async () =>
            {
                IsLoading = true;
                var repos = await Api.RestApi.GetReposAsync();
                Repos = new ObservableCollection<Model.Repo>(repos);
                IsLoading = false;
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

