using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinWeb
{
    public class MainTab : TabbedPage
    {
        readonly NavigationPage tab1Page;

        public MainTab()
        {
            tab1Page = new NavigationPage(new Views.MainView())
            {
                Title = "REST",
                Icon = "home.png"
            };
            Children.Add(tab1Page);
        }
    }
}
