using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCode : ContentPage
    {
        public ListViewCode()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = new string[]
            {
                "mono",
                "monodroid",
                "monotouch",
                "monotrail",
                "monodevelop",
                "monotone",
                "monopoly",
                "monomodal",
                "mononucleosis",
            };

        }
    }
}