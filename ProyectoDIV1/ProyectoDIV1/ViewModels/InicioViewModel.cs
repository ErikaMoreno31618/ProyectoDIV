using ProyectoDIV1.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoDIV1.ViewModels
{
    public class InicioViewModel : Usuario
    {
        #region Commands
        public Command LoginCommand { get; }

        #endregion


        public InicioViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }
        // alertas del LoginPage
        private async void OnLoginClicked(object obj)
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe ingresar un correo electrónico.",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe ingresar la contraseña.",
                    "Aceptar");
                return;
            }

            if (this.Email != "diegop177@hotmail.com" || this.Password != "programacion15")
            {
                await Application.Current.MainPage.DisplayAlert(
                  "Error",
                  "Correo electrónico y/o contraseña incorrecta.",
                  "Aceptar");
                this.Password = string.Empty;
                return;
            }
            this.Email = string.Empty;
            this.Password = string.Empty;

           // MainViewModel.GetInstance().HomeApp = new HomeAppViewModel();
            //await Application.Current.MainPage.Navigation.PushAsync(new AppTabbedPage());
        }
       
    }
}
