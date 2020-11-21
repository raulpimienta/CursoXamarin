using Acr.UserDialogs;
using CursoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CursoXamarin.PageModels
{
    public class CrearUsuarioPageModel : BasePageModel
    {
        string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                IsValidNombre(value);
                RaisePropertyChanged("Nombre");
            }
        }

        bool _nombreHasError;
        public bool NombreHasError
        {
            get { return _nombreHasError; }
            set
            {
                _nombreHasError = value;
                RaisePropertyChanged("NombreHasError");
            }
        }

        public void IsValidNombre(string newValue)
        {
            NombreHasError = String.IsNullOrEmpty(newValue);
        }

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
                RaisePropertyChanged("SelectedCiudad");
            }
        }

        List<Estado> _listEstados;
        public List<Estado> ListEstados
        {
            get { return _listEstados; }
            set
            {
                _listEstados = value;
                RaisePropertyChanged("ListEstados");
            }
        }

        Estado _selectedEstado;
        public Estado SelectedEstado
        {
            get { return _selectedEstado; }
            set
            {
                _selectedEstado = value;
                RaisePropertyChanged("SelectedEstado");
            }
        }

        DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                _fechaNacimiento = value;
                RaisePropertyChanged("FechaNacimiento");
            }
        }

        bool _isCheckedPuedeViajar;
        public bool IsCheckedPuedeViajar
        {
            get { return _isCheckedPuedeViajar; }
            set
            {
                _isCheckedPuedeViajar = value;
                RaisePropertyChanged("IsCheckedPuedeViajar");
            }
        }

        bool _isToggledTieneCarro;
        public bool IsToggledTieneCarro
        {
            get { return _isToggledTieneCarro; }
            set
            {
                _isToggledTieneCarro = value;
                RaisePropertyChanged("IsToggledTieneCarro");
            }
        }

        bool _isCheckedRed;
        public bool IsCheckedRed
        {
            get { return _isCheckedRed; }
            set
            {
                _isCheckedRed = value;
                RaisePropertyChanged("IsCheckedRed");
            }
        }

        bool _isCheckedBlue;
        public bool IsCheckedBlue
        {
            get { return _isCheckedBlue; }
            set
            {
                _isCheckedBlue = value;
                RaisePropertyChanged("IsCheckedBlue");
            }
        }

        bool _isCheckedGreen;
        public bool IsCheckedGreen
        {
            get { return _isCheckedGreen; }
            set
            {
                _isCheckedGreen = value;
                RaisePropertyChanged("IsCheckedGreen");
            }
        }

        bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                RaisePropertyChanged("IsLoading");
            }
        }

        

        public async override void Init(object initData)
        {
            base.Init(initData);

            var listCiudad = new List<Ciudad>();
            listCiudad.Add(new Ciudad { Estado = "Sonora", NombreCiudad = "Obregon", Id = 0 });
            listCiudad.Add(new Ciudad { Estado = "Sonora", NombreCiudad = "Hermosillo", Id = 1 });
            listCiudad.Add(new Ciudad { Estado = "Sonora", NombreCiudad = "Guaymas", Id = 2 });

            ListCiudades = listCiudad.ToList();

            var listEstado = new List<Estado>();
            listEstado.Add(new Estado { NombreEstado = "Sonora", Id = 0 });
            listEstado.Add(new Estado { NombreEstado = "Chihuahua", Id = 1 });

            ListEstados = listEstado.ToList();

            FechaNacimiento = DateTime.Now;

            IsCheckedPuedeViajar = true;

            IsToggledTieneCarro = false;

            IsLoading = true;

            await Task.Delay(TimeSpan.FromSeconds(5));

            IsLoading = false;

        }

        public Command CrearUsuarioCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsValidNombre(Nombre);

                    if (NombreHasError) { return; }

                    using (PageDialog.Loading("Cargando...", null, null, true, MaskType.Black))
                    {
                        await Task.Delay(TimeSpan.FromSeconds(5));
                    }

                });
            }
        }

    }
}