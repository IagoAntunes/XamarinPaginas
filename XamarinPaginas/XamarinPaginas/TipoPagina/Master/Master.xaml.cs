using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPaginas.TipoPagina.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void MudarPagina01(object sender,EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.Pagina1());
            IsPresented = true;
        }     
        private void MudarPagina02(object sender,EventArgs args)
        {
            Detail = new Navigation.Pagina2();
            IsPresented = true;
        }
        private void MudarPagina03(object sender,EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = true;
        }
    }
}