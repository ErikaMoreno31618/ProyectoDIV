using Firebase.Auth;
using Microsoft.AppCenter.Crashes;
using ProyectoDIV1.Services;
using System;
using System.Threading.Tasks;

namespace ProyectoDIV1.Droid.Service
{
    public class FireBaseHelpers : IFirebaseAuthenticator
    {
        public async Task<string> CrearCuenta(string email, string password)
        {
            try
            {
                var signUpTask = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                var token = await signUpTask.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (Firebase.Auth.FirebaseAuthUserCollisionException)
            { return "CuentaExistente"; }
            catch (Exception exGen)
            {
                Crashes.TrackError(exGen);
                return "";
            }
        }
    }
}