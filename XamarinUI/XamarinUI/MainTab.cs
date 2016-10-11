
using Xamarin.Forms;

namespace XamarinUI
{
    public class MainTab : TabbedPage
    {
        readonly NavigationPage tab1Page;
        readonly NavigationPage tab2Page;

        public MainTab()
        {
            tab1Page = new NavigationPage(new Views.PopupView())
            {
                Title = "POPUP",
                Icon = "square.png"
            };
            //tab2Page = new NavigationPage(new Views.ActionSheetView())
            //{
            //    Title = "ACTIONSHEET",
            //    Icon = "square.png"
            //};
            Children.Add(tab1Page);
            //Children.Add(tab2Page);
        }
    }
}
