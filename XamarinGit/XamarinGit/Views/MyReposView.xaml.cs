
using Xamarin.Forms;

namespace XamarinGit.Views
{
    public partial class MyReposView : ContentPage
    {
        public MyReposView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.ReposViewModel();
            this.ListRepos.ItemTapped += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new Views.RepoView(e.Item as Model.Repo));
            };
        }

    }
}
