using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	        
	    }

	    void Click_Kelza(object sender, EventArgs e)
	    {
	        App.CurrentPartie.Kelza();

	    }
	    void Click_Bluff(object sender, EventArgs e)
	    {

	    }
	    public class Employee
	    {
	        public string DisplayName { get; set; }
	    }
	    ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
	    public EmployeeListPage()
	    {
	        //defined in XAML to follow
	        EmployeeView.ItemsSource = employees;
	            ...
	    }



    }
}