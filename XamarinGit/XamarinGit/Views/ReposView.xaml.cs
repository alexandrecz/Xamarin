using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinGit.Views
{
    public partial class ReposView : ContentPage
    {
        public ReposView()
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
