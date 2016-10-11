
using Xamarin.Forms;

namespace XamarinGit
{
    public class MainTabPage : TabbedPage
    {
        readonly NavigationPage tab2Page;
        readonly NavigationPage tab1Page;

        public MainTabPage()
        {
            tab1Page = new NavigationPage(new Views.ReposView())
            {
                Title = "By name",
                Icon = "square.png"
            };
            Children.Add(tab1Page);
            // The title of the page added to Children will be the tab name as well.
            // The tab icon is pulled from the child page's Icon (for iOS)
            tab2Page = new NavigationPage(new Views.MyReposView())
            {
                Title = "By user",
                Icon = "circle" // extension isn't required
            };
            Children.Add(tab2Page);
        }
    }
}
