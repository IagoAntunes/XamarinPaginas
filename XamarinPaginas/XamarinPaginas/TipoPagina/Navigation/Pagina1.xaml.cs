using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPaginas.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }


        private void MudarParaPagina2(object sender, EventArgs args)
        {
            //App.Current.MainPage = new Pagina2();
            Navigation.PushAsync(new Pagina2());
        }
        private void ChamarModal(Object sender,EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }
        private void ChamarMaster(Object sender,EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
            //Master,Tabbed,Carousel
        }
    }
}