
using Xamarin.Forms;

namespace XamarinUI
{
    public class MainTab : TabbedPage
    {
        readonly NavigationPage tab1Page;
        readonly NavigationPage tab2Page;
        readonly NavigationPage tab3Page;

        public MainTab()
        {
            tab1Page = new NavigationPage(new Views.PopupView())
            {
                Title = "POPUP",
                Icon = "square.png"
            };
            tab2Page = new NavigationPage(new Views.DateView())
            {
                Title = "DATE",
                Icon = "square.png"
            };
            tab3Page = new NavigationPage(new Views.PickerView())
            {
                Title = "PICKER",
                Icon = "square.png"
            };
            Children.Add(tab1Page);
            Children.Add(tab2Page);
            Children.Add(tab3Page);
        }
    }
}

