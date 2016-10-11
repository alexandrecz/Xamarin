
using Xamarin.Forms;

namespace XamarinUI.Views
{
    public partial class PopupView : ContentPage
    {
        public PopupView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.AlertViewModel();
        }
    }
}
