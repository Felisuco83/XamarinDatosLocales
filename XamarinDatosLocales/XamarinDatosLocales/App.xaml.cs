using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDatosLocales.Views;

namespace XamarinDatosLocales
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new FicheroSimpleView();
            //MainPage = new AlumnosView();            
            //MainPage = new SeriesView();
            //MainPage = new SeriesCarruselView();
            MainPage = new PeliculasView();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
