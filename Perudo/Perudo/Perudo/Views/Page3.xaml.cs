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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent();
		}

	    void Clicked_validate(object sender, EventArgs e)
	    {
	        var Des_Values = DesValues.Text.ToString();
            var nb_Des = DesNb.Text.ToString();
            new Label
	        {
	            Text = "Valeur des dés" + Des_Values,
	            Font = Font.SystemFontOfSize(NamedSize.Large),
	            HorizontalOptions = LayoutOptions.Center,
	            VerticalOptions = LayoutOptions.CenterAndExpand
	        };
	        new Label
	        {
	            Text = "Nombre de dés" + nb_Des,
	            Font = Font.SystemFontOfSize(NamedSize.Default),
	            HorizontalOptions = LayoutOptions.Center,
	            VerticalOptions = LayoutOptions.CenterAndExpand
	        };
	    }

	    void Click_Kelza(object sender, EventArgs e)
	    {
	        
	    }
	    void Click_Bluff(object sender, EventArgs e)
	    {

	    }

	    void SavePartie(object sender, EventArgs e)
	    {
	        
	    }


    }
}