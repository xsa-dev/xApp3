using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xApp3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExersizeTwo : ContentPage
	{
		public ExersizeTwo ()
		{
			InitializeComponent ();

            var x = new OnPlatform<Thickness>
            {
                iOS = new Thickness(0, 20, 0, 0),
            };
            Padding = x;

        }
	}
}