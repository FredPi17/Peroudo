using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perudo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}
	    void submit_Clicked(object sender, EventArgs e)
        { 
            var humains = Humans.Text;
	        var machine = Machine.Text;
            var np = new NavigationPage(root: new Page3());
	        Application.Current.MainPage = np;
	    }

    }
}