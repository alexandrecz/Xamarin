using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinUI.Views
{
    public partial class SearchBarView : ContentPage
    {
        public SearchBarView()
        {
            InitializeComponent();

            SearchBar.SearchCommand = new Command(() => { LabelResult.Text = $"Result: {SearchBar.Text} is what you asked for."; });
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
        }
    }
}
