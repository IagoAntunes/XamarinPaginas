using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPaginas.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TIpoPagina3 : ContentPage
    {
        public TIpoPagina3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)//Muda Pagina
        {
            App.Current.MainPage = new NavigationPage(new Navigation.Pagina1())
            {
                //BarBackgroundColor = Color.Red
            };



        }
    }
}