using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApis.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Publicacion : ContentPage
	{
		public Publicacion ()
		{
			InitializeComponent ();
		}

        private void ListPublicacion_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

        }

        private void CargarPublicacion()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("") //PENDIENTE VER EN VIDEO PARTE https://www.youtube.com/watch?v=BhTwA9aiO4M Y MINUTO 40
        }
    }
}