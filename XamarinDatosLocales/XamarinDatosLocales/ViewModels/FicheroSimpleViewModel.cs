using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinDatosLocales.Helpers;

namespace XamarinDatosLocales.ViewModels
{
    public class FicheroSimpleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _Data;
        public string Data { get { return this._Data; } set { this._Data = value; OnPropertyChanged("Data"); } }
        public Command ReadFile
        {
            get
            {
                return new Command(() =>
                {
                    HelperFiles helper = new HelperFiles();
                    this.Data = helper.ReadFile("XamarinDatosLocales.Documents.prueba.txt");
                });
            }
        }
    }
}
