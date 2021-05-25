using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinDatosLocales.Models;
using XamarinDatosLocales.Repositories;

namespace XamarinDatosLocales.ViewModels
{
    public class AlumnosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private List<Alumno> _Alumnos;
        public List<Alumno> Alumnos { get { return this._Alumnos; } set { this._Alumnos = value; OnPropertyChanged("Data"); } }
        public Command MostrarAlumnos
        {
            get
            {
                return new Command(() =>
                {
                    RepositoryAlumnos repo = new RepositoryAlumnos();
                    this.Alumnos = repo.GetAlumnos();
                });
            }
        }
    }
}
