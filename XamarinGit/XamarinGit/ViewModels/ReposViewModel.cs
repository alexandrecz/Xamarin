using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace XamarinGit.ViewModels
{
    public class ReposViewModel : INotifyPropertyChanged
    {
        public ICommand GetReposCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }


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

        public ReposViewModel()
        {
            Repos = new ObservableCollection<Model.Repo>();

            GetReposCommand = new Xamarin.Forms.Command(async () =>
            {
                IsLoading = true;
                var repos = await ApiGit.Api.GetMyReposAsync(this.name);
                Repos = new ObservableCollection<Model.Repo>(repos);
                IsLoading = false;
            });


            SearchCommand = new Xamarin.Forms.Command(async () =>
            {
                IsLoading = true;
                var repos = await ApiGit.Api.GetReposByNameAsync(this.name);
                Repos = new ObservableCollection<Model.Repo>(repos);
                IsLoading = false;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
