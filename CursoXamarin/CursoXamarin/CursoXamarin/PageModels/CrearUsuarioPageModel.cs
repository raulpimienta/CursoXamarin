using CursoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                RaisePropertyChanged("Nombre");
            }
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

        public override void Init(object initData)
        {
            base.Init(initData);

            var listCiudad = new List<Ciudad>();
            listCiudad.Add(new Ciudad { Estado = "Sonora", NombreCiudad = "Obregon", Id = 0 });
            listCiudad.Add(new Ciudad { Estado = "Sonora", NombreCiudad = "Hermosillo", Id = 1 });
            listCiudad.Add(new Ciudad { Estado = "Sonora", NombreCiudad = "Guaymas", Id = 2 });

            ListCiudades = listCiudad.ToList();

            var listEstado = new List<Estado>();
            listEstado.Add(new Estado { NombreEstado = "Sonora", Id = 0 });
            listEstado.Add(new Estado { NombreEstado = "Chihuahua",  Id = 1 });

            ListEstados = listEstado.ToList();
        }
    }
}