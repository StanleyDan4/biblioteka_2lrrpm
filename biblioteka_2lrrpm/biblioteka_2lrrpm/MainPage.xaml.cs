using System;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace biblioteka_2lrrpm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)

        {
            string login = Log.Text;
            string password = Pas.Text;
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                // Если одно из полей пустое, выводим сообщение об ошибке
                await DisplayAlert("Ошибка", "Введите логин и пароль", "OK");
                return; // Прерываем выполнение метода
            }
            if (Pick.SelectedIndex == 0)
            {
                Menu page = new Menu();
                await Navigation.PushAsync(page);
            }
            if (Pick.SelectedIndex == 1)
            {
                Menu1 page = new Menu1();
                await Navigation.PushAsync(page);
            }
            if (Pick.SelectedIndex == 2)
            {
                Menu2 page = new Menu2();
                await Navigation.PushAsync(page);
            }
        }

        private async Task bbb_Clicked(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            await Navigation.PushAsync(page);
        }

        private void bbb_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
