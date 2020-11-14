using CursoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CursoXamarin.PageModels
{
    public class ListaCiudadesPageModel : BasePageModel
    {
        List<Ciudad> _listCiudades;
        public List<Ciudad> ListCiudades
        {
            get { return _listCiudades; }
            set
            {
                _listCiudades = value;
                RaisePropertyChanged("ListCiudades");
            }
        }

        Ciudad _selectedCiudad;
        public Ciudad SelectedCiudad
        {
            get { return _selectedCiudad; }
            set
            {
                _selectedCiudad = value;
                if (value != null)
                {
                    CiudadSelected.Execute(value);
                    _selectedCiudad = null;
                }
                RaisePropertyChanged("SelectedCiudad");
            }
        }

        public Command<Ciudad> CiudadSelected
        {
            get
            {
                return new Command<Ciudad>(async (ciudad) =>
                {
                    await CoreMethods.DisplayAlert("Ciudad", ciudad.NombreCiudad, "Ok");
                });
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            ListCiudades = initData as List<Ciudad>;
        }
    }
}