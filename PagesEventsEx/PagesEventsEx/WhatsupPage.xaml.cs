using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesEventsEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WhatsupPage : CarouselPage
    {
        public WhatsupPage()
        {
            InitializeComponent();

            Children.Add(new ChatPage());
            Children.Add(new StatusPage());
            Children.Add(new CallsPage());

        }
    }
}