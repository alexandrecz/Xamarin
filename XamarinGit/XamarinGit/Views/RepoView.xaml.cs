using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinGit.Views
{
    public partial class RepoView : ContentPage
    {
        public RepoView(Model.Repo repo)
        {
            InitializeComponent();
            this.BindingContext = repo;
        }
    }
}
