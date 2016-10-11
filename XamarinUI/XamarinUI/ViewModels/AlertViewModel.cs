using System.ComponentModel;
using System.Windows.Input;

namespace XamarinUI.ViewModels
{
    public class AlertViewModel : INotifyPropertyChanged
    {
        public ICommand AlertCommand { get; set; }
        public ICommand YesNoCommand { get; set; }
        public ICommand ActionSheetCommand { get; set; }

        public AlertViewModel()
        {
            AlertCommand = new Xamarin.Forms.Command(async () =>
            {
                await App.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
            });

            ActionSheetCommand = new Xamarin.Forms.Command(async () =>
            {
                var action = await App.Current.MainPage.DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
                await App.Current.MainPage.DisplayAlert("Alert", $"You choose the action {action} ", "OK");
            });


            YesNoCommand = new Xamarin.Forms.Command(async () =>
            {
                var result = await App.Current.MainPage.DisplayAlert("Alert!", "Do you really want to exit ? ", "Yes", "No");

                if (result)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "You choose YES", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "You choose NO", "OK");
                }

            });
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
