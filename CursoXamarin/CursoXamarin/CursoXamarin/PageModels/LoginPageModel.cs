using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Xamarin.Forms;

namespace CursoXamarin.PageModels
{
    public class LoginPageModel : BasePageModel
    {
        #region PROPIERTIES

        string _mensaje;
        public string Mensaje
        {
            get { return _mensaje; }
            set
            {
                _mensaje = value;
                RaisePropertyChanged("Mensaje");
            }
        }

        string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged("Email");
            }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged("Password");
            }
        }

        #endregion

        public override void Init(object initData)
        {
            base.Init(initData);
            Mensaje = "Login";
        }

        #region COMMANDS

        public Command GuardarCommand
        {
            get
            {
                return new Command(async () =>
                {

                    var mensaje = "";
                    if(Email == "admin" && Password == "123") { mensaje = "Bienvenido"; } else { mensaje = "Email o Password incorrectos"; } 

                    await CoreMethods.DisplayAlert("Mensaje", mensaje, "Ok");
                });
            }
        }

        #endregion

    }
}