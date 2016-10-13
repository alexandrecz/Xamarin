using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinUI.Views
{
    public partial class PickerView : ContentPage
    {
        Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Blue", Color.Blue }, { "Fuschia", Color.Fuchsia },
            { "Gray", Color.Gray }, { "Green", Color.Green },
            { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
            { "Navy", Color.Navy }, { "Olive", Color.Olive },
            { "Purple", Color.Purple }, { "Red", Color.Red },
            { "Silver", Color.Silver }, { "Teal", Color.Teal },
            { "White", Color.White }, { "Yellow", Color.Yellow }
        };


        public PickerView()
        {
            InitializeComponent();

            Picker.HorizontalOptions = LayoutOptions.CenterAndExpand;
            Picker.Title = "Color";
            Box.WidthRequest = 150;
            Box.HeightRequest = 150;

            foreach (var item in nameToColor.Keys)
            {
                Picker.Items.Add(item);
            }

            Picker.SelectedIndexChanged += (sender, args) =>
            {
                if (Picker.SelectedIndex == -1)
                {
                    Box.Color = Color.Default;
                }
                else
                {
                    Box.Color = nameToColor[Picker.Items[Picker.SelectedIndex]];
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

        }
    }
}
