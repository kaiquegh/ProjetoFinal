using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFinal.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            List<String> itens = new List<String>()
            {
                "ATRAÇÕES", "COMERCIO", "GASTRONOMIA", "HOSPEDAGEM"
            };
            MenuPrincipal.ItemsSource = itens;
		}
	}
}