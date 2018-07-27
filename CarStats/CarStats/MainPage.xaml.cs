using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PCLStorage;

namespace CarStats
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Test();
		    ButtonStartStop.Text = "Start";
		}

	    private void Test()
	    {
	        
	    }

	    private void ButtonStartStop_OnClicked(object sender, EventArgs e)
	    {
	        ButtonStartStop.Text = ButtonStartStop.Text == "Start" ? "Stop" : "Start";
	    }
	}
}
