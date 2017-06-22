using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ExamDictionary.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            var openUrl = new Button
            {
                Text = "Реализовано с помощью сервиса «API «Яндекс.Словарь»",
                BackgroundColor = Color.Transparent,
        };
            openUrl.Clicked += (sender, e) => {
                if (Device.OS != TargetPlatform.WinPhone)
                {
                    Device.OpenUri(new Uri("http://api.yandex.ru/dictionary/"));
                }
                else
                {
                    DisplayAlert("Ошибка", "404", "Закрыть");
                }
            };

            Content = new StackLayout
            {
                Padding = new Thickness(5, 20, 5, 0),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    openUrl,
                   }
            };
        }

    }
}
