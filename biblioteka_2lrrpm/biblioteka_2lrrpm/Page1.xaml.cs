using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace biblioteka_2lrrpm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}
        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("KD", Int1.Text, "g");
            Regex pass_regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");

            DateTime selectedDate = birthDatePicker.Date;

            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = new DateTime(2024, 2, 15);

            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");

            if (login_regex.Match(Int1.Text).Success /*&& Int1 !=null*/)
            {


            }
            else
            {
                await DisplayAlert("Регистрация", "Измените логин", "OK");
                return;
            }
            if (pass_regex.Match(Int2.Text).Success /*&& Int2 != null && Int3 != null*/)
            {
                if (Int2.Text == Int3.Text)
                {

                }
                else
                {
                    await DisplayAlert("Регистрация", "Пароли не совпадают", "OK");
                    return;
                }
            }
            else
            {
                await DisplayAlert("Регистрация", "Измените пароль", "OK");
                return;
            }
            if (selectedDate > minDate && selectedDate < maxDate)
            {
                await DisplayAlert("Регистрация", "Вы успешно зарегистрированы", "OK");
                MainPage page = new MainPage();
                await Navigation.PushAsync(page);

            }
            else
            {
                await DisplayAlert("Регистрация", "Измените дату рождения", "OK");
                return;
            }


        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {

        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (Switch.IsToggled == false)
            {
                NNN.BackgroundColor = Color.Gray;
                Int1.BackgroundColor = Color.Gray;
                Int2.BackgroundColor = Color.Gray;
                Int3.BackgroundColor = Color.Gray;
                Int4.BackgroundColor = Color.Gray;
                Int5.BackgroundColor = Color.Gray;
                Int6.BackgroundColor = Color.Gray;
                Int1.TextColor = Color.Black;
                Int2.TextColor = Color.Black;
                Int3.TextColor = Color.Black;
                Int4.TextColor = Color.Black;
                btn1.TextColor = Color.Black;
                btn2.TextColor = Color.Black;
                btn1.BackgroundColor = Color.White;
                btn2.BackgroundColor = Color.White;
                btn2.BorderColor = Color.Black;
                btn1.BorderColor = Color.Black;

            }
            else
            {
                NNN.BackgroundColor = Color.Black;
                Int1.BackgroundColor = Color.Black;
                Int2.BackgroundColor = Color.Black;
                Int3.BackgroundColor = Color.Black;
                Int4.BackgroundColor = Color.Black;
                Int5.BackgroundColor = Color.Black;
                Int6.BackgroundColor = Color.Black;
                Int1.TextColor = Color.White;
                Int2.TextColor = Color.White;
                Int3.TextColor = Color.White;
                Int4.TextColor = Color.White;
                btn1.TextColor = Color.White;
                btn2.TextColor = Color.White;
                btn1.BackgroundColor = Color.Gray;
                btn2.BackgroundColor = Color.Gray;
                btn2.BorderColor = Color.White;
                btn1.BorderColor = Color.White;

            }
        }

        private async Task btn3_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushAsync(page);

        }

        private void btn3_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
