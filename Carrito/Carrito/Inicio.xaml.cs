using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Carrito.View;
namespace Carrito
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Iniciar_Clicked(object sender, EventArgs e)
        {
            Control c=new Control();
            Content = c.Content;
        }
    }
}
